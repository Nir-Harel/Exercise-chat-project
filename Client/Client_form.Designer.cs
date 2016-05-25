namespace StartWindow
{
    partial class Client_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_form));
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listViewClient = new System.Windows.Forms.ListView();
            this.columnNickName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonconnectig = new System.Windows.Forms.Button();
            this.button_EXIT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_con = new System.Windows.Forms.PictureBox();
            this.pictureBox_dis = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLOSEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hIDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_con)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonDisconnect.ForeColor = System.Drawing.Color.Red;
            this.buttonDisconnect.Location = new System.Drawing.Point(134, 3);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(116, 23);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSend.Location = new System.Drawing.Point(212, 72);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(68, 23);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 3;
            // 
            // listViewClient
            // 
            this.listViewClient.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewClient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNickName,
            this.columnHeaderMessage,
            this.Time});
            this.listViewClient.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listViewClient.GridLines = true;
            this.listViewClient.Location = new System.Drawing.Point(12, 101);
            this.listViewClient.Name = "listViewClient";
            this.listViewClient.Size = new System.Drawing.Size(492, 339);
            this.listViewClient.TabIndex = 5;
            this.listViewClient.Tag = "";
            this.listViewClient.UseCompatibleStateImageBehavior = false;
            this.listViewClient.View = System.Windows.Forms.View.Details;
            // 
            // columnNickName
            // 
            this.columnNickName.Text = "Nick Name";
            this.columnNickName.Width = 117;
            // 
            // columnHeaderMessage
            // 
            this.columnHeaderMessage.Text = "Message";
            this.columnHeaderMessage.Width = 238;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 150;
            // 
            // buttonconnectig
            // 
            this.buttonconnectig.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonconnectig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonconnectig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonconnectig.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonconnectig.ForeColor = System.Drawing.Color.Green;
            this.buttonconnectig.Location = new System.Drawing.Point(12, 3);
            this.buttonconnectig.Name = "buttonconnectig";
            this.buttonconnectig.Size = new System.Drawing.Size(116, 23);
            this.buttonconnectig.TabIndex = 6;
            this.buttonconnectig.Text = "Connect";
            this.buttonconnectig.UseVisualStyleBackColor = false;
            this.buttonconnectig.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_EXIT
            // 
            this.button_EXIT.ForeColor = System.Drawing.Color.Red;
            this.button_EXIT.Location = new System.Drawing.Point(641, 417);
            this.button_EXIT.Name = "button_EXIT";
            this.button_EXIT.Size = new System.Drawing.Size(116, 23);
            this.button_EXIT.TabIndex = 7;
            this.button_EXIT.Text = "EXIT";
            this.button_EXIT.UseVisualStyleBackColor = true;
            this.button_EXIT.Click += new System.EventHandler(this.button_EXIT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // pictureBox_con
            // 
            this.pictureBox_con.Image = global::StartWindow.Properties.Resources.co;
            this.pictureBox_con.Location = new System.Drawing.Point(641, 12);
            this.pictureBox_con.Name = "pictureBox_con";
            this.pictureBox_con.Size = new System.Drawing.Size(116, 104);
            this.pictureBox_con.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_con.TabIndex = 11;
            this.pictureBox_con.TabStop = false;
            // 
            // pictureBox_dis
            // 
            this.pictureBox_dis.Image = global::StartWindow.Properties.Resources.disc;
            this.pictureBox_dis.Location = new System.Drawing.Point(641, 12);
            this.pictureBox_dis.Name = "pictureBox_dis";
            this.pictureBox_dis.Size = new System.Drawing.Size(116, 106);
            this.pictureBox_dis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_dis.TabIndex = 12;
            this.pictureBox_dis.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hIDEToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.cLOSEToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 70);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.closeToolStripMenuItem.Text = "SHOW";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // cLOSEToolStripMenuItem1
            // 
            this.cLOSEToolStripMenuItem1.BackColor = System.Drawing.Color.DodgerBlue;
            this.cLOSEToolStripMenuItem1.Name = "cLOSEToolStripMenuItem1";
            this.cLOSEToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.cLOSEToolStripMenuItem1.Text = "CLOSE";
            this.cLOSEToolStripMenuItem1.Click += new System.EventHandler(this.cLOSEToolStripMenuItem1_Click);
            // 
            // hIDEToolStripMenuItem
            // 
            this.hIDEToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.hIDEToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.hIDEToolStripMenuItem.Name = "hIDEToolStripMenuItem";
            this.hIDEToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.hIDEToolStripMenuItem.Text = "HIDE";
            this.hIDEToolStripMenuItem.Click += new System.EventHandler(this.hIDEToolStripMenuItem_Click);
            // 
            // Client_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(769, 452);
            this.Controls.Add(this.pictureBox_dis);
            this.Controls.Add(this.pictureBox_con);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_EXIT);
            this.Controls.Add(this.buttonconnectig);
            this.Controls.Add(this.listViewClient);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonDisconnect);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client_form";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_con)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ListView listViewClient;
        private System.Windows.Forms.ColumnHeader columnNickName;
        private System.Windows.Forms.ColumnHeader columnHeaderMessage;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonconnectig;
        private System.Windows.Forms.Button button_EXIT;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_con;
        private System.Windows.Forms.PictureBox pictureBox_dis;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLOSEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hIDEToolStripMenuItem;
    }
}

