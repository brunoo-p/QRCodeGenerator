
namespace QR.ui
{
    partial class Form_wpp
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
            this.pn_number = new System.Windows.Forms.Panel();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.btn_wpp = new System.Windows.Forms.Button();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_number
            // 
            this.pn_number.BackColor = System.Drawing.Color.White;
            this.pn_number.Location = new System.Drawing.Point(42, 83);
            this.pn_number.Name = "pn_number";
            this.pn_number.Size = new System.Drawing.Size(180, 2);
            this.pn_number.TabIndex = 0;
            // 
            // tb_message
            // 
            this.tb_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.tb_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_message.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tb_message.Location = new System.Drawing.Point(12, 113);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.Size = new System.Drawing.Size(246, 58);
            this.tb_message.TabIndex = 1;
            this.tb_message.Click += new System.EventHandler(this.tb_message_Click);
            // 
            // btn_wpp
            // 
            this.btn_wpp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_wpp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wpp.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wpp.ForeColor = System.Drawing.Color.White;
            this.btn_wpp.Location = new System.Drawing.Point(92, 185);
            this.btn_wpp.Name = "btn_wpp";
            this.btn_wpp.Size = new System.Drawing.Size(75, 26);
            this.btn_wpp.TabIndex = 2;
            this.btn_wpp.Text = "OK";
            this.btn_wpp.UseVisualStyleBackColor = true;
            this.btn_wpp.Click += new System.EventHandler(this.btn_wpp_Click);
            // 
            // tb_number
            // 
            this.tb_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tb_number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_number.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_number.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tb_number.Location = new System.Drawing.Point(42, 60);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(180, 22);
            this.tb_number.TabIndex = 3;
            this.tb_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_number.Click += new System.EventHandler(this.tb_number_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QR.Properties.Resources.wpp1;
            this.pictureBox1.Location = new System.Drawing.Point(101, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phone";
            // 
            // Form_wpp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(270, 222);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_number);
            this.Controls.Add(this.btn_wpp);
            this.Controls.Add(this.tb_message);
            this.Controls.Add(this.pn_number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_wpp";
            this.Text = "Form_wpp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_number;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Button btn_wpp;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}