namespace Lightstream.Forms
{
    partial class PurchaseOrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrderForm));
            this._add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._qty = new System.Windows.Forms.NumericUpDown();
            this._cost = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ingSearch = new System.Windows.Forms.TextBox();
            this._ingTable = new System.Windows.Forms.DataGridView();
            this.ingredientNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._supplierTable = new System.Windows.Forms.DataGridView();
            this.suppCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this._supplier = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ingTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._supplierTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _add
            // 
            this._add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._add.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._add.Location = new System.Drawing.Point(5, 122);
            this._add.Name = "_add";
            this._add.Size = new System.Drawing.Size(354, 30);
            this._add.TabIndex = 4;
            this._add.Text = "ADD";
            this._add.UseVisualStyleBackColor = false;
            this._add.Click += new System.EventHandler(this._add_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cost";
            // 
            // _qty
            // 
            this._qty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._qty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._qty.Location = new System.Drawing.Point(75, 51);
            this._qty.Margin = new System.Windows.Forms.Padding(0);
            this._qty.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this._qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._qty.Name = "_qty";
            this._qty.Size = new System.Drawing.Size(284, 29);
            this._qty.TabIndex = 2;
            this._qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _cost
            // 
            this._cost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cost.DecimalPlaces = 2;
            this._cost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._cost.Location = new System.Drawing.Point(75, 88);
            this._cost.Margin = new System.Windows.Forms.Padding(0);
            this._cost.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this._cost.Name = "_cost";
            this._cost.Size = new System.Drawing.Size(284, 29);
            this._cost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qty:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 20);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.ingSearch);
            this.splitContainer1.Panel1.Controls.Add(this._ingTable);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5, 30, 5, 5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this._supplierTable);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5, 30, 5, 5);
            this.splitContainer1.Size = new System.Drawing.Size(744, 421);
            this.splitContainer1.SplitterDistance = 366;
            this.splitContainer1.TabIndex = 2;
            // 
            // ingSearch
            // 
            this.ingSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ingSearch.Location = new System.Drawing.Point(5, 4);
            this.ingSearch.Name = "ingSearch";
            this.ingSearch.PlaceholderText = "Search Ingredient...";
            this.ingSearch.Size = new System.Drawing.Size(220, 23);
            this.ingSearch.TabIndex = 1;
            this.ingSearch.TextChanged += new System.EventHandler(this.ingSearch_TextChanged);
            this.ingSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ingSearch_KeyDown);
            // 
            // _ingTable
            // 
            this._ingTable.AllowUserToAddRows = false;
            this._ingTable.AllowUserToDeleteRows = false;
            this._ingTable.AllowUserToResizeRows = false;
            this._ingTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._ingTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this._ingTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._ingTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._ingTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._ingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._ingTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredientNameCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._ingTable.DefaultCellStyle = dataGridViewCellStyle2;
            this._ingTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ingTable.EnableHeadersVisualStyles = false;
            this._ingTable.Location = new System.Drawing.Point(5, 30);
            this._ingTable.MultiSelect = false;
            this._ingTable.Name = "_ingTable";
            this._ingTable.ReadOnly = true;
            this._ingTable.RowHeadersVisible = false;
            this._ingTable.RowTemplate.Height = 25;
            this._ingTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._ingTable.Size = new System.Drawing.Size(356, 386);
            this._ingTable.TabIndex = 0;
            this._ingTable.SelectionChanged += new System.EventHandler(this._ingTable_SelectionChanged);
            // 
            // ingredientNameCol
            // 
            this.ingredientNameCol.HeaderText = "Ingredient";
            this.ingredientNameCol.Name = "ingredientNameCol";
            this.ingredientNameCol.ReadOnly = true;
            // 
            // _supplierTable
            // 
            this._supplierTable.AllowUserToAddRows = false;
            this._supplierTable.AllowUserToDeleteRows = false;
            this._supplierTable.AllowUserToResizeRows = false;
            this._supplierTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._supplierTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this._supplierTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._supplierTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._supplierTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._supplierTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._supplierTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.suppCol,
            this.costCol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._supplierTable.DefaultCellStyle = dataGridViewCellStyle4;
            this._supplierTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._supplierTable.EnableHeadersVisualStyles = false;
            this._supplierTable.Location = new System.Drawing.Point(5, 30);
            this._supplierTable.MultiSelect = false;
            this._supplierTable.Name = "_supplierTable";
            this._supplierTable.ReadOnly = true;
            this._supplierTable.RowHeadersVisible = false;
            this._supplierTable.RowTemplate.Height = 25;
            this._supplierTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._supplierTable.Size = new System.Drawing.Size(364, 229);
            this._supplierTable.StandardTab = true;
            this._supplierTable.TabIndex = 1;
            this._supplierTable.SelectionChanged += new System.EventHandler(this._supplierTable_SelectionChanged);
            // 
            // suppCol
            // 
            this.suppCol.HeaderText = "Supplier";
            this.suppCol.Name = "suppCol";
            this.suppCol.ReadOnly = true;
            // 
            // costCol
            // 
            dataGridViewCellStyle3.Format = "₱ 0.00";
            this.costCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.costCol.HeaderText = "Cost";
            this.costCol.Name = "costCol";
            this.costCol.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._supplier);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this._add);
            this.panel1.Controls.Add(this._cost);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._qty);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 259);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(364, 157);
            this.panel1.TabIndex = 5;
            // 
            // _supplier
            // 
            this._supplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._supplier.AutoSize = true;
            this._supplier.BackColor = System.Drawing.SystemColors.Control;
            this._supplier.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._supplier.ForeColor = System.Drawing.SystemColors.Highlight;
            this._supplier.Location = new System.Drawing.Point(75, 16);
            this._supplier.Name = "_supplier";
            this._supplier.Size = new System.Drawing.Size(119, 25);
            this._supplier.TabIndex = 7;
            this._supplier.Text = "Supplier_Name";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Supplier:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(5, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Search Supplier...";
            this.textBox2.Size = new System.Drawing.Size(220, 23);
            this.textBox2.TabIndex = 2;
            // 
            // PurchaseOrderForm
            // 
            this.AcceptButton = this._add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchaseOrderForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.PurchaseOrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cost)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._ingTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._supplierTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private SplitContainer splitContainer1;
        private DataGridView _ingTable;
        private TextBox ingSearch;
        private DataGridViewTextBoxColumn ingredientNameCol;
        private DataGridView _supplierTable;
        private TextBox textBox2;
        private Label label2;
        private NumericUpDown _qty;
        private NumericUpDown _cost;
        private Label label1;
        private Button _add;
        private Panel panel1;
        private DataGridViewTextBoxColumn suppCol;
        private DataGridViewTextBoxColumn costCol;
        private Label label3;
        private Label _supplier;
    }
}