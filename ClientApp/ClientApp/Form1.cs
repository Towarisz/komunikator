using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        private TcpClient client = null;
        private BinaryReader reading = null;
        private BinaryWriter writing = null;
        public string end = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                //client = new TcpClient(AddressTextBox.Text, (int)PortNumber.Value);
                client = new TcpClient("127.0.0.1", 1001);
                NetworkStream ns = client.GetStream();
                reading = new BinaryReader(ns);
                writing = new BinaryWriter(ns);
                writing.Write(Nick.Text);
                writing.Flush();
                backgroundWorker2.RunWorkerAsync();
                ConnectButton.Enabled = false;
            }
            catch
            {
                
            }
  
        }

        private void SendButton_Click(object sender, EventArgs e)
        { 
            string messageSent = MessageTextBox.Text;
            writing.Write(messageSent);
            writing.Flush();
            MessageTextBox.Text = "";
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            string messageReceived;
            while (true)
            {
                messageReceived = reading.ReadString();
                InvokeAs(ClientListBox, ()=>ClientListBox.Items.Add(messageReceived));
            }
        }

        private void InvokeInWindow(Action d)
        {
            InvokeAs(this, d);
        }

        private void InvokeAs(Control c, Action d)
        {
            c.Invoke(d);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                writing.Write(end);
                backgroundWorker2.CancelAsync();
                client.Close();
            }
            catch { }
        }
    }
}
