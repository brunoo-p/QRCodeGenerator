
namespace QR.ui
{
    partial class Form_link
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_link));
            this.tb_link = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_createLink = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_link
            // 
            this.tb_link.Location = new System.Drawing.Point(15, 104);
            this.tb_link.Multiline = true;
            this.tb_link.Name = "tb_link";
            this.tb_link.Size = new System.Drawing.Size(243, 33);
            this.tb_link.TabIndex = 0;
            this.tb_link.TextChanged += new System.EventHandler(this.tb_link_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Press \'OK\' and look the Preview";
            // 
            // btn_createLink
            // 
            this.btn_createLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_createLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createLink.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createLink.ForeColor = System.Drawing.Color.White;
            this.btn_createLink.Location = new System.Drawing.Point(93, 171);
            this.btn_createLink.Name = "btn_createLink";
            this.btn_createLink.Size = new System.Drawing.Size(75, 29);
            this.btn_createLink.TabIndex = 8;
            this.btn_createLink.Text = "OK";
            this.btn_createLink.UseVisualStyleBackColor = true;
            this.btn_createLink.Click += new System.EventHandler(this.btn_createLink_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form_link
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(270, 222);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_createLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_link);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_link";
            this.Text = "Link";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_link;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_createLink;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}