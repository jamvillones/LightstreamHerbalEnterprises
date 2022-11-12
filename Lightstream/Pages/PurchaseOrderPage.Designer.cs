﻿namespace Lightstream
{
    partial class PurchaseOrderPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this._poTable = new System.Windows.Forms.DataGridView();
            this._viewDetails = new System.Windows.Forms.Button();
            this._managePO = new System.Windows.Forms.Button();
            this._cancelOrder = new System.Windows.Forms.Button();
            this._newPO = new System.Windows.Forms.Button();
            this._print = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.poNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._poTable)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(57, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(915, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Purchase Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.CustomFormat = "MMM d, yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 28);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2022, 11, 4, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(249, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "To:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker2.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker2.CustomFormat = "MMM d, yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(279, 54);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(195, 28);
            this.dateTimePicker2.TabIndex = 13;
            this.dateTimePicker2.Value = new System.DateTime(2022, 11, 4, 0, 0, 0, 0);
            // 
            // _poTable
            // 
            this._poTable.AllowUserToAddRows = false;
            this._poTable.AllowUserToDeleteRows = false;
            this._poTable.AllowUserToResizeRows = false;
            this._poTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._poTable.BackgroundColor = System.Drawing.Color.White;
            this._poTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._poTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._poTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._poTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._poTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.poNumCol,
            this.dateCol,
            this.ingCol,
            this.supplierCol,
            this.qtyCol,
            this.costCol,
            this.totalCol});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._poTable.DefaultCellStyle = dataGridViewCellStyle5;
            this._poTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._poTable.EnableHeadersVisualStyles = false;
            this._poTable.Location = new System.Drawing.Point(30, 131);
            this._poTable.Margin = new System.Windows.Forms.Padding(5);
            this._poTable.MultiSelect = false;
            this._poTable.Name = "_poTable";
            this._poTable.ReadOnly = true;
            this._poTable.RowHeadersVisible = false;
            this._poTable.RowHeadersWidth = 62;
            this._poTable.RowTemplate.Height = 25;
            this._poTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._poTable.Size = new System.Drawing.Size(915, 318);
            this._poTable.StandardTab = true;
            this._poTable.TabIndex = 18;
            // 
            // _viewDetails
            // 
            this._viewDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._viewDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._viewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._viewDetails.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._viewDetails.ForeColor = System.Drawing.Color.Black;
            this._viewDetails.Location = new System.Drawing.Point(369, 0);
            this._viewDetails.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._viewDetails.Name = "_viewDetails";
            this._viewDetails.Size = new System.Drawing.Size(120, 40);
            this._viewDetails.TabIndex = 22;
            this._viewDetails.Text = "View Details";
            this._viewDetails.UseVisualStyleBackColor = false;
            // 
            // _managePO
            // 
            this._managePO.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._managePO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._managePO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._managePO.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._managePO.ForeColor = System.Drawing.Color.Black;
            this._managePO.Location = new System.Drawing.Point(246, 0);
            this._managePO.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._managePO.Name = "_managePO";
            this._managePO.Size = new System.Drawing.Size(120, 40);
            this._managePO.TabIndex = 21;
            this._managePO.Text = "Manage PO";
            this._managePO.UseVisualStyleBackColor = false;
            // 
            // _cancelOrder
            // 
            this._cancelOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._cancelOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._cancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancelOrder.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cancelOrder.ForeColor = System.Drawing.Color.Black;
            this._cancelOrder.Location = new System.Drawing.Point(123, 0);
            this._cancelOrder.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._cancelOrder.Name = "_cancelOrder";
            this._cancelOrder.Size = new System.Drawing.Size(120, 40);
            this._cancelOrder.TabIndex = 20;
            this._cancelOrder.Text = "Cancel Order";
            this._cancelOrder.UseVisualStyleBackColor = false;
            // 
            // _newPO
            // 
            this._newPO.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._newPO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._newPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._newPO.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._newPO.ForeColor = System.Drawing.Color.Black;
            this._newPO.Location = new System.Drawing.Point(0, 0);
            this._newPO.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._newPO.Name = "_newPO";
            this._newPO.Size = new System.Drawing.Size(120, 40);
            this._newPO.TabIndex = 19;
            this._newPO.Text = "New PO";
            this._newPO.UseVisualStyleBackColor = false;
            // 
            // _print
            // 
            this._print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._print.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._print.ForeColor = System.Drawing.Color.Black;
            this._print.Location = new System.Drawing.Point(492, 0);
            this._print.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._print.Name = "_print";
            this._print.Size = new System.Drawing.Size(120, 40);
            this._print.TabIndex = 25;
            this._print.Text = "Print";
            this._print.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this._newPO);
            this.flowLayoutPanel1.Controls.Add(this._cancelOrder);
            this.flowLayoutPanel1.Controls.Add(this._managePO);
            this.flowLayoutPanel1.Controls.Add(this._viewDetails);
            this.flowLayoutPanel1.Controls.Add(this._print);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 449);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(915, 40);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(30, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 100);
            this.panel1.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(0, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Search...";
            this.textBox1.Size = new System.Drawing.Size(243, 23);
            this.textBox1.TabIndex = 19;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.radioButton2);
            this.flowLayoutPanel2.Controls.Add(this.radioButton3);
            this.flowLayoutPanel2.Controls.Add(this.radioButton4);
            this.flowLayoutPanel2.Controls.Add(this.radioButton5);
            this.flowLayoutPanel2.Controls.Add(this.radioButton6);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(482, 54);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(433, 28);
            this.flowLayoutPanel2.TabIndex = 18;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Bebas Neue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(390, 3);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 23);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "All";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Bebas Neue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(310, 3);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 23);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Cancelled";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Bebas Neue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton4.Location = new System.Drawing.Point(238, 3);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(69, 23);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Received";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Bebas Neue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton5.Location = new System.Drawing.Point(153, 3);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(82, 23);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Incomplete";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Font = new System.Drawing.Font("Bebas Neue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton6.Location = new System.Drawing.Point(85, 3);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(65, 23);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Pending";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // poNumCol
            // 
            this.poNumCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.poNumCol.HeaderText = "PO NO.";
            this.poNumCol.MinimumWidth = 60;
            this.poNumCol.Name = "poNumCol";
            this.poNumCol.ReadOnly = true;
            this.poNumCol.Width = 66;
            // 
            // dateCol
            // 
            dataGridViewCellStyle2.Format = "MMM d, yyyy h:mm tt";
            dataGridViewCellStyle2.NullValue = "No Date Available";
            this.dateCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateCol.HeaderText = "Date Ordered";
            this.dateCol.MinimumWidth = 8;
            this.dateCol.Name = "dateCol";
            this.dateCol.ReadOnly = true;
            // 
            // ingCol
            // 
            this.ingCol.HeaderText = "Ingredient";
            this.ingCol.Name = "ingCol";
            this.ingCol.ReadOnly = true;
            // 
            // supplierCol
            // 
            this.supplierCol.HeaderText = "Supplier";
            this.supplierCol.MinimumWidth = 8;
            this.supplierCol.Name = "supplierCol";
            this.supplierCol.ReadOnly = true;
            // 
            // qtyCol
            // 
            this.qtyCol.HeaderText = "Qty";
            this.qtyCol.MinimumWidth = 8;
            this.qtyCol.Name = "qtyCol";
            this.qtyCol.ReadOnly = true;
            // 
            // costCol
            // 
            this.costCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "₱ 0.00";
            this.costCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.costCol.HeaderText = "Cost";
            this.costCol.Name = "costCol";
            this.costCol.ReadOnly = true;
            // 
            // totalCol
            // 
            this.totalCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Format = "₱ 0.00";
            this.totalCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalCol.HeaderText = "Total Amount";
            this.totalCol.MinimumWidth = 110;
            this.totalCol.Name = "totalCol";
            this.totalCol.ReadOnly = true;
            this.totalCol.Width = 110;
            // 
            // PurchaseOrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 520);
            this.Controls.Add(this._poTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bebas Neue", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "PurchaseOrderPage";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 30, 31);
            this.Text = "FPO";
            this.Load += new System.EventHandler(this.PurchaseOrderPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this._poTable)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private DataGridView _poTable;
        private Button _viewDetails;
        private Button _managePO;
        private Button _cancelOrder;
        private Button _newPO;
        private Button _print;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn poNumCol;
        private DataGridViewTextBoxColumn dateCol;
        private DataGridViewTextBoxColumn ingCol;
        private DataGridViewTextBoxColumn supplierCol;
        private DataGridViewTextBoxColumn qtyCol;
        private DataGridViewTextBoxColumn costCol;
        private DataGridViewTextBoxColumn totalCol;
    }
}