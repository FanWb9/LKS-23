namespace LKS_23
{
    partial class FormAdmin
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
            this.lbName = new System.Windows.Forms.Label();
            this.Jm = new System.Windows.Forms.Timer(this.components);
            this.lbJam = new System.Windows.Forms.Label();
            this.btnMang = new System.Windows.Forms.Button();
            this.btnMmenu = new System.Windows.Forms.Button();
            this.btnIngre = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(50, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(85, 29);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            // 
            // Jm
            // 
            this.Jm.Interval = 1000;
            this.Jm.Tick += new System.EventHandler(this.Jm_Tick);
            // 
            // lbJam
            // 
            this.lbJam.AutoSize = true;
            this.lbJam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJam.Location = new System.Drawing.Point(471, 21);
            this.lbJam.Name = "lbJam";
            this.lbJam.Size = new System.Drawing.Size(61, 29);
            this.lbJam.TabIndex = 1;
            this.lbJam.Text = "Jam";
            // 
            // btnMang
            // 
            this.btnMang.Location = new System.Drawing.Point(184, 78);
            this.btnMang.Name = "btnMang";
            this.btnMang.Size = new System.Drawing.Size(234, 75);
            this.btnMang.TabIndex = 2;
            this.btnMang.Text = "Manage Members";
            this.btnMang.UseVisualStyleBackColor = true;
            this.btnMang.Click += new System.EventHandler(this.btnMang_Click);
            // 
            // btnMmenu
            // 
            this.btnMmenu.Location = new System.Drawing.Point(184, 187);
            this.btnMmenu.Name = "btnMmenu";
            this.btnMmenu.Size = new System.Drawing.Size(234, 75);
            this.btnMmenu.TabIndex = 3;
            this.btnMmenu.Text = "Manage Menu";
            this.btnMmenu.UseVisualStyleBackColor = true;
            this.btnMmenu.Click += new System.EventHandler(this.btnMmenu_Click);
            // 
            // btnIngre
            // 
            this.btnIngre.Location = new System.Drawing.Point(184, 290);
            this.btnIngre.Name = "btnIngre";
            this.btnIngre.Size = new System.Drawing.Size(234, 75);
            this.btnIngre.TabIndex = 4;
            this.btnIngre.Text = "Manage Menu Ingredients";
            this.btnIngre.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(184, 390);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(234, 75);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View Reservations";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(251, 506);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(96, 38);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "Log Out";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 596);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnIngre);
            this.Controls.Add(this.btnMmenu);
            this.Controls.Add(this.btnMang);
            this.Controls.Add(this.lbJam);
            this.Controls.Add(this.lbName);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Timer Jm;
        private System.Windows.Forms.Label lbJam;
        private System.Windows.Forms.Button btnMang;
        private System.Windows.Forms.Button btnMmenu;
        private System.Windows.Forms.Button btnIngre;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnLog;
    }
}