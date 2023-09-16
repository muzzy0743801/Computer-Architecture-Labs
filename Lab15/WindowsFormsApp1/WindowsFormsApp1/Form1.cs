using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SerialPort port;

        public Form1()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Form1_FormClosed);

            if (port == null)
            {
                //Change the portname according to your computer
                port = new SerialPort("COM3", 9600);
                port.Open();
            }
        }

        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (port != null && port.IsOpen)
            {
                port.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PortWrite("1");

        }


        private void button2_Click(object sender, EventArgs e)
        {

            PortWrite("0");

        }

        private void PortWrite(string message)
        {
            if (port != null && port.IsOpen)
            {
                port.Write(message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}