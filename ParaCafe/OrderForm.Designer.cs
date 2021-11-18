
namespace ParaCafe
{
    partial class OrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgwOrderDetails = new System.Windows.Forms.DataGridView();
            this.nmuProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTableNo = new System.Windows.Forms.ComboBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOrderCancel = new System.Windows.Forms.Button();
            this.btnGetPay = new System.Windows.Forms.Button();
            this.btnBackToHome = new System.Windows.Forms.Button();
            this.lblTableNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuProductQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(333, 31);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgwOrderDetails
            // 
            this.dgwOrderDetails.AllowUserToAddRows = false;
            this.dgwOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwOrderDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgwOrderDetails.Location = new System.Drawing.Point(20, 73);
            this.dgwOrderDetails.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dgwOrderDetails.MultiSelect = false;
            this.dgwOrderDetails.Name = "dgwOrderDetails";
            this.dgwOrderDetails.ReadOnly = true;
            this.dgwOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwOrderDetails.Size = new System.Drawing.Size(510, 362);
            this.dgwOrderDetails.TabIndex = 5;
            // 
            // nmuProductQuantity
            // 
            this.nmuProductQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmuProductQuantity.Location = new System.Drawing.Point(223, 32);
            this.nmuProductQuantity.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.nmuProductQuantity.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nmuProductQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmuProductQuantity.Name = "nmuProductQuantity";
            this.nmuProductQuantity.Size = new System.Drawing.Size(100, 23);
            this.nmuProductQuantity.TabIndex = 1;
            this.nmuProductQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet";
            // 
            // cmbTableNo
            // 
            this.cmbTableNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTableNo.FormattingEnabled = true;
            this.cmbTableNo.Location = new System.Drawing.Point(586, 28);
            this.cmbTableNo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbTableNo.Name = "cmbTableNo";
            this.cmbTableNo.Size = new System.Drawing.Size(122, 24);
            this.cmbTableNo.TabIndex = 3;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(718, 28);
            this.btnMove.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(88, 24);
            this.btnMove.TabIndex = 4;
            this.btnMove.Text = "TAŞI";
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Masa No:";
            // 
            // btnOrderCancel
            // 
            this.btnOrderCancel.BackColor = System.Drawing.Color.Maroon;
            this.btnOrderCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrderCancel.Location = new System.Drawing.Point(553, 316);
            this.btnOrderCancel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnOrderCancel.Name = "btnOrderCancel";
            this.btnOrderCancel.Size = new System.Drawing.Size(122, 46);
            this.btnOrderCancel.TabIndex = 7;
            this.btnOrderCancel.Text = "SİPARİŞ İPTAL";
            this.btnOrderCancel.UseVisualStyleBackColor = false;
            this.btnOrderCancel.Click += new System.EventHandler(this.btnOrderCancel_Click);
            // 
            // btnGetPay
            // 
            this.btnGetPay.BackColor = System.Drawing.Color.Teal;
            this.btnGetPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetPay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGetPay.Location = new System.Drawing.Point(685, 316);
            this.btnGetPay.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGetPay.Name = "btnGetPay";
            this.btnGetPay.Size = new System.Drawing.Size(122, 46);
            this.btnGetPay.TabIndex = 8;
            this.btnGetPay.Text = "ÖDEME AL";
            this.btnGetPay.UseVisualStyleBackColor = false;
            this.btnGetPay.Click += new System.EventHandler(this.btnGetPay_Click);
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.BackColor = System.Drawing.Color.Gold;
            this.btnBackToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToHome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBackToHome.Location = new System.Drawing.Point(553, 373);
            this.btnBackToHome.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(254, 46);
            this.btnBackToHome.TabIndex = 9;
            this.btnBackToHome.Text = "ANASAYFAYA  DÖN";
            this.btnBackToHome.UseVisualStyleBackColor = false;
            this.btnBackToHome.Click += new System.EventHandler(this.btnBackToHome_Click);
            // 
            // lblTableNo
            // 
            this.lblTableNo.BackColor = System.Drawing.Color.Wheat;
            this.lblTableNo.Font = new System.Drawing.Font("Felix Titling", 96F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTableNo.Location = new System.Drawing.Point(550, 86);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(257, 146);
            this.lblTableNo.TabIndex = 6;
            this.lblTableNo.Text = "00";
            this.lblTableNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "___________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "___________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "___________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(550, 265);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "SİPARİŞ TUTARI: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(538, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "___________________________";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotalPrice.Location = new System.Drawing.Point(712, 266);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(75, 16);
            this.lblTotalPrice.TabIndex = 17;
            this.lblTotalPrice.Text = "00,00 ₺";
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(23, 31);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(190, 24);
            this.cmbProduct.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ProductName";
            this.Column1.HeaderText = "Product";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle1.Format = "#,###.00₺";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Price";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ProductQuantity";
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TotalPrice";
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 448);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTableNo);
            this.Controls.Add(this.btnBackToHome);
            this.Controls.Add(this.btnGetPay);
            this.Controls.Add(this.btnOrderCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.cmbTableNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.nmuProductQuantity);
            this.Controls.Add(this.dgwOrderDetails);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "OrderForm";
            this.Text = "MASA 0";
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuProductQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgwOrderDetails;
        private System.Windows.Forms.NumericUpDown nmuProductQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTableNo;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOrderCancel;
        private System.Windows.Forms.Button btnGetPay;
        private System.Windows.Forms.Button btnBackToHome;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}