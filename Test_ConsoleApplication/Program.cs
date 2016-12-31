using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XY_TableCommunicationLibrary;

namespace Test_ConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = "192.168.250.1";
            string id = "Test001";
            string password = "12345678";

            XY_TableCommunicationClass Test_001 = new XY_TableCommunicationClass(path, id, password);

            try
            {
                //Test_001.FtpFileUpload("C:/Users/HennChou/Documents/111.txt");
                //Console.WriteLine("傳輸完成");

                Test_001.ConnectTcpServer();
                Test_001.CycleExcangeData();
                //Console.WriteLine("{0}\n{1}\n{2}\n{3}\n", Test_001.ControllerReadFlags[0], Test_001.ControllerReadFlags[1], Test_001.ControllerReadFlags[2], Test_001.ControllerReadFlags[3]);
                //Console.WriteLine("{0}\n{1}\n{2}\n{3}\n", Test_001.ControllerReadWords[0], Test_001.ControllerReadWords[1], Test_001.ControllerReadWords[2], Test_001.ControllerReadWords[3]);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}