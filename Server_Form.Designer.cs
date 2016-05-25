namespace Server
{
    partial class Server_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server_form));
            this.button1 = new System.Windows.Forms.Button();
            this.listViewServer = new System.Windows.Forms.ListView();
            this.columnHeaderNickName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox_showclients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.button_close = new System.Windows.Forms.Button();
            this.comboBox_all_onlines = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewServer
            // 
            this.listViewServer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewServer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNickName,
            this.columnHeaderMessage,
            this.Time});
            this.listViewServer.GridLines = true;
            this.listViewServer.Location = new System.Drawing.Point(23, 112);
            this.listViewServer.Name = "listViewServer";
            this.listViewServer.Size = new System.Drawing.Size(412, 321);
            this.listViewServer.TabIndex = 2;
            this.listViewServer.UseCompatibleStateImageBehavior = false;
            this.listViewServer.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNickName
            // 
            this.columnHeaderNickName.Text = "Nick Name";
            this.columnHeaderNickName.Width = 106;
            // 
            // columnHeaderMessage
            // 
            this.columnHeaderMessage.Text = "Message";
            this.columnHeaderMessage.Width = 176;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 126;
            // 
            // comboBox_showclients
            // 
            this.comboBox_showclients.AccessibleName = "";
            this.comboBox_showclients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBox_showclients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBox_showclients.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox_showclients.FormattingEnabled = true;
            this.comboBox_showclients.Location = new System.Drawing.Point(409, 12);
            this.comboBox_showclients.Name = "comboBox_showclients";
            this.comboBox_showclients.Size = new System.Drawing.Size(153, 21);
            this.comboBox_showclients.TabIndex = 3;
            this.comboBox_showclients.Text = "All members history list";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Peoples OnLine:";
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(111, 78);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(27, 20);
            this.textBox_count.TabIndex = 5;
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Transparent;
            this.button_close.ForeColor = System.Drawing.Color.Red;
            this.button_close.Location = new System.Drawing.Point(477, 410);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "CLOSE";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // comboBox_all_onlines
            // 
            this.comboBox_all_onlines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.comboBox_all_onlines.FormattingEnabled = true;
            this.comboBox_all_onlines.Location = new System.Drawing.Point(409, 39);
            this.comboBox_all_onlines.Name = "comboBox_all_onlines";
            this.comboBox_all_onlines.Size = new System.Drawing.Size(153, 21);
            this.comboBox_all_onlines.TabIndex = 7;
            this.comboBox_all_onlines.Text = "all on line members";
            // 
            // Server_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(574, 453);
            this.Controls.Add(this.comboBox_all_onlines);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_showclients);
            this.Controls.Add(this.listViewServer);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Server_form";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewServer;
        private System.Windows.Forms.ColumnHeader columnHeaderNickName;
        private System.Windows.Forms.ColumnHeader columnHeaderMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.Button button_close;
        public System.Windows.Forms.ComboBox comboBox_showclients;
        private System.Windows.Forms.ComboBox comboBox_all_onlines;
        private System.Windows.Forms.ColumnHeader Time;
    }
}

