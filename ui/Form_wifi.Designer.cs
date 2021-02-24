
namespace QR.ui
{
    partial class Form_wifi
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
            this.pn_pass = new System.Windows.Forms.Panel();
            this.pn_ssid = new System.Windows.Forms.Panel();
            this.tb_ssid = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pn_pass
            // 
            this.pn_pass.BackColor = System.Drawing.Color.White;
            this.pn_pass.Location = new System.Drawing.Point(36, 135);
            this.pn_pass.Name = "pn_pass";
            this.pn_pass.Size = new System.Drawing.Size(200, 2);
            this.pn_pass.TabIndex = 0;
            // 
            // pn_ssid
            // 
            this.pn_ssid.BackColor = System.Drawing.Color.White;
            this.pn_ssid.Location = new System.Drawing.Point(36, 91);
            this.pn_ssid.Name = "pn_ssid";
            this.pn_ssid.Size = new System.Drawing.Size(200, 2);
            this.pn_ssid.TabIndex = 0;
            // 
            // tb_ssid
            // 
            this.tb_ssid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tb_ssid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ssid.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ssid.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tb_ssid.Location = new System.Drawing.Point(36, 69);
            this.tb_ssid.Name = "tb_ssid";
            this.tb_ssid.Size = new System.Drawing.Size(200, 20);
            this.tb_ssid.TabIndex = 1;
            this.tb_ssid.Text = "Nome da Rede";
            this.tb_ssid.Click += new System.EventHandler(this.tb_ssid_Click);
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tb_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pass.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pass.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.tb_pass.Location = new System.Drawing.Point(36, 113);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(200, 20);
            this.tb_pass.TabIndex = 1;
            this.tb_pass.Text = "Password";
            this.tb_pass.Click += new System.EventHandler(this.tb_pass_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.checkBox1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.checkBox1.Location = new System.Drawing.Point(154, 142);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(88, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_wifi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(270, 222);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_ssid);
            this.Controls.Add(this.pn_ssid);
            this.Controls.Add(this.pn_pass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_wifi";
            this.Text = "Form_wifi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_pass;
        private System.Windows.Forms.Panel pn_ssid;
        private System.Windows.Forms.TextBox tb_ssid;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}