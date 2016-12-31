using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XY_TableCommunicationLibrary
{
    public class XY_TableCommunicationClass
    {
        //public class XY_ValueEventArgs : EventArgs
        //{
        //    public string Value
        //    {
        //        get;
        //        private set;
        //    }

        //    public XY_ValueEventArgs(string val)
        //    {
        //        Value = val;
        //    }
        //}

        #region 屬性欄位

        //FTP屬性欄位
        public string FtpUploadFileName { get { return ftpUploadFileName; } }

        private string ftpUploadFileName = "TablePoint.csv";

        public string Path { set; get; }
        public string Id { set; get; }
        public string Password { set; get; }

        //TCP Socket屬性欄位
        private TcpClient tcpSocketClient = new TcpClient();

        private const int tcpSocketPort = 1024;

        private bool isClose = false;

        public bool TcpServerConnected
        {
            get
            {
                return tcpSocketClient.Connected;
            }
        }

        //PC <- Controller
        public byte[] ControllerReadFlags = new byte[4];

        public double[] ControllerReadWords = new double[4];

        //PC -> Controller
        public byte[] ControllerWriteFlags = new byte[11];

        public double[] ControllerWriteWords = new double[5];

        //PC <- Controller(EventHandler使用[當數值變化時觸發event])
        private byte[] compareReadFlags = { 2, 2, 2, 2 };

        private double[] compareReadWords = { 0.1, 0.1, 0.1, 0.1 };

        public Exception TcpLinkError = null;

        #endregion 屬性欄位

        #region Event宣告

        //public delegate void XYEventHandler(object sender, XY_ValueEventArgs args);
        //public event XYEventHandler Changed;
        public event EventHandler Changed;

        public event EventHandler SocketConnected;

        public event EventHandler SocketLinkTimeOuted;

        protected virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
                Changed(this, e);
        }

        protected virtual void OnSocketConnected(EventArgs e)
        {
            if (SocketConnected != null)
                SocketConnected(this, e);
        }

        protected virtual void OnSocketLinkTimeOuted(EventArgs e)
        {
            if (SocketLinkTimeOuted != null)
                SocketLinkTimeOuted(this.TcpLinkError.Message, e);
        }

        private void ValueCompare()
        {
            if (!compareReadFlags.SequenceEqual(ControllerReadFlags) || !compareReadWords.SequenceEqual(ControllerReadWords))
            {
                if (null != Changed)
                {
                    //Changed(this, new XY_ValueEventArgs(ControllerReadWords[0].ToString()));
                    OnChanged(EventArgs.Empty);
                }

                for (int i = 0; i != ControllerReadFlags.Count(); ++i)
                {
                    compareReadFlags[i] = ControllerReadFlags[i];
                    compareReadWords[i] = ControllerReadWords[i];
                }
            }
        }

        private void getSocketConnected()
        {
            if (tcpSocketClient.Connected == true)
                OnSocketConnected(EventArgs.Empty);
        }

        #endregion Event宣告

        public XY_TableCommunicationClass(string path, string id, string password)
        {
            this.Path = path;
            this.Id = id;
            this.Password = password;
        }

        #region FTP資料處理(根目錄List確認 & 上傳File至FTP Server)

        private bool GetFtpServerFileExist()
        {
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + this.Path);
            ftpRequest.Credentials = new NetworkCredential(this.Id, this.Password);
            ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;

            WebResponse ftpResponse = ftpRequest.GetResponse();
            Stream ftpStream = ftpResponse.GetResponseStream();
            StreamReader ftpStreamReader = new StreamReader(ftpStream);
            string serverFolderFileList = ftpStreamReader.ReadToEnd();

            return serverFolderFileList.Contains(this.FtpUploadFileName);
        }

        public void FtpFileUpload(string readFilePath)
        {
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + this.Path + "/MEMCARD1/"
                                                                                 + FtpUploadFileName);
            ftpRequest.Credentials = new NetworkCredential(this.Id, this.Password);

            ftpRequest.Method = GetFtpServerFileExist() == true ? WebRequestMethods.Ftp.UploadFile
                                                                       : WebRequestMethods.Ftp.UploadFile;

            StreamReader sourceStream = new StreamReader(readFilePath);

            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());

            sourceStream.ReadToEnd();
            sourceStream.Close();
            ftpRequest.ContentLength = fileContents.Length;

            Stream requestStream = ftpRequest.GetRequestStream();

            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();

            FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
            response.Close();
        }

        #endregion FTP資料處理(根目錄List確認 & 上傳File至FTP Server)

        #region SocketTCP資料處理

        public void ConnectTcpServer()
        {
            tcpSocketClient.Connect(this.Path, tcpSocketPort);
            NetworkStream netStream = new NetworkStream(tcpSocketClient.Client);

            getSocketConnected();
        }

        public void BreakTcpServer()
        {
            isClose = true;
        }

        public bool ExchangeTcpData()
        {
            NetworkStream tcpSocketStream = new NetworkStream(tcpSocketClient.Client);
            StreamReader tcpSocketReader = new StreamReader(tcpSocketStream);
            StreamWriter tcpSocketWriter = new StreamWriter(tcpSocketStream);
            string byteString = "";
            string wordString = "";
            string totalString = "";
            string controllerReadString;

            if (TcpServerConnected == true)
            {
                foreach (byte ControllerWriteFlag in ControllerWriteFlags)
                {
                    byteString += ControllerWriteFlag.ToString() + ",";
                }
                foreach (double ControllerWriteWord in ControllerWriteWords)
                {
                    wordString += ControllerWriteWord.ToString() + ",";
                }
                wordString = wordString.Remove(wordString.Length - 1);
                totalString = byteString + wordString + "\n";
                tcpSocketWriter.WriteLine(totalString);
                tcpSocketWriter.Flush();

                // Socket TCP 資料讀取
                controllerReadString = tcpSocketReader.ReadLine();
                //controllerReadString = controllerReadString.Remove(controllerReadString.Length - 1);

                string[] controllerReadSubStrings = controllerReadString.Split(',');

                for (int i = 0; i < 4; i++)
                {
                    ControllerReadFlags[i] = byte.Parse(controllerReadSubStrings[i]);

                    ControllerReadWords[i] = double.Parse(controllerReadSubStrings[i + 4]);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CycleExcangeData()
        {
            Thread exchangeDataThread = new Thread(new ThreadStart(ExchangeDataThread));
            exchangeDataThread.Start();
        }

        public void ExchangeDataThread()
        {
            while (TcpServerConnected)
            {
                if (isClose)
                    break;

                try
                {
                    ExchangeTcpData();
                }
                catch (Exception Error)
                {
                    TcpLinkError = Error;
                    OnSocketLinkTimeOuted(EventArgs.Empty);
                }
                ValueCompare();

                Thread.Sleep(100);
            }

            if (tcpSocketClient != null && isClose)
            {
                tcpSocketClient.Close();
                tcpSocketClient = null;
            }
        }

        #endregion SocketTCP資料處理
    }
}