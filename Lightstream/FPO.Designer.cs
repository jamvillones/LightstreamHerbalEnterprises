namespace Lightstream
{
    partial class FPO
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this._supplierName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._Status = new System.Windows.Forms.ComboBox();
            this._PoTable = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._viewDetails = new System.Windows.Forms.Button();
            this._managePO = new System.Windows.Forms.Button();
            this._cancelOrder = new System.Windows.Forms.Button();
            this._newPO = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this._totaltItems = new System.Windows.Forms.TextBox();
            this._print = new System.Windows.Forms.Button();
            this._close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._PoTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(57, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(929, 50);
            this.label1.TabIndex = 9;
            this.label1.Text = "Purchase Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 44);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2022, 11, 4, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 37);
            this.label3.TabIndex = 12;
            this.label3.Text = "To:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(304, 57);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(170, 44);
            this.dateTimePicker2.TabIndex = 13;
            this.dateTimePicker2.Value = new System.DateTime(2022, 11, 4, 0, 0, 0, 0);
            // 
            // _supplierName
            // 
            this._supplierName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._supplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._supplierName.FormattingEnabled = true;
            this._supplierName.Location = new System.Drawing.Point(648, 57);
            this._supplierName.Name = "_supplierName";
            this._supplierName.Size = new System.Drawing.Size(274, 45);
            this._supplierName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "Supplier Name:";
            // 
            // _Status
            // 
            this._Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._Status.FormattingEnabled = true;
            this._Status.Items.AddRange(new object[] {
            "Pending",
            "Incomplete",
            "Received",
            "Cancelled",
            "All"});
            this._Status.Location = new System.Drawing.Point(648, 114);
            this._Status.Name = "_Status";
            this._Status.Size = new System.Drawing.Size(274, 45);
            this._Status.TabIndex = 16;
            // 
            // _PoTable
            // 
            this._PoTable.AllowUserToAddRows = false;
            this._PoTable.AllowUserToDeleteRows = false;
            this._PoTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._PoTable.BackgroundColor = System.Drawing.Color.White;
            this._PoTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._PoTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._PoTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this._PoTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._PoTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5});
            this._PoTable.Location = new System.Drawing.Point(13, 173);
            this._PoTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._PoTable.Name = "_PoTable";
            this._PoTable.ReadOnly = true;
            this._PoTable.RowHeadersVisible = false;
            this._PoTable.RowHeadersWidth = 62;
            this._PoTable.RowTemplate.Height = 25;
            this._PoTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._PoTable.Size = new System.Drawing.Size(909, 524);
            this._PoTable.TabIndex = 18;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "PO NO.";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Date Ordered";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Supplier Name";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Total No. of Items";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Total Amount";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // _viewDetails
            // 
            this._viewDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._viewDetails.BackColor = System.Drawing.Color.ForestGreen;
            this._viewDetails.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._viewDetails.ForeColor = System.Drawing.Color.White;
            this._viewDetails.Location = new System.Drawing.Point(176, 780);
            this._viewDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._viewDetails.Name = "_viewDetails";
            this._viewDetails.Size = new System.Drawing.Size(154, 57);
            this._viewDetails.TabIndex = 22;
            this._viewDetails.Text = "View Details";
            this._viewDetails.UseVisualStyleBackColor = false;
            // 
            // _managePO
            // 
            this._managePO.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._managePO.BackColor = System.Drawing.Color.ForestGreen;
            this._managePO.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._managePO.ForeColor = System.Drawing.Color.White;
            this._managePO.Location = new System.Drawing.Point(338, 780);
            this._managePO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._managePO.Name = "_managePO";
            this._managePO.Size = new System.Drawing.Size(139, 57);
            this._managePO.TabIndex = 21;
            this._managePO.Text = "Manage PO";
            this._managePO.UseVisualStyleBackColor = false;
            // 
            // _cancelOrder
            // 
            this._cancelOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._cancelOrder.BackColor = System.Drawing.Color.ForestGreen;
            this._cancelOrder.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cancelOrder.ForeColor = System.Drawing.Color.White;
            this._cancelOrder.Location = new System.Drawing.Point(485, 780);
            this._cancelOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._cancelOrder.Name = "_cancelOrder";
            this._cancelOrder.Size = new System.Drawing.Size(159, 57);
            this._cancelOrder.TabIndex = 20;
            this._cancelOrder.Text = "Cancel Order";
            this._cancelOrder.UseVisualStyleBackColor = false;
            // 
            // _newPO
            // 
            this._newPO.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._newPO.BackColor = System.Drawing.Color.ForestGreen;
            this._newPO.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._newPO.ForeColor = System.Drawing.Color.White;
            this._newPO.Location = new System.Drawing.Point(29, 780);
            this._newPO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._newPO.Name = "_newPO";
            this._newPO.Size = new System.Drawing.Size(139, 57);
            this._newPO.TabIndex = 19;
            this._newPO.Text = "New PO";
            this._newPO.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bebas Neue", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(675, 716);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "Total No. of Items:";
            // 
            // _totaltItems
            // 
            this._totaltItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._totaltItems.Location = new System.Drawing.Point(813, 705);
            this._totaltItems.Name = "_totaltItems";
            this._totaltItems.ReadOnly = true;
            this._totaltItems.Size = new System.Drawing.Size(109, 44);
            this._totaltItems.TabIndex = 24;
            // 
            // _print
            // 
            this._print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._print.BackColor = System.Drawing.Color.ForestGreen;
            this._print.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._print.ForeColor = System.Drawing.Color.White;
            this._print.Location = new System.Drawing.Point(652, 779);
            this._print.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._print.Name = "_print";
            this._print.Size = new System.Drawing.Size(109, 57);
            this._print.TabIndex = 25;
            this._print.Text = "Print";
            this._print.UseVisualStyleBackColor = false;
            // 
            // _close
            // 
            this._close.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._close.BackColor = System.Drawing.Color.ForestGreen;
            this._close.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._close.ForeColor = System.Drawing.Color.White;
            this._close.Location = new System.Drawing.Point(769, 779);
            this._close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._close.Name = "_close";
            this._close.Size = new System.Drawing.Size(128, 57);
            this._close.TabIndex = 26;
            this._close.Text = "Close";
            this._close.UseVisualStyleBackColor = false;
            this._close.Click += new System.EventHandler(this._close_Click);
            // 
            // FPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 850);
            this.Controls.Add(this._close);
            this.Controls.Add(this._print);
            this.Controls.Add(this._totaltItems);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._viewDetails);
            this.Controls.Add(this._managePO);
            this.Controls.Add(this._cancelOrder);
            this.Controls.Add(this._newPO);
            this.Controls.Add(this._PoTable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._Status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._supplierName);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bebas Neue", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "FPO";
            this.Text = "FPO";
            ((System.ComponentModel.ISupportInitialize)(this._PoTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private ComboBox _supplierName;
        private Label label4;
        private Label label5;
        private ComboBox _Status;
        private DataGridView _PoTable;
        private Button _viewDetails;
        private Button _managePO;
        private Button _cancelOrder;
        private Button _newPO;
        private Label label6;
        private TextBox _totaltItems;
        private Button _print;
        private Button _close;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}