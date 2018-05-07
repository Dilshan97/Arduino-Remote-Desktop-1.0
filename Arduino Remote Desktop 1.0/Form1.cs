using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arduino_Remote_Desktop_1._0.Properties;

namespace Arduino_Remote_Desktop_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] coms = System.IO.Ports.SerialPort.GetPortNames();
            comboBox1.Items.AddRange(coms);
        }

        private void selectPort_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
            serialPort1.Open();
            progressBar1.Value = 100;
            selectPort.Enabled = false;        
        }

    
    private void SwitchOn1_Click(object sender, EventArgs e)
        {
            if(!serialPort1.IsOpen) {
                serialPort1.Open();
            }
            serialPort1.Write("1");
            serialPort1.Close();
            SwitchOn1.Enabled = false;
        }

        private void SwitchOFF1_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            serialPort1.Write("2");
            serialPort1.Close();
            SwitchOFF1.Enabled = false;
        }

        private void SwitchOn2_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            serialPort1.Write("3");
            serialPort1.Close();
        }

        private void SwitchOff2_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            serialPort1.Write("4");
            serialPort1.Close();
        }

        private void SwitchOn3_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            serialPort1.Write("5");
            serialPort1.Close();
        }

        private void SwitchOff3_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            serialPort1.Write("6");
            serialPort1.Close();
        }

        private void SwitchOn4_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            serialPort1.Write("7");
            serialPort1.Close();
        }

        private void SwitchOff4_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            serialPort1.Write("8");
            serialPort1.Close();
        }

        private void SwitchOn5_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            serialPort1.Write("9");
            serialPort1.Close();
        }

        private void SwitchOff5_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            serialPort1.Write("0");
            serialPort1.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("සුබ දවසක් යාලුවනේ......අද කියන්න යන්නේ LCD Display එකක් තියෙන අයට කරන්න පුලුවන් පොඩි Project 1.");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed By Dilshan Ramesh");
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://technologhy01.blogspot.com");
        }

        
    }
}

