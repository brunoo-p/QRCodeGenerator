
namespace QR.ui
{
    partial class Form_skype
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_skype));
            this.pn_skype = new System.Windows.Forms.Panel();
            this.tb_skype = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_skype
            // 
            this.pn_skype.BackColor = System.Drawing.Color.White;
            this.pn_skype.Location = new System.Drawing.Point(40, 124);
            this.pn_skype.Name = "pn_skype";
            this.pn_skype.Size = new System.Drawing.Size(200, 2);
            this.pn_skype.TabIndex = 0;
            // 
            // tb_skype
            // 
            this.tb_skype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tb_skype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_skype.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_skype.ForeColor = System.Drawing.Color.Gainsboro;
            this.tb_skype.Location = new System.Drawing.Point(40, 98);
            this.tb_skype.Name = "tb_skype";
            this.tb_skype.Size = new System.Drawing.Size(200, 22);
            this.tb_skype.TabIndex = 1;
            this.tb_skype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_skype.Click += new System.EventHandler(this.tb_skype_Click);
            this.tb_skype.TextChanged += new System.EventHandler(this.tb_skype_TextChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(91, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.ForeColor = System.Drawing.Color.DarkGray;
            this.lb_user.Location = new System.Drawing.Point(37, 78);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(69, 17);
            this.lb_user.TabIndex = 3;
            this.lb_user.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form_skype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(270, 222);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_skype);
            this.Controls.Add(this.pn_skype);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_skype";
            this.Text = "Form_skype";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_skype;
        private System.Windows.Forms.TextBox tb_skype;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}