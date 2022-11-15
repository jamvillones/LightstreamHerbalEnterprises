namespace Lightstream
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
            this._fromDT = new System.Windows.Forms.DateTimePicker();
            this._fromLabel = new System.Windows.Forms.Label();
            this._toLabel = new System.Windows.Forms.Label();
            this._toDT = new System.Windows.Forms.DateTimePicker();
            this._poTable = new System.Windows.Forms.DataGridView();
            this.poNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._cancelOrder = new System.Windows.Forms.Button();
            this._newPO = new System.Windows.Forms.Button();
            this._print = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this._search = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._poTable)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(915, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Purchase Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _fromDT
            // 
            this._fromDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._fromDT.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._fromDT.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this._fromDT.Checked = false;
            this._fromDT.CustomFormat = "MMM d, yyyy";
            this._fromDT.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._fromDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._fromDT.Location = new System.Drawing.Point(49, 3);
            this._fromDT.Name = "_fromDT";
            this._fromDT.Size = new System.Drawing.Size(120, 22);
            this._fromDT.TabIndex = 10;
            this._fromDT.ValueChanged += new System.EventHandler(this._fromDT_ValueChanged);
            // 
            // _fromLabel
            // 
            this._fromLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._fromLabel.AutoSize = true;
            this._fromLabel.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._fromLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this._fromLabel.Location = new System.Drawing.Point(3, 3);
            this._fromLabel.Name = "_fromLabel";
            this._fromLabel.Size = new System.Drawing.Size(40, 21);
            this._fromLabel.TabIndex = 11;
            this._fromLabel.Text = "From:";
            this._fromLabel.Visible = false;
            // 
            // _toLabel
            // 
            this._toLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._toLabel.AutoSize = true;
            this._toLabel.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._toLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this._toLabel.Location = new System.Drawing.Point(175, 3);
            this._toLabel.Name = "_toLabel";
            this._toLabel.Size = new System.Drawing.Size(25, 21);
            this._toLabel.TabIndex = 12;
            this._toLabel.Text = "To:";
            this._toLabel.Visible = false;
            // 
            // _toDT
            // 
            this._toDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._toDT.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._toDT.CalendarMonthBackground = System.Drawing.SystemColors.ActiveCaption;
            this._toDT.CalendarTrailingForeColor = System.Drawing.SystemColors.ActiveCaption;
            this._toDT.Checked = false;
            this._toDT.CustomFormat = "MMM d, yyyy";
            this._toDT.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._toDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._toDT.Location = new System.Drawing.Point(206, 3);
            this._toDT.Name = "_toDT";
            this._toDT.Size = new System.Drawing.Size(120, 22);
            this._toDT.TabIndex = 13;
            this._toDT.Visible = false;
            this._toDT.ValueChanged += new System.EventHandler(this._fromDT_ValueChanged);
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
            this.totalCol,
            this.statusCol});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._poTable.DefaultCellStyle = dataGridViewCellStyle5;
            this._poTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._poTable.EnableHeadersVisualStyles = false;
            this._poTable.Location = new System.Drawing.Point(30, 139);
            this._poTable.Margin = new System.Windows.Forms.Padding(5);
            this._poTable.MultiSelect = false;
            this._poTable.Name = "_poTable";
            this._poTable.ReadOnly = true;
            this._poTable.RowHeadersVisible = false;
            this._poTable.RowHeadersWidth = 62;
            this._poTable.RowTemplate.Height = 30;
            this._poTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._poTable.Size = new System.Drawing.Size(915, 302);
            this._poTable.StandardTab = true;
            this._poTable.TabIndex = 18;
            this._poTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this._poTable_RowsAdded);
            this._poTable.SelectionChanged += new System.EventHandler(this._poTable_SelectionChanged);
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
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
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
            // statusCol
            // 
            this.statusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.statusCol.HeaderText = "Status";
            this.statusCol.Name = "statusCol";
            this.statusCol.ReadOnly = true;
            this.statusCol.Width = 69;
            // 
            // _cancelOrder
            // 
            this._cancelOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._cancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this._cancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancelOrder.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cancelOrder.ForeColor = System.Drawing.Color.Black;
            this._cancelOrder.Location = new System.Drawing.Point(123, 2);
            this._cancelOrder.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._cancelOrder.Name = "_cancelOrder";
            this._cancelOrder.Size = new System.Drawing.Size(120, 40);
            this._cancelOrder.TabIndex = 20;
            this._cancelOrder.Text = "Cancel Order";
            this._cancelOrder.UseVisualStyleBackColor = false;
            this._cancelOrder.Click += new System.EventHandler(this._cancelOrder_Click);
            // 
            // _newPO
            // 
            this._newPO.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._newPO.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._newPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._newPO.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._newPO.ForeColor = System.Drawing.Color.Black;
            this._newPO.Location = new System.Drawing.Point(0, 2);
            this._newPO.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._newPO.Name = "_newPO";
            this._newPO.Size = new System.Drawing.Size(120, 40);
            this._newPO.TabIndex = 19;
            this._newPO.Text = "New PO";
            this._newPO.UseVisualStyleBackColor = false;
            this._newPO.Click += new System.EventHandler(this._newPO_Click);
            // 
            // _print
            // 
            this._print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._print.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._print.ForeColor = System.Drawing.Color.Black;
            this._print.Location = new System.Drawing.Point(738, 2);
            this._print.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._print.Name = "_print";
            this._print.Size = new System.Drawing.Size(120, 40);
            this._print.TabIndex = 25;
            this._print.Text = "Print";
            this._print.UseVisualStyleBackColor = false;
            this._print.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this._newPO);
            this.flowLayoutPanel1.Controls.Add(this._cancelOrder);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this._print);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 441);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(915, 44);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(246, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "mark as Incomplete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(492, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(243, 40);
            this.button2.TabIndex = 20;
            this.button2.Text = "Mark as Recieved";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel6);
            this.panel1.Controls.Add(this.flowLayoutPanel5);
            this.panel1.Controls.Add(this.flowLayoutPanel4);
            this.panel1.Controls.Add(this._search);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(30, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 108);
            this.panel1.TabIndex = 28;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel6.Controls.Add(this._fromLabel);
            this.flowLayoutPanel6.Controls.Add(this._fromDT);
            this.flowLayoutPanel6.Controls.Add(this._toLabel);
            this.flowLayoutPanel6.Controls.Add(this._toDT);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 70);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(329, 28);
            this.flowLayoutPanel6.TabIndex = 22;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel5.Controls.Add(this.radioButton10);
            this.flowLayoutPanel5.Controls.Add(this.radioButton9);
            this.flowLayoutPanel5.Controls.Add(this.radioButton8);
            this.flowLayoutPanel5.Controls.Add(this.radioButton7);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 32);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(220, 29);
            this.flowLayoutPanel5.TabIndex = 21;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Checked = true;
            this.radioButton10.Font = new System.Drawing.Font("Bebas Neue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton10.Location = new System.Drawing.Point(3, 3);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(44, 23);
            this.radioButton10.TabIndex = 5;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Day";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("Bebas Neue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton9.Location = new System.Drawing.Point(50, 3);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(58, 23);
            this.radioButton9.TabIndex = 4;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Month";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("Bebas Neue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton8.Location = new System.Drawing.Point(111, 3);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(50, 23);
            this.radioButton8.TabIndex = 3;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Year";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("Bebas Neue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton7.Location = new System.Drawing.Point(164, 3);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(56, 23);
            this.radioButton7.TabIndex = 2;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Range";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 64);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel4.TabIndex = 20;
            // 
            // _search
            // 
            this._search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._search.Location = new System.Drawing.Point(3, 3);
            this._search.Name = "_search";
            this._search.PlaceholderText = "Search...";
            this._search.Size = new System.Drawing.Size(243, 23);
            this._search.TabIndex = 19;
            this._search.TextChanged += new System.EventHandler(this._search_TextChanged);
            this._search.KeyDown += new System.Windows.Forms.KeyEventHandler(this._search_KeyDown);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.radioButton2);
            this.flowLayoutPanel2.Controls.Add(this.radioButton3);
            this.flowLayoutPanel2.Controls.Add(this.radioButton4);
            this.flowLayoutPanel2.Controls.Add(this.radioButton5);
            this.flowLayoutPanel2.Controls.Add(this.radioButton6);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(564, 69);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(351, 29);
            this.flowLayoutPanel2.TabIndex = 18;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Bebas Neue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(308, 3);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 23);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "All";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Bebas Neue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.ForeColor = System.Drawing.Color.Maroon;
            this.radioButton3.Location = new System.Drawing.Point(228, 3);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 23);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Cancelled";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Bebas Neue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton4.ForeColor = System.Drawing.Color.SeaGreen;
            this.radioButton4.Location = new System.Drawing.Point(156, 3);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(69, 23);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Received";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Bebas Neue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.radioButton5.Location = new System.Drawing.Point(71, 3);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(82, 23);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Incomplete";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Font = new System.Drawing.Font("Bebas Neue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton6.ForeColor = System.Drawing.Color.Black;
            this.radioButton6.Location = new System.Drawing.Point(3, 3);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(65, 23);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Pending";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(30, 485);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(915, 4);
            this.flowLayoutPanel3.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(774, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Grand Total: ₱ 0.00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.Controls.Add(this.label2);
            this.flowLayoutPanel7.Controls.Add(this.label4);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(30, 416);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(915, 25);
            this.flowLayoutPanel7.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Total Qty: 0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PurchaseOrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 520);
            this.Controls.Add(this.flowLayoutPanel7);
            this.Controls.Add(this._poTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel3);
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
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DateTimePicker _fromDT;
        private Label _fromLabel;
        private Label _toLabel;
        private DateTimePicker _toDT;
        private DataGridView _poTable;
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
        private TextBox _search;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel5;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label4;
        private DataGridViewTextBoxColumn poNumCol;
        private DataGridViewTextBoxColumn dateCol;
        private DataGridViewTextBoxColumn ingCol;
        private DataGridViewTextBoxColumn supplierCol;
        private DataGridViewTextBoxColumn qtyCol;
        private DataGridViewTextBoxColumn costCol;
        private DataGridViewTextBoxColumn totalCol;
        private DataGridViewTextBoxColumn statusCol;
    }
}