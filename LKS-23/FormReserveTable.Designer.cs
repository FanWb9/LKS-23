namespace LKS_23
{
    partial class FormReserveTable
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
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckEnable = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtChoose = new System.Windows.Forms.ComboBox();
            this.txtNum = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgMenu = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbMenuTotal = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(21, 61);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(158, 26);
            this.txtFirst.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(21, 212);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(361, 26);
            this.txtPhone.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(21, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(361, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(205, 61);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(177, 26);
            this.txtLast.TabIndex = 3;
            this.txtLast.TextChanged += new System.EventHandler(this.txtLast_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLast);
            this.groupBox1.Controls.Add(this.txtFirst);
            this.groupBox1.Location = new System.Drawing.Point(47, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 295);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customers Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone Number";
            // 
            // ckEnable
            // 
            this.ckEnable.AutoSize = true;
            this.ckEnable.Location = new System.Drawing.Point(68, 448);
            this.ckEnable.Name = "ckEnable";
            this.ckEnable.Size = new System.Drawing.Size(290, 24);
            this.ckEnable.TabIndex = 5;
            this.ckEnable.Text = "Use the same information as accont\r\n";
            this.ckEnable.UseVisualStyleBackColor = true;
            this.ckEnable.CheckedChanged += new System.EventHandler(this.ckEnable_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgMenu);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtNum);
            this.groupBox2.Controls.Add(this.txtChoose);
            this.groupBox2.Location = new System.Drawing.Point(475, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 416);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // txtChoose
            // 
            this.txtChoose.FormattingEnabled = true;
            this.txtChoose.Location = new System.Drawing.Point(116, 40);
            this.txtChoose.Name = "txtChoose";
            this.txtChoose.Size = new System.Drawing.Size(240, 28);
            this.txtChoose.TabIndex = 0;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(116, 91);
            this.txtNum.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.txtNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(217, 26);
            this.txtNum.TabIndex = 1;
            this.txtNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(372, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // dgMenu
            // 
            this.dgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMenu.Location = new System.Drawing.Point(10, 141);
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.RowHeadersWidth = 62;
            this.dgMenu.RowTemplate.Height = 28;
            this.dgMenu.Size = new System.Drawing.Size(830, 215);
            this.dgMenu.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choose Menu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Qty";
            // 
            // lbMenuTotal
            // 
            this.lbMenuTotal.AutoSize = true;
            this.lbMenuTotal.Location = new System.Drawing.Point(897, 461);
            this.lbMenuTotal.Name = "lbMenuTotal";
            this.lbMenuTotal.Size = new System.Drawing.Size(51, 20);
            this.lbMenuTotal.TabIndex = 7;
            this.lbMenuTotal.Text = "label7";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Location = new System.Drawing.Point(897, 545);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(51, 20);
            this.lbTotalPrice.TabIndex = 8;
            this.lbTotalPrice.Text = "label7";
            // 
            // FormReserveTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 670);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.lbMenuTotal);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ckEnable);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReserveTable";
            this.Text = "FormReserveTable";
            this.Load += new System.EventHandler(this.FormReserveTable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckEnable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgMenu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown txtNum;
        private System.Windows.Forms.ComboBox txtChoose;
        private System.Windows.Forms.Label lbMenuTotal;
        private System.Windows.Forms.Label lbTotalPrice;
    }
}