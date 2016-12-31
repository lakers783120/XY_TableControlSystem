using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using XY_TableCommunicationLibrary;

namespace HMI_WindowsForms
{
    public partial class MainForm : Form
    {
        private static string path = "192.168.250.1";
        private static string id = "omron";
        private static string password = "omron1111";
        private XY_TableCommunicationClass XY_TableCommunication;
        private DataGridViewRowCollection XY_TableData;
        private XY_TableCurrentPositionForm XY_TableCurrentPositionForm;
        private Series XY_TableSeries = new Series();
        private string FtpReadFileName = "";

        public MainForm()
        {
            InitializeComponent();
            XY_TableData = XY_TableDataGridView.Rows;
            XY_TableSeries.ChartType = SeriesChartType.Line;
            XY_TableSeries.Color = Color.Red;
            this.XY_TableChart.Series.Add(XY_TableSeries);
            SetXY_TableCommunication();
        }

        private void XY_TableDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i <= XY_TableData.Count - 2; i++)
            {
                if (Convert.ToDouble(XY_TableData[i].Cells[0].Value) > 250)
                {
                    XY_TableData[i].Cells[0].Value = "250";
                    MessageBox.Show("數值設定不可超過250", "數值設定超過範圍");
                }

                if (Convert.ToDouble(XY_TableData[i].Cells[1].Value) > 250)
                {
                    XY_TableData[i].Cells[1].Value = "250";
                    MessageBox.Show("數值設定不可超過250", "數值設定超過範圍");
                }
            }
            UpdateScreen();
        }

        private void UpdateScreen()
        {
            XY_TableSeries.Points.Clear();
            for (int i = 0; i <= XY_TableData.Count - 2; i++)
            {
                XY_TableSeries.Points.AddXY(Convert.ToDouble(XY_TableData[i].Cells[0].Value),
                                             Convert.ToDouble(XY_TableData[i].Cells[1].Value));
            }
        }

        private void RowDeletePictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                XY_TableData.RemoveAt(XY_TableData.Count - 2);
                UpdateScreen();
            }
            catch
            {
                MessageBox.Show("XY Table已經無點位可移除", "異常");
            }
        }

        //private void ControllerValueChanged(object sender, XY_TableCommunicationClass.XY_ValueEventArgs e)
        private void ControllerValueChanged(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)(() =>
            {
                X_AxisCurrentPositionTextBox.Text = XY_TableCommunication.ControllerReadWords[0].ToString();
                X_AxisCurrentVelocityTextBox.Text = XY_TableCommunication.ControllerReadWords[1].ToString();
                Y_AxisCurrentPositionTextBox.Text = XY_TableCommunication.ControllerReadWords[2].ToString();
                Y_AxisCurrentVelocityTextBox.Text = XY_TableCommunication.ControllerReadWords[3].ToString();
                HomedPictureBox.Image = (XY_TableCommunication.ControllerReadFlags[0] == 1) ?
                                     HMI_WindowsForms.Properties.Resources.Image_ON : HMI_WindowsForms.Properties.Resources.Image_OFF;

                AutoRunningPictureBox.Image = (XY_TableCommunication.ControllerReadFlags[1] == 1) ?
                                     HMI_WindowsForms.Properties.Resources.Image_ON : HMI_WindowsForms.Properties.Resources.Image_OFF;

                PointReadedPictureBox.Image = (XY_TableCommunication.ControllerReadFlags[2] == 1) ?
                                     HMI_WindowsForms.Properties.Resources.Image_ON : HMI_WindowsForms.Properties.Resources.Image_OFF;

                ErrorPictureBox.Image = (XY_TableCommunication.ControllerReadFlags[3] == 1) ?
                     HMI_WindowsForms.Properties.Resources.Image_Alarm : null;
            }));
        }

        private void SocketConnected(object sender, EventArgs e)
        {
            DataExchangeTimer.Interval = 500;
            DataExchangeTimer.Enabled = true;
        }

        private void SocketLinkTimeOuted(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void DataExchangeTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                XY_TableCommunication.CycleExcangeData();
                DataExchangeTimer.Enabled = false;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            XY_TableCommunication.BreakTcpServer();
        }

        private void ShowCurrentValueFormButton_Click(object sender, EventArgs e)
        {
            XY_TableCurrentPositionForm = new XY_TableCurrentPositionForm(XY_TableCommunication);
            XY_TableCurrentPositionForm.Show();
        }       //顯示XY Table現在數值的Form

        private void ConnectServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XY_TableCommunication == null)
            {
                SetXY_TableCommunication();
            }
            else
                try
                {
                    XY_TableCommunication.ConnectTcpServer();
                }
                catch (Exception Error)
                {
                    MessageBox.Show(Error.Message);
                }
        }   //Form上列按鈕『連線』

        private void BreakServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (XY_TableCommunication != null)
            {
                XY_TableCommunication.BreakTcpServer();
                XY_TableCommunication = null;
                if (XY_TableCurrentPositionForm != null)
                    XY_TableCurrentPositionForm.Dispose();
            }
        }     //Form上列按鈕『離線』

        private void SetXY_TableCommunication()
        {
            XY_TableCommunication = new XY_TableCommunicationClass(path, id, password);
            XY_TableCommunication.Changed += new EventHandler(ControllerValueChanged);
            XY_TableCommunication.SocketConnected += new EventHandler(SocketConnected);
            XY_TableCommunication.SocketLinkTimeOuted += new EventHandler(SocketLinkTimeOuted);
            //XY_TableCommunication.Changed += ControllerValueChanged;

            try
            {
                XY_TableCommunication.ConnectTcpServer();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }                                         //實例化化XY_TableCommunication類別，且註冊Event。

        #region File存取,寫入,FTP至控制器

        private void FileOpenpictureBox_Click(object sender, EventArgs e)
        {
            XY_TableData.Clear();
            OpenFileDialog OpenDialog = new OpenFileDialog();
            string lineStrings = "";

            OpenDialog.Title = "Select file";
            OpenDialog.InitialDirectory = @"C:\Users\HennChou\Documents\Visual Studio 2012\Projects\XY_TableControlSystem\XY_TablePointsFolder";
            OpenDialog.Filter = "csv files (*.*)|*.csv|txt file(*.*)|*.txt";
            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader FileReader = new StreamReader(OpenDialog.FileName);
                FtpReadFileName = OpenDialog.FileName;
                while (FileReader.Peek() > -1)
                {
                    lineStrings = FileReader.ReadLine();
                    string[] lineString = lineStrings.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                    XY_TableData.Add(lineString[0], lineString[1]);
                }
                FileReader.Close();
                UpdateScreen();
            }
        }

        private void FileSavePictureBox_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDialog = new SaveFileDialog();
            string lineStrings = "";

            SaveDialog.Title = "Save file";
            SaveDialog.InitialDirectory = @"C:\Users\HennChou\Documents\Visual Studio 2012\Projects\XY_TableControlSystem\XY_TablePointsFolder";
            SaveDialog.Filter = "csv files (*.*)|*.csv|txt file(*.*)|*.txt";
            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter FileWriter = new StreamWriter(SaveDialog.FileName);
                FtpReadFileName = SaveDialog.FileName;
                for (int i = 0; i <= XY_TableData.Count - 2; i++)
                {
                    lineStrings = XY_TableData[i].Cells[0].Value.ToString()
                                         + "," + XY_TableData[i].Cells[1].Value.ToString();

                    FileWriter.WriteLine(lineStrings);
                }
                FileWriter.Close();
            }
        }

        private void FileDownloadPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                XY_TableCommunication.FtpFileUpload(FtpReadFileName);
                MessageBox.Show("檔案傳輸完成", "完成");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        #endregion File存取,寫入,FTP至控制器

        #region PC-> Controller 控制項

        private void X_AxisLeftButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (XY_TableCommunication != null)
            {
                XY_TableCommunication.ControllerWriteFlags[5] = 1;
                XY_TableCommunication.ControllerWriteWords[1] = (double)X_AxisVelocityNumericUpDown.Value;
            }
        }

        private void X_AxisLeftButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (XY_TableCommunication != null)
                XY_TableCommunication.ControllerWriteFlags[5] = 0;
        }

        private void X_AxisLeftButton_MouseLeave(object sender, EventArgs e)
        {
            if (XY_TableCommunication != null)
                XY_TableCommunication.ControllerWriteFlags[5] = 0;
        }

        private void X_AxisRightButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (XY_TableCommunication != null)
            {
                XY_TableCommunication.ControllerWriteFlags[4] = 1;
                XY_TableCommunication.ControllerWriteWords[1] = (double)X_AxisVelocityNumericUpDown.Value;
            }
        }

        private void X_AxisRightButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (XY_TableCommunication != null)
                XY_TableCommunication.ControllerWriteFlags[4] = 0;
        }

        private void X_AxisRightButton_MouseLeave(object sender, EventArgs e)
        {
            if (XY_TableCommunication != null)
                XY_TableCommunication.ControllerWriteFlags[4] = 0;
        }

        private void Y_AxisUpButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (XY_TableCommunication != null)
            {
                XY_TableCommunication.ControllerWriteFlags[6] = 1;
                XY_TableCommunication.ControllerWriteWords[3] = (double)Y_AxisVelocityNumericUpDown.Value;
            }
        }

        private void Y_AxisUpButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (XY_TableCommunication != null)
                XY_TableCommunication.ControllerWriteFlags[6] = 0;
        }

        private void Y_AxisUpButton_MouseLeave(object sender, EventArgs e)
        {
            if (XY_TableCommunication != null)
                XY_TableCommunication.ControllerWriteFlags[6] = 0;
        }

        private void Y_AxisDownButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (XY_TableCommunication != null)
            {
                XY_TableCommunication.ControllerWriteFlags[7] = 1;
                XY_TableCommunication.ControllerWriteWords[3] = (double)Y_AxisVelocityNumericUpDown.Value;
            }
        }

        private void Y_AxisDownButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (XY_TableCommunication != null)
                XY_TableCommunication.ControllerWriteFlags[7] = 0;
        }

        private void Y_AxisDownButton_MouseLeave(object sender, EventArgs e)
        {
            if (XY_TableCommunication != null)
                XY_TableCommunication.ControllerWriteFlags[7] = 0;
        }

        //Click類
        private void HomeSearchButton_Click(object sender, EventArgs e)
        {
            if (XY_TableCommunication != null)
            {
                XY_TableCommunication.ControllerWriteFlags[0] = 1;
                ButtonOnePulseTimer.Enabled = true;
            }
        }

        private void AutoRunButton_Click(object sender, EventArgs e)
        {
            if (XY_TableCommunication != null)
            {
                XY_TableCommunication.ControllerWriteFlags[1] = 1;
                XY_TableCommunication.ControllerWriteWords[4] = (double)AutoRunVelocityNumericUpDown.Value;
                ButtonOnePulseTimer.Enabled = true;
            }
        }

        private void McStopButton_Click(object sender, EventArgs e)
        {
            if (XY_TableCommunication != null)
            {
                XY_TableCommunication.ControllerWriteFlags[2] = 1;
                ButtonOnePulseTimer.Enabled = true;
            }
        }

        private void PointReadButton_Click(object sender, EventArgs e)
        {
            if (XY_TableCommunication != null)
            {
                XY_TableCommunication.ControllerWriteFlags[3] = 1;
                ButtonOnePulseTimer.Enabled = true;
            }
        }

        private void X_AxisPTPButton_Click(object sender, EventArgs e)
        {
            if (XY_TableCommunication != null)
            {
                XY_TableCommunication.ControllerWriteFlags[8] = 1;
                XY_TableCommunication.ControllerWriteWords[0] = (double)X_AxisPositionNumericUpDown.Value;
                XY_TableCommunication.ControllerWriteWords[1] = (double)X_AxisVelocityNumericUpDown.Value;
                ButtonOnePulseTimer.Enabled = true;
            }
        }

        private void Y_AxisPTPButton_Click(object sender, EventArgs e)
        {
            if (XY_TableCommunication != null)
            {
                XY_TableCommunication.ControllerWriteFlags[9] = 1;
                XY_TableCommunication.ControllerWriteWords[2] = (double)Y_AxisPositionNumericUpDown.Value;
                XY_TableCommunication.ControllerWriteWords[3] = (double)Y_AxisVelocityNumericUpDown.Value;
                ButtonOnePulseTimer.Enabled = true;
            }
        }

        private void ErrorResetButton_Click(object sender, EventArgs e)
        {
            if (XY_TableCommunication != null)
            {
                XY_TableCommunication.ControllerWriteFlags[10] = 1;
                ButtonOnePulseTimer.Enabled = true;
            }
        }

        private void ButtonOnePulseTimer_Tick(object sender, EventArgs e)
        {
            ButtonOnePulseTimer.Enabled = false;
            for (int i = 0; i < 4; i++)
            {
                XY_TableCommunication.ControllerWriteFlags[i] = 0;
                if (i <= 2)
                    XY_TableCommunication.ControllerWriteFlags[i + 8] = 0;
            }
        }

        #endregion PC-> Controller 控制項
    }
}