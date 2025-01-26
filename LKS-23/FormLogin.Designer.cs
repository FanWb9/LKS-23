namespace LKS_23
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.ckPas = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(280, 140);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(219, 26);
            this.txtUser.TabIndex = 1;
            // 
            // txtPas
            // 
            this.txtPas.Location = new System.Drawing.Point(280, 212);
            this.txtPas.Name = "txtPas";
            this.txtPas.Size = new System.Drawing.Size(219, 26);
            this.txtPas.TabIndex = 2;
            this.txtPas.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LKS_23.Properties.Resources.Icon_Small;
            this.pictureBox1.Location = new System.Drawing.Point(52, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(506, 284);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(109, 35);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "Login";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // ckPas
            // 
            this.ckPas.AutoSize = true;
            this.ckPas.Location = new System.Drawing.Point(506, 212);
            this.ckPas.Name = "ckPas";
            this.ckPas.Size = new System.Drawing.Size(147, 24);
            this.ckPas.TabIndex = 7;
            this.ckPas.Text = "Open Password";
            this.ckPas.UseVisualStyleBackColor = true;
            this.ckPas.CheckedChanged += new System.EventHandler(this.ckPas_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "New member here ?";
            // 
            // lbLink
            // 
            this.lbLink.AutoSize = true;
            this.lbLink.Location = new System.Drawing.Point(399, 291);
            this.lbLink.Name = "lbLink";
            this.lbLink.Size = new System.Drawing.Size(71, 20);
            this.lbLink.TabIndex = 9;
            this.lbLink.TabStop = true;
            this.lbLink.Text = "Join now";
            this.lbLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLink_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 363);
            this.Controls.Add(this.lbLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckPas);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPas);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.CheckBox ckPas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lbLink;
    }
}

