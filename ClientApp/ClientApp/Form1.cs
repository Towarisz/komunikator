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
using System.Text.RegularExpressions;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        private TcpClient client = null;
        private BinaryReader reading = null;
        private BinaryWriter writing = null;

        public string end = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";

        //public Regex rx = new Regex(@"(^\d)|(^server)|(\s)", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            Match match = Regex.Match(Nick.Text, @"(^\d)|(^Server)|(\s)");
            if (match.Success)
            {
                InvokeAs(ClientListBox, () => ClientListBox.Items.Add("Nick contain forbidden characters"));
            }
            else
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
                    SendButton.Enabled = true;
                }
                catch
                {

                }
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
            string[] messagesplit;
            while (true)
            {
                messageReceived = reading.ReadString();
                Match match = Regex.Match(messageReceived, @"^(Serverlist:)");
                if (match.Success)
                {
                    InvokeAs(usersList, () => usersList.Items.Clear());
                    messagesplit = messageReceived.Substring(12).Split(' ');
                    foreach(string x in messagesplit){
                        InvokeAs(usersList, () => usersList.Items.Add(x));
                    }
                }
                else
                {
                    InvokeAs(ClientListBox, () => ClientListBox.Items.Add(messageReceived));
                }
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

        private void lightmode_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
            panel2.BackColor = Color.LightGray;
            usersList.BackColor = Color.LightGray;
            panel3.BackColor = Color.LightGray;
            panel5.BackColor = Color.LightGray;
            panel4.BackColor = Color.White;
            easterbutton.BackColor = Color.White;
            easterbutton.ForeColor = Color.White;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            AddressLabel.ForeColor = Color.Black;
            PortLabel.ForeColor = Color.Black;

        }

        private void darkmode_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(25, 25, 25);
            panel2.BackColor = Color.FromArgb(48, 48, 48);
            usersList.BackColor = Color.FromArgb(48, 48, 48);
            panel3.BackColor = Color.FromArgb(48, 48, 48);
            panel5.BackColor = Color.FromArgb(48, 48, 48);
            panel4.BackColor = Color.FromArgb(25, 25, 25);
            easterbutton.BackColor = Color.FromArgb(25, 25, 25);
            easterbutton.ForeColor = Color.FromArgb(25, 25, 25);
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            AddressLabel.ForeColor = Color.White;
            PortLabel.ForeColor = Color.White;
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
