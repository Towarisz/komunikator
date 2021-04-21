
namespace ClientApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortNumber = new System.Windows.Forms.NumericUpDown();
            this.ClientListBox = new System.Windows.Forms.ListBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Nick = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.easterbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.usersList = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.darkmode = new System.Windows.Forms.Button();
            this.lightmode = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PortNumber)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddressLabel.ForeColor = System.Drawing.Color.White;
            this.AddressLabel.Location = new System.Drawing.Point(9, 93);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(102, 29);
            this.AddressLabel.TabIndex = 0;
            this.AddressLabel.Text = "Address";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.BackColor = System.Drawing.Color.White;
            this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F);
            this.AddressTextBox.Location = new System.Drawing.Point(10, 125);
            this.AddressTextBox.MaxLength = 15;
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(133, 30);
            this.AddressTextBox.TabIndex = 1;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PortLabel.ForeColor = System.Drawing.Color.White;
            this.PortLabel.Location = new System.Drawing.Point(9, 168);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(57, 29);
            this.PortLabel.TabIndex = 2;
            this.PortLabel.Text = "Port";
            // 
            // PortNumber
            // 
            this.PortNumber.BackColor = System.Drawing.Color.White;
            this.PortNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PortNumber.Location = new System.Drawing.Point(10, 200);
            this.PortNumber.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(133, 31);
            this.PortNumber.TabIndex = 3;
            // 
            // ClientListBox
            // 
            this.ClientListBox.BackColor = System.Drawing.Color.White;
            this.ClientListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClientListBox.FormattingEnabled = true;
            this.ClientListBox.HorizontalScrollbar = true;
            this.ClientListBox.ItemHeight = 24;
            this.ClientListBox.Location = new System.Drawing.Point(16, 53);
            this.ClientListBox.Name = "ClientListBox";
            this.ClientListBox.Size = new System.Drawing.Size(436, 340);
            this.ClientListBox.TabIndex = 4;
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.DarkGray;
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConnectButton.Location = new System.Drawing.Point(10, 452);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(133, 38);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.BackColor = System.Drawing.Color.White;
            this.MessageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.MessageTextBox.Location = new System.Drawing.Point(16, 447);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(325, 96);
            this.MessageTextBox.TabIndex = 6;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.DarkGray;
            this.SendButton.Enabled = false;
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendButton.Location = new System.Drawing.Point(365, 507);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(87, 36);
            this.SendButton.TabIndex = 7;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Nick
            // 
            this.Nick.BackColor = System.Drawing.Color.White;
            this.Nick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nick.Location = new System.Drawing.Point(10, 52);
            this.Nick.MaxLength = 16;
            this.Nick.Name = "Nick";
            this.Nick.Size = new System.Drawing.Size(133, 31);
            this.Nick.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nick";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.easterbutton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(664, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 570);
            this.panel1.TabIndex = 10;
            // 
            // easterbutton
            // 
            this.easterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easterbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.easterbutton.Location = new System.Drawing.Point(252, 557);
            this.easterbutton.Name = "easterbutton";
            this.easterbutton.Size = new System.Drawing.Size(12, 11);
            this.easterbutton.TabIndex = 2;
            this.easterbutton.Text = ".";
            this.easterbutton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Users connected";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.usersList);
            this.panel2.Location = new System.Drawing.Point(16, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 504);
            this.panel2.TabIndex = 0;
            // 
            // usersList
            // 
            this.usersList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.usersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usersList.ForeColor = System.Drawing.Color.ForestGreen;
            this.usersList.FormattingEnabled = true;
            this.usersList.ItemHeight = 29;
            this.usersList.Location = new System.Drawing.Point(3, 0);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(226, 493);
            this.usersList.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(0, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 568);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel3.Controls.Add(this.darkmode);
            this.panel3.Controls.Add(this.lightmode);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Nick);
            this.panel3.Controls.Add(this.ConnectButton);
            this.panel3.Controls.Add(this.PortNumber);
            this.panel3.Controls.Add(this.PortLabel);
            this.panel3.Controls.Add(this.AddressTextBox);
            this.panel3.Controls.Add(this.AddressLabel);
            this.panel3.Location = new System.Drawing.Point(19, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 503);
            this.panel3.TabIndex = 10;
            // 
            // darkmode
            // 
            this.darkmode.BackColor = System.Drawing.Color.Transparent;
            this.darkmode.BackgroundImage = global::ClientApp.Properties.Resources.dark;
            this.darkmode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.darkmode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.darkmode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkmode.ForeColor = System.Drawing.Color.DimGray;
            this.darkmode.Location = new System.Drawing.Point(93, 259);
            this.darkmode.Margin = new System.Windows.Forms.Padding(0);
            this.darkmode.Name = "darkmode";
            this.darkmode.Size = new System.Drawing.Size(50, 50);
            this.darkmode.TabIndex = 12;
            this.darkmode.UseVisualStyleBackColor = false;
            this.darkmode.Click += new System.EventHandler(this.darkmode_Click);
            // 
            // lightmode
            // 
            this.lightmode.BackColor = System.Drawing.Color.Transparent;
            this.lightmode.BackgroundImage = global::ClientApp.Properties.Resources.light;
            this.lightmode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lightmode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lightmode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightmode.ForeColor = System.Drawing.Color.DimGray;
            this.lightmode.Location = new System.Drawing.Point(10, 259);
            this.lightmode.Margin = new System.Windows.Forms.Padding(0);
            this.lightmode.Name = "lightmode";
            this.lightmode.Size = new System.Drawing.Size(50, 50);
            this.lightmode.TabIndex = 11;
            this.lightmode.UseVisualStyleBackColor = false;
            this.lightmode.Click += new System.EventHandler(this.lightmode_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SendButton);
            this.panel5.Controls.Add(this.MessageTextBox);
            this.panel5.Controls.Add(this.ClientListBox);
            this.panel5.Location = new System.Drawing.Point(194, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(470, 572);
            this.panel5.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(929, 569);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Dipskort";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PortNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.NumericUpDown PortNumber;
        private System.Windows.Forms.ListBox ClientListBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox Nick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox usersList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button darkmode;
        private System.Windows.Forms.Button lightmode;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button easterbutton;
    }
}

