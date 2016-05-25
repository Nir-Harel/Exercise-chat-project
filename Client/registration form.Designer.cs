namespace StartWindow
{
    partial class registration_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nikname = new System.Windows.Forms.TextBox();
            this.SAVE = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please choose a nikname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please coose a color:";
            // 
            // nikname
            // 
            this.nikname.Location = new System.Drawing.Point(170, 24);
            this.nikname.Name = "nikname";
            this.nikname.Size = new System.Drawing.Size(100, 20);
            this.nikname.TabIndex = 3;
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SAVE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SAVE.Location = new System.Drawing.Point(181, 148);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(75, 23);
            this.SAVE.TabIndex = 5;
            this.SAVE.Text = "SAVE  ";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonColor.Location = new System.Drawing.Point(170, 58);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(100, 23);
            this.buttonColor.TabIndex = 6;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Please choose a font:";
            // 
            // buttonFont
            // 
            this.buttonFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFont.Location = new System.Drawing.Point(170, 95);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(100, 23);
            this.buttonFont.TabIndex = 9;
            this.buttonFont.Text = "Font";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(430, 257);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.nikname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "registration_form";
            this.Text = "registration_form";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SAVE;
        public System.Windows.Forms.TextBox nikname;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}