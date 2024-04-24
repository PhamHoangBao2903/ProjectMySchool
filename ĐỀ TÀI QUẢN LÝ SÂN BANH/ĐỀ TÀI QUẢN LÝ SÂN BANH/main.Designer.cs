namespace ĐỀ_TÀI_QUẢN_LÝ_SÂN_BANH
{
    partial class main
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
            this.panel_menu = new System.Windows.Forms.Panel();
            this.button_formKH = new System.Windows.Forms.Button();
            this.button_formDV = new System.Windows.Forms.Button();
            this.button_formSANBANH = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.SeaGreen;
            this.panel_menu.Controls.Add(this.button_formKH);
            this.panel_menu.Controls.Add(this.button_formDV);
            this.panel_menu.Controls.Add(this.button_formSANBANH);
            this.panel_menu.Controls.Add(this.pictureBox1);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.ForeColor = System.Drawing.Color.Transparent;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(197, 648);
            this.panel_menu.TabIndex = 0;
            // 
            // button_formKH
            // 
            this.button_formKH.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_formKH.ForeColor = System.Drawing.Color.Tomato;
            this.button_formKH.Location = new System.Drawing.Point(0, 271);
            this.button_formKH.Name = "button_formKH";
            this.button_formKH.Size = new System.Drawing.Size(191, 56);
            this.button_formKH.TabIndex = 4;
            this.button_formKH.Text = "KHÁCH HÀNG";
            this.button_formKH.UseVisualStyleBackColor = false;
            this.button_formKH.Click += new System.EventHandler(this.button_formKH_Click);
            // 
            // button_formDV
            // 
            this.button_formDV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_formDV.ForeColor = System.Drawing.Color.Tomato;
            this.button_formDV.Location = new System.Drawing.Point(0, 208);
            this.button_formDV.Name = "button_formDV";
            this.button_formDV.Size = new System.Drawing.Size(191, 57);
            this.button_formDV.TabIndex = 3;
            this.button_formDV.Text = "DICH VU";
            this.button_formDV.UseVisualStyleBackColor = false;
            this.button_formDV.Click += new System.EventHandler(this.button_formDV_Click);
            // 
            // button_formSANBANH
            // 
            this.button_formSANBANH.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_formSANBANH.ForeColor = System.Drawing.Color.Tomato;
            this.button_formSANBANH.Location = new System.Drawing.Point(0, 146);
            this.button_formSANBANH.Name = "button_formSANBANH";
            this.button_formSANBANH.Size = new System.Drawing.Size(191, 56);
            this.button_formSANBANH.TabIndex = 2;
            this.button_formSANBANH.Text = "QUẢN LÝ SÂN";
            this.button_formSANBANH.UseVisualStyleBackColor = false;
            this.button_formSANBANH.Click += new System.EventHandler(this.button_formSANBANH_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ĐỀ_TÀI_QUẢN_LÝ_SÂN_BANH.Properties.Resources._7035936;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.label2);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(197, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(855, 140);
            this.panel_top.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 97);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(775, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "FOOTBALL STADIUM MANAGER PROGRAM\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel_body
            // 
            this.panel_body.AllowDrop = true;
            this.panel_body.AutoSize = true;
            this.panel_body.BackgroundImage = global::ĐỀ_TÀI_QUẢN_LÝ_SÂN_BANH.Properties.Resources.stadium_cs;
            this.panel_body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(197, 140);
            this.panel_body.Name = "panel_body";
            this.panel_body.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel_body.Size = new System.Drawing.Size(855, 508);
            this.panel_body.TabIndex = 2;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1052, 648);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_menu);
            this.Name = "main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SÂN BANH";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button button_formKH;
        private System.Windows.Forms.Button button_formDV;
        private System.Windows.Forms.Button button_formSANBANH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Label label2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

