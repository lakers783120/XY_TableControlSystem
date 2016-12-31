using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int a;
        private int b;
        private int c;
        private Thread MyThread;

        public Form1()
        {
            InitializeComponent();
            a = 3;
            b = 4;
            MyThread = new Thread(ThreadRun);
            MyThread.Start();
        }

        public void ThreadRun()
        {
            int n = 0;
            while (n < 100)
            {
                c = a + b;
                Invoke((MethodInvoker)(() =>
                {
                    textBox1.Text = string.Format((c + n).ToString());
                }));
                // textBox1.Text = string.Format((c + n).ToString());

                Thread.Sleep(1000);
                n += 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = 4;
            b = 4;
            textBox1.Text = string.Format((a + b).ToString());
        }
    }
}