namespace ComputerShopManagementSystem.PAL
{
    partial class UserControlProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcProduct = new System.Windows.Forms.TabControl();
            this.tpAddProduct = new System.Windows.Forms.TabPage();
            this.tpManageProduct = new System.Windows.Forms.TabPage();
            this.tpOptions = new System.Windows.Forms.TabPage();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudRate = new System.Windows.Forms.NumericUpDown();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tcProduct.SuspendLayout();
            this.tpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tcProduct
            // 
            this.tcProduct.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcProduct.Controls.Add(this.tpAddProduct);
            this.tcProduct.Controls.Add(this.tpManageProduct);
            this.tcProduct.Controls.Add(this.tpOptions);
            this.tcProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcProduct.Location = new System.Drawing.Point(14, 12);
            this.tcProduct.Name = "tcProduct";
            this.tcProduct.SelectedIndex = 0;
            this.tcProduct.Size = new System.Drawing.Size(718, 439);
            this.tcProduct.TabIndex = 0;
            // 
            // tpAddProduct
            // 
            this.tpAddProduct.Location = new System.Drawing.Point(4, 4);
            this.tpAddProduct.Name = "tpAddProduct";
            this.tpAddProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpAddProduct.Size = new System.Drawing.Size(710, 411);
            this.tpAddProduct.TabIndex = 0;
            this.tpAddProduct.Text = "Add Product";
            this.tpAddProduct.UseVisualStyleBackColor = true;
            // 
            // tpManageProduct
            // 
            this.tpManageProduct.Location = new System.Drawing.Point(4, 4);
            this.tpManageProduct.Name = "tpManageProduct";
            this.tpManageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tpManageProduct.Size = new System.Drawing.Size(710, 411);
            this.tpManageProduct.TabIndex = 1;
            this.tpManageProduct.Text = "Manage Product";
            this.tpManageProduct.UseVisualStyleBackColor = true;
            // 
            // tpOptions
            // 
            this.tpOptions.Controls.Add(this.comboBox1);
            this.tpOptions.Controls.Add(this.label6);
            this.tpOptions.Controls.Add(this.cmbBrand);
            this.tpOptions.Controls.Add(this.label5);
            this.tpOptions.Controls.Add(this.nudQuantity);
            this.tpOptions.Controls.Add(this.nudRate);
            this.tpOptions.Controls.Add(this.label4);
            this.tpOptions.Controls.Add(this.label3);
            this.tpOptions.Controls.Add(this.txtProductName);
            this.tpOptions.Controls.Add(this.label2);
            this.tpOptions.Controls.Add(this.label1);
            this.tpOptions.Location = new System.Drawing.Point(4, 4);
            this.tpOptions.Name = "tpOptions";
            this.tpOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tpOptions.Size = new System.Drawing.Size(710, 411);
            this.tpOptions.TabIndex = 2;
            this.tpOptions.Text = "Options";
            this.tpOptions.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Location = new System.Drawing.Point(55, 82);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(457, 23);
            this.txtProductName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(52, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "../Add Product";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(52, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rate:";
            // 
            // nudRate
            // 
            this.nudRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudRate.Location = new System.Drawing.Point(55, 136);
            this.nudRate.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudRate.Name = "nudRate";
            this.nudRate.Size = new System.Drawing.Size(221, 23);
            this.nudRate.TabIndex = 6;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudQuantity.Location = new System.Drawing.Point(291, 136);
            this.nudQuantity.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(221, 23);
            this.nudQuantity.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(288, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity:";
            // 
            // cmbBrand
            // 
            this.cmbBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Items.AddRange(new object[] {
            "--SELECT--"});
            this.cmbBrand.Location = new System.Drawing.Point(55, 190);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(291, 23);
            this.cmbBrand.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(52, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Brand:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "--SELECT--"});
            this.comboBox1.Location = new System.Drawing.Point(55, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(291, 23);
            this.comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(52, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Category:";
            // 
            // UserControlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tcProduct);
            this.Name = "UserControlProduct";
            this.Size = new System.Drawing.Size(747, 646);
            this.tcProduct.ResumeLayout(false);
            this.tpOptions.ResumeLayout(false);
            this.tpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcProduct;
        private System.Windows.Forms.TabPage tpAddProduct;
        private System.Windows.Forms.TabPage tpManageProduct;
        private System.Windows.Forms.TabPage tpOptions;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
    }
}
