namespace Lightstream.Forms
{
    partial class SaleDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this._customer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._dateTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._Id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._soldProductsTable = new System.Windows.Forms.DataGridView();
            this.colProductNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this._paymentHistoryTable = new System.Windows.Forms.DataGridView();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._grandTotal = new System.Windows.Forms.Label();
            this._totalPayment = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._soldProductsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._paymentHistoryTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._customer);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this._dateTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._Id);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(30, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 114);
            this.panel1.TabIndex = 0;
            // 
            // _customer
            // 
            this._customer.Location = new System.Drawing.Point(159, 63);
            this._customer.Name = "_customer";
            this._customer.ReadOnly = true;
            this._customer.Size = new System.Drawing.Size(264, 23);
            this._customer.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(89, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 44;
            this.label6.Text = "Customer:";
            // 
            // _dateTime
            // 
            this._dateTime.Location = new System.Drawing.Point(159, 34);
            this._dateTime.Name = "_dateTime";
            this._dateTime.ReadOnly = true;
            this._dateTime.Size = new System.Drawing.Size(264, 23);
            this._dateTime.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 40;
            this.label1.Text = "Date/Time of Transaction:";
            // 
            // _Id
            // 
            this._Id.Location = new System.Drawing.Point(159, 5);
            this._Id.Name = "_Id";
            this._Id.ReadOnly = true;
            this._Id.Size = new System.Drawing.Size(264, 23);
            this._Id.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(62, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "Transaction ID:";
            // 
            // _soldProductsTable
            // 
            this._soldProductsTable.AllowUserToAddRows = false;
            this._soldProductsTable.AllowUserToDeleteRows = false;
            this._soldProductsTable.AllowUserToResizeRows = false;
            this._soldProductsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._soldProductsTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this._soldProductsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._soldProductsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._soldProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._soldProductsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductNumber,
            this.colProduct,
            this.colQty,
            this.colPrice});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._soldProductsTable.DefaultCellStyle = dataGridViewCellStyle4;
            this._soldProductsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._soldProductsTable.EnableHeadersVisualStyles = false;
            this._soldProductsTable.Location = new System.Drawing.Point(0, 30);
            this._soldProductsTable.MultiSelect = false;
            this._soldProductsTable.Name = "_soldProductsTable";
            this._soldProductsTable.ReadOnly = true;
            this._soldProductsTable.RowHeadersVisible = false;
            this._soldProductsTable.RowHeadersWidth = 62;
            this._soldProductsTable.RowTemplate.Height = 30;
            this._soldProductsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._soldProductsTable.Size = new System.Drawing.Size(490, 211);
            this._soldProductsTable.TabIndex = 31;
            // 
            // colProductNumber
            // 
            this.colProductNumber.HeaderText = "Product No.";
            this.colProductNumber.Name = "colProductNumber";
            this.colProductNumber.ReadOnly = true;
            // 
            // colProduct
            // 
            this.colProduct.HeaderText = "Product";
            this.colProduct.Name = "colProduct";
            this.colProduct.ReadOnly = true;
            // 
            // colQty
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.colQty.DefaultCellStyle = dataGridViewCellStyle2;
            this.colQty.HeaderText = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colPrice
            // 
            dataGridViewCellStyle3.Format = "₱ 0.00";
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(30, 149);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._soldProductsTable);
            this.splitContainer1.Panel1.Controls.Add(this._grandTotal);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._paymentHistoryTable);
            this.splitContainer1.Panel2.Controls.Add(this._totalPayment);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(740, 271);
            this.splitContainer1.SplitterDistance = 490;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("The Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label7.Size = new System.Drawing.Size(490, 30);
            this.label7.TabIndex = 32;
            this.label7.Text = "Items";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _paymentHistoryTable
            // 
            this._paymentHistoryTable.AllowUserToAddRows = false;
            this._paymentHistoryTable.AllowUserToDeleteRows = false;
            this._paymentHistoryTable.AllowUserToResizeRows = false;
            this._paymentHistoryTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._paymentHistoryTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this._paymentHistoryTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._paymentHistoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this._paymentHistoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._paymentHistoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAmount,
            this.colDate});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._paymentHistoryTable.DefaultCellStyle = dataGridViewCellStyle8;
            this._paymentHistoryTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._paymentHistoryTable.EnableHeadersVisualStyles = false;
            this._paymentHistoryTable.Location = new System.Drawing.Point(0, 30);
            this._paymentHistoryTable.MultiSelect = false;
            this._paymentHistoryTable.Name = "_paymentHistoryTable";
            this._paymentHistoryTable.ReadOnly = true;
            this._paymentHistoryTable.RowHeadersVisible = false;
            this._paymentHistoryTable.RowHeadersWidth = 62;
            this._paymentHistoryTable.RowTemplate.Height = 30;
            this._paymentHistoryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._paymentHistoryTable.Size = new System.Drawing.Size(240, 211);
            this._paymentHistoryTable.TabIndex = 34;
            // 
            // colAmount
            // 
            dataGridViewCellStyle6.Format = "₱ 0.00";
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colDate
            // 
            dataGridViewCellStyle7.Format = "g";
            dataGridViewCellStyle7.NullValue = null;
            this.colDate.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDate.HeaderText = "Date/Time";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("The Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(240, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "Payment History";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("The Bold Font", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label3.Location = new System.Drawing.Point(30, 5);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(740, 30);
            this.label3.TabIndex = 33;
            this.label3.Text = "Sale Details";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _grandTotal
            // 
            this._grandTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._grandTotal.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._grandTotal.ForeColor = System.Drawing.Color.Black;
            this._grandTotal.Location = new System.Drawing.Point(0, 241);
            this._grandTotal.Name = "_grandTotal";
            this._grandTotal.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this._grandTotal.Size = new System.Drawing.Size(490, 30);
            this._grandTotal.TabIndex = 33;
            this._grandTotal.Text = "Grand Total:";
            this._grandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _totalPayment
            // 
            this._totalPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._totalPayment.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._totalPayment.ForeColor = System.Drawing.Color.Black;
            this._totalPayment.Location = new System.Drawing.Point(0, 241);
            this._totalPayment.Name = "_totalPayment";
            this._totalPayment.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this._totalPayment.Size = new System.Drawing.Size(240, 30);
            this._totalPayment.TabIndex = 35;
            this._totalPayment.Text = "Grand Total:";
            this._totalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaleDetails";
            this.Padding = new System.Windows.Forms.Padding(30, 5, 30, 30);
            this.Text = "Sales Details";
            this.Load += new System.EventHandler(this.SaleDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._soldProductsTable)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._paymentHistoryTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView _soldProductsTable;
        private Label label5;
        private TextBox _Id;
        private TextBox _dateTime;
        private Label label1;
        private SplitContainer splitContainer1;
        private Label label7;
        private DataGridView _paymentHistoryTable;
        private Label label2;
        private Label label3;
        private TextBox _customer;
        private Label label6;
        private DataGridViewTextBoxColumn colProductNumber;
        private DataGridViewTextBoxColumn colProduct;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colDate;
        private Label _grandTotal;
        private Label _totalPayment;
    }
}