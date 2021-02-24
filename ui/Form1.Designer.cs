
namespace QR
{
    partial class QR
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_scann = new System.Windows.Forms.Panel();
            this.pn_create = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_optionsCreate = new System.Windows.Forms.Panel();
            this.btn_skype = new System.Windows.Forms.Button();
            this.btn_wpp = new System.Windows.Forms.Button();
            this.btn_wifi = new System.Windows.Forms.Button();
            this.btn_link = new System.Windows.Forms.Button();
            this.btn_onlyText = new System.Windows.Forms.Button();
            this.btn_createQR = new System.Windows.Forms.Button();
            this.btn_scannQR = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb_direct = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_preview = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_description = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pn_optionsCreate.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_preview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(209)))));
            this.panel1.Controls.Add(this.pn_scann);
            this.panel1.Controls.Add(this.pn_create);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pn_optionsCreate);
            this.panel1.Controls.Add(this.btn_createQR);
            this.panel1.Controls.Add(this.btn_scannQR);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 431);
            this.panel1.TabIndex = 0;
            // 
            // pn_scann
            // 
            this.pn_scann.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.pn_scann.Location = new System.Drawing.Point(0, 71);
            this.pn_scann.Name = "pn_scann";
            this.pn_scann.Size = new System.Drawing.Size(5, 34);
            this.pn_scann.TabIndex = 7;
            this.pn_scann.Visible = false;
            // 
            // pn_create
            // 
            this.pn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.pn_create.Location = new System.Drawing.Point(0, 105);
            this.pn_create.Name = "pn_create";
            this.pn_create.Size = new System.Drawing.Size(5, 34);
            this.pn_create.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(12, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Copyright© Bruno Paulino";
            // 
            // pn_optionsCreate
            // 
            this.pn_optionsCreate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pn_optionsCreate.Controls.Add(this.btn_skype);
            this.pn_optionsCreate.Controls.Add(this.btn_wpp);
            this.pn_optionsCreate.Controls.Add(this.btn_wifi);
            this.pn_optionsCreate.Controls.Add(this.btn_link);
            this.pn_optionsCreate.Controls.Add(this.btn_onlyText);
            this.pn_optionsCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_optionsCreate.Location = new System.Drawing.Point(0, 139);
            this.pn_optionsCreate.Name = "pn_optionsCreate";
            this.pn_optionsCreate.Size = new System.Drawing.Size(163, 175);
            this.pn_optionsCreate.TabIndex = 3;
            // 
            // btn_skype
            // 
            this.btn_skype.BackColor = System.Drawing.Color.SlateGray;
            this.btn_skype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_skype.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_skype.FlatAppearance.BorderSize = 0;
            this.btn_skype.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_skype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_skype.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_skype.Location = new System.Drawing.Point(0, 136);
            this.btn_skype.Name = "btn_skype";
            this.btn_skype.Size = new System.Drawing.Size(163, 34);
            this.btn_skype.TabIndex = 4;
            this.btn_skype.Text = "Call Skype";
            this.btn_skype.UseVisualStyleBackColor = false;
            this.btn_skype.Click += new System.EventHandler(this.btn_skype_Click);
            // 
            // btn_wpp
            // 
            this.btn_wpp.BackColor = System.Drawing.Color.SlateGray;
            this.btn_wpp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wpp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_wpp.FlatAppearance.BorderSize = 0;
            this.btn_wpp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_wpp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wpp.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wpp.Location = new System.Drawing.Point(0, 102);
            this.btn_wpp.Name = "btn_wpp";
            this.btn_wpp.Size = new System.Drawing.Size(163, 34);
            this.btn_wpp.TabIndex = 3;
            this.btn_wpp.Text = "WhatsApp Message";
            this.btn_wpp.UseVisualStyleBackColor = false;
            this.btn_wpp.Click += new System.EventHandler(this.btn_wpp_Click);
            // 
            // btn_wifi
            // 
            this.btn_wifi.BackColor = System.Drawing.Color.SlateGray;
            this.btn_wifi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wifi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_wifi.FlatAppearance.BorderSize = 0;
            this.btn_wifi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_wifi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wifi.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wifi.Location = new System.Drawing.Point(0, 68);
            this.btn_wifi.Name = "btn_wifi";
            this.btn_wifi.Size = new System.Drawing.Size(163, 34);
            this.btn_wifi.TabIndex = 2;
            this.btn_wifi.Text = "Wi-Fi Access";
            this.btn_wifi.UseVisualStyleBackColor = false;
            this.btn_wifi.Click += new System.EventHandler(this.btn_wifi_Click);
            // 
            // btn_link
            // 
            this.btn_link.BackColor = System.Drawing.Color.SlateGray;
            this.btn_link.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_link.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_link.FlatAppearance.BorderSize = 0;
            this.btn_link.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_link.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_link.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_link.Location = new System.Drawing.Point(0, 34);
            this.btn_link.Name = "btn_link";
            this.btn_link.Size = new System.Drawing.Size(163, 34);
            this.btn_link.TabIndex = 1;
            this.btn_link.Text = "Associate an link";
            this.btn_link.UseVisualStyleBackColor = false;
            this.btn_link.Click += new System.EventHandler(this.btn_link_Click);
            // 
            // btn_onlyText
            // 
            this.btn_onlyText.BackColor = System.Drawing.Color.SlateGray;
            this.btn_onlyText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_onlyText.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_onlyText.FlatAppearance.BorderSize = 0;
            this.btn_onlyText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_onlyText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_onlyText.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_onlyText.Location = new System.Drawing.Point(0, 0);
            this.btn_onlyText.Name = "btn_onlyText";
            this.btn_onlyText.Size = new System.Drawing.Size(163, 34);
            this.btn_onlyText.TabIndex = 0;
            this.btn_onlyText.Text = "Only Text";
            this.btn_onlyText.UseVisualStyleBackColor = false;
            this.btn_onlyText.Click += new System.EventHandler(this.btn_onlyText_Click);
            // 
            // btn_createQR
            // 
            this.btn_createQR.BackColor = System.Drawing.Color.Silver;
            this.btn_createQR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_createQR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_createQR.FlatAppearance.BorderSize = 0;
            this.btn_createQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createQR.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createQR.Location = new System.Drawing.Point(0, 105);
            this.btn_createQR.Name = "btn_createQR";
            this.btn_createQR.Size = new System.Drawing.Size(163, 34);
            this.btn_createQR.TabIndex = 2;
            this.btn_createQR.Text = "Create QRCode";
            this.btn_createQR.UseVisualStyleBackColor = false;
            // 
            // btn_scannQR
            // 
            this.btn_scannQR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_scannQR.FlatAppearance.BorderSize = 0;
            this.btn_scannQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_scannQR.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_scannQR.Location = new System.Drawing.Point(0, 71);
            this.btn_scannQR.Name = "btn_scannQR";
            this.btn_scannQR.Size = new System.Drawing.Size(163, 34);
            this.btn_scannQR.TabIndex = 1;
            this.btn_scannQR.Text = "Scann QRCode";
            this.btn_scannQR.UseVisualStyleBackColor = true;
            this.btn_scannQR.Click += new System.EventHandler(this.btn_scannQR_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 71);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Image = global::QR.Properties.Resources.github_png;
            this.pictureBox1.Location = new System.Drawing.Point(50, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pn_main
            // 
            this.pn_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.pn_main.Location = new System.Drawing.Point(181, 62);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(270, 222);
            this.pn_main.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(184, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "QRCode Generator";
            // 
            // tb_description
            // 
            this.tb_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_description.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_description.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.Location = new System.Drawing.Point(181, 321);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.Size = new System.Drawing.Size(270, 52);
            this.tb_description.TabIndex = 5;
            this.tb_description.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lb_direct);
            this.panel5.Controls.Add(this.btn_exit);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pb_preview);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(471, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(133, 431);
            this.panel5.TabIndex = 6;
            // 
            // lb_direct
            // 
            this.lb_direct.AutoSize = true;
            this.lb_direct.Font = new System.Drawing.Font("Nirmala UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_direct.ForeColor = System.Drawing.Color.LightGreen;
            this.lb_direct.Location = new System.Drawing.Point(27, 194);
            this.lb_direct.Name = "lb_direct";
            this.lb_direct.Size = new System.Drawing.Size(86, 13);
            this.lb_direct.TabIndex = 10;
            this.lb_direct.Text = "Click \'Generate\'";
            this.lb_direct.Visible = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Silver;
            this.btn_exit.Location = new System.Drawing.Point(96, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(34, 29);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "seu QRCode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label4.Location = new System.Drawing.Point(18, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Torne Único";
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Gainsboro;
            this.button6.Location = new System.Drawing.Point(31, 224);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 28);
            this.button6.TabIndex = 6;
            this.button6.Text = "Generate";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(33, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Preview";
            // 
            // pb_preview
            // 
            this.pb_preview.BackColor = System.Drawing.Color.White;
            this.pb_preview.Image = global::QR.Properties.Resources.fora_ar;
            this.pb_preview.InitialImage = null;
            this.pb_preview.Location = new System.Drawing.Point(14, 105);
            this.pb_preview.Name = "pb_preview";
            this.pb_preview.Size = new System.Drawing.Size(108, 86);
            this.pb_preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_preview.TabIndex = 0;
            this.pb_preview.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(471, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 300);
            this.panel4.TabIndex = 7;
            // 
            // lb_description
            // 
            this.lb_description.AutoSize = true;
            this.lb_description.Font = new System.Drawing.Font("Nirmala UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_description.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lb_description.Location = new System.Drawing.Point(185, 297);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(89, 20);
            this.lb_description.TabIndex = 8;
            this.lb_description.Text = "Description";
            this.lb_description.Visible = false;
            // 
            // QR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(604, 431);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pn_main);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QR";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCode";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_optionsCreate.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_wifi;
        private System.Windows.Forms.Button btn_link;
        private System.Windows.Forms.Button btn_onlyText;
        private System.Windows.Forms.Button btn_scannQR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_skype;
        private System.Windows.Forms.Button btn_wpp;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.PictureBox pb_preview;
        public System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label lb_description;
        public System.Windows.Forms.Label lb_direct;
        public System.Windows.Forms.Panel pn_create;
        public System.Windows.Forms.Panel pn_scann;
        public System.Windows.Forms.Button btn_createQR;
        public System.Windows.Forms.Panel pn_optionsCreate;
    }
}

