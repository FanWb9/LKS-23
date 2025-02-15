namespace LKS_23
{
    partial class FormManageMenuIngredient
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgMenu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCan = new System.Windows.Forms.Button();
            this.dgIng = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CbUn = new System.Windows.Forms.ComboBox();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.CbIng = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Menu Ingredients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(86, 75);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(257, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgMenu
            // 
            this.dgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMenu.Location = new System.Drawing.Point(19, 122);
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.RowHeadersWidth = 62;
            this.dgMenu.RowTemplate.Height = 28;
            this.dgMenu.Size = new System.Drawing.Size(397, 559);
            this.dgMenu.TabIndex = 3;
            this.dgMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMenu_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnCan);
            this.groupBox1.Controls.Add(this.dgIng);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.CbUn);
            this.groupBox1.Controls.Add(this.num);
            this.groupBox1.Controls.Add(this.CbIng);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(455, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 541);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingredients";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(511, 400);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(119, 33);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCan
            // 
            this.BtnCan.Location = new System.Drawing.Point(359, 400);
            this.BtnCan.Name = "BtnCan";
            this.BtnCan.Size = new System.Drawing.Size(119, 33);
            this.BtnCan.TabIndex = 7;
            this.BtnCan.Text = "Cancel";
            this.BtnCan.UseVisualStyleBackColor = true;
            // 
            // dgIng
            // 
            this.dgIng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIng.Location = new System.Drawing.Point(11, 125);
            this.dgIng.Name = "dgIng";
            this.dgIng.RowHeadersWidth = 62;
            this.dgIng.RowTemplate.Height = 28;
            this.dgIng.Size = new System.Drawing.Size(731, 242);
            this.dgIng.TabIndex = 6;
            this.dgIng.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgIng_CellContentClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(393, 77);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(119, 33);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // CbUn
            // 
            this.CbUn.FormattingEnabled = true;
            this.CbUn.Location = new System.Drawing.Point(235, 79);
            this.CbUn.Name = "CbUn";
            this.CbUn.Size = new System.Drawing.Size(152, 28);
            this.CbUn.TabIndex = 4;
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(159, 81);
            this.num.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(61, 26);
            this.num.TabIndex = 3;
            this.num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CbIng
            // 
            this.CbIng.FormattingEnabled = true;
            this.CbIng.Location = new System.Drawing.Point(159, 29);
            this.CbIng.Name = "CbIng";
            this.CbIng.Size = new System.Drawing.Size(228, 28);
            this.CbIng.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose ingredients";
            // 
            // FormManageMenuIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 779);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgMenu);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormManageMenuIngredient";
            this.Text = "FormManageMenuIngredient";
            this.Load += new System.EventHandler(this.FormManageMenuIngredient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ComboBox CbUn;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.ComboBox CbIng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCan;
        private System.Windows.Forms.DataGridView dgIng;
    }
}