using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XY_TableCommunicationLibrary;

namespace HMI_WindowsForms
{
    public partial class XY_TableCurrentPositionForm : Form
    {
        public XY_TableCommunicationClass XY_TableCommunication;
        private int X_AxisInitialLocation;
        private int Y_AxisInitialLocation;

        public XY_TableCurrentPositionForm()
        {
            InitializeComponent();
        }

        public XY_TableCurrentPositionForm(XY_TableCommunicationClass form1Data)
        {
            XY_TableCommunication = form1Data;

            InitializeComponent();
            XY_TableCurrentValueTimer.Interval = 200;
            XY_TableCurrentValueTimer.Enabled = true;

            X_AxisInitialLocation = XY_TableShape.Location.X;
            Y_AxisInitialLocation = XY_TableShape.Location.Y;
        }

        private void XY_TableCurrentValueTimer_Tick(object sender, EventArgs e)
        {
            XY_TableShape.Location = new Point((X_AxisInitialLocation + (int)XY_TableCommunication.ControllerReadWords[0])
                                             , (Y_AxisInitialLocation - (int)XY_TableCommunication.ControllerReadWords[2]));
        }
    }
}