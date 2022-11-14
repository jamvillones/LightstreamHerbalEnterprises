namespace Lightstream.Usercontrols
{
    partial class ProductsPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this._prodTable = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this._barcode = new System.Windows.Forms.TextBox();
            this._unitOption = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._recipe = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this._addRecipe = new System.Windows.Forms.Button();
            this._removeRecipe = new System.Windows.Forms.Button();
            this._description = new System.Windows.Forms.TextBox();
            this._cancel = new System.Windows.Forms.Button();
            this._save = new System.Windows.Forms.Button();
            this._productName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._archive_retrieve = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._prodTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _prodTable
            // 
            this._prodTable.AllowUserToAddRows = false;
            this._prodTable.AllowUserToDeleteRows = false;
            this._prodTable.AllowUserToResizeRows = false;
            this._prodTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._prodTable.BackgroundColor = System.Drawing.Color.White;
            this._prodTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._prodTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._prodTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._prodTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._prodTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.editCol,
            this.delCol,
            this.nameCol,
            this.barcodeCol,
            this.descCol,
            this.unitCol,
            this.ingCol,
            this.statusCol});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._prodTable.DefaultCellStyle = dataGridViewCellStyle6;
            this._prodTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._prodTable.EnableHeadersVisualStyles = false;
            this._prodTable.Location = new System.Drawing.Point(0, 0);
            this._prodTable.Margin = new System.Windows.Forms.Padding(10);
            this._prodTable.MultiSelect = false;
            this._prodTable.Name = "_prodTable";
            this._prodTable.ReadOnly = true;
            this._prodTable.RowHeadersVisible = false;
            this._prodTable.RowHeadersWidth = 62;
            this._prodTable.RowTemplate.Height = 25;
            this._prodTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._prodTable.Size = new System.Drawing.Size(740, 313);
            this._prodTable.StandardTab = true;
            this._prodTable.TabIndex = 9;
            this._prodTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._prodTable_CellMouseClick);
            this._prodTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._prodTable_CellMouseDoubleClick);
            this._prodTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this._prodTable_RowsAdded);
            this._prodTable.SelectionChanged += new System.EventHandler(this._prodTable_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(4, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Product Number:";
            // 
            // _barcode
            // 
            this._barcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._barcode.BackColor = System.Drawing.SystemColors.Control;
            this._barcode.Location = new System.Drawing.Point(107, 43);
            this._barcode.Name = "_barcode";
            this._barcode.PlaceholderText = "optional...";
            this._barcode.Size = new System.Drawing.Size(190, 23);
            this._barcode.TabIndex = 1;
            // 
            // _unitOption
            // 
            this._unitOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._unitOption.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this._unitOption.BackColor = System.Drawing.SystemColors.Control;
            this._unitOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._unitOption.Location = new System.Drawing.Point(107, 105);
            this._unitOption.Name = "_unitOption";
            this._unitOption.Size = new System.Drawing.Size(190, 23);
            this._unitOption.TabIndex = 3;
            this._unitOption.Validated += new System.EventHandler(this._unitOption_Validated);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._recipe);
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.groupBox1.Size = new System.Drawing.Size(435, 170);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Required Ingredient/s";
            // 
            // _recipe
            // 
            this._recipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._recipe.DisplayMember = "DisplayMember";
            this._recipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this._recipe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._recipe.FormattingEnabled = true;
            this._recipe.ItemHeight = 15;
            this._recipe.Location = new System.Drawing.Point(6, 60);
            this._recipe.Margin = new System.Windows.Forms.Padding(5);
            this._recipe.Name = "_recipe";
            this._recipe.Size = new System.Drawing.Size(423, 107);
            this._recipe.TabIndex = 1;
            this._recipe.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this._addRecipe);
            this.flowLayoutPanel2.Controls.Add(this._removeRecipe);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 24);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(423, 36);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // _addRecipe
            // 
            this._addRecipe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._addRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addRecipe.Font = new System.Drawing.Font("Bebas Neue", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._addRecipe.Location = new System.Drawing.Point(3, 3);
            this._addRecipe.Name = "_addRecipe";
            this._addRecipe.Size = new System.Drawing.Size(140, 30);
            this._addRecipe.TabIndex = 0;
            this._addRecipe.Text = "Add";
            this._addRecipe.UseVisualStyleBackColor = false;
            this._addRecipe.Click += new System.EventHandler(this._addIngredients_Click);
            // 
            // _removeRecipe
            // 
            this._removeRecipe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._removeRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._removeRecipe.Font = new System.Drawing.Font("Bebas Neue", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._removeRecipe.Location = new System.Drawing.Point(149, 3);
            this._removeRecipe.Name = "_removeRecipe";
            this._removeRecipe.Size = new System.Drawing.Size(140, 30);
            this._removeRecipe.TabIndex = 1;
            this._removeRecipe.Text = "remove";
            this._removeRecipe.UseVisualStyleBackColor = false;
            this._removeRecipe.Click += new System.EventHandler(this._removeRecipe_Click);
            // 
            // _description
            // 
            this._description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._description.BackColor = System.Drawing.SystemColors.Control;
            this._description.Location = new System.Drawing.Point(107, 74);
            this._description.Name = "_description";
            this._description.PlaceholderText = "optional...";
            this._description.Size = new System.Drawing.Size(190, 23);
            this._description.TabIndex = 2;
            this._description.TextChanged += new System.EventHandler(this.fields_TextChanged);
            // 
            // _cancel
            // 
            this._cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._cancel.Enabled = false;
            this._cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancel.Font = new System.Drawing.Font("Bebas Neue", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cancel.ForeColor = System.Drawing.Color.Black;
            this._cancel.Location = new System.Drawing.Point(146, 137);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(140, 30);
            this._cancel.TabIndex = 6;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = false;
            this._cancel.Click += new System.EventHandler(this._cancel_Click);
            // 
            // _save
            // 
            this._save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._save.Font = new System.Drawing.Font("Bebas Neue", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._save.ForeColor = System.Drawing.Color.Black;
            this._save.Location = new System.Drawing.Point(0, 137);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(140, 30);
            this._save.TabIndex = 5;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = false;
            this._save.Click += new System.EventHandler(this._save_Click);
            // 
            // _productName
            // 
            this._productName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._productName.BackColor = System.Drawing.SystemColors.Control;
            this._productName.Location = new System.Drawing.Point(107, 12);
            this._productName.Name = "_productName";
            this._productName.PlaceholderText = "required...";
            this._productName.Size = new System.Drawing.Size(190, 23);
            this._productName.TabIndex = 0;
            this._productName.TextChanged += new System.EventHandler(this.fields_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(71, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "UNIT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "DESCRIPTION:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "PRODUCT NAME:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(740, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._prodTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(30, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 313);
            this.panel3.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(30, 30);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(740, 170);
            this.panel4.TabIndex = 25;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this._save);
            this.splitContainer1.Panel1.Controls.Add(this._description);
            this.splitContainer1.Panel1.Controls.Add(this._cancel);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this._unitOption);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this._productName);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this._barcode);
            this.splitContainer1.Panel1MinSize = 300;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new System.Drawing.Size(740, 170);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.searchTxt);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.radioButton1);
            this.panel5.Controls.Add(this.radioButton2);
            this.panel5.Controls.Add(this.radioButton3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel5.Location = new System.Drawing.Point(30, 200);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(740, 45);
            this.panel5.TabIndex = 28;
            // 
            // searchTxt
            // 
            this.searchTxt.AcceptsReturn = true;
            this.searchTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTxt.Location = new System.Drawing.Point(0, 13);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.PlaceholderText = "Search...";
            this.searchTxt.Size = new System.Drawing.Size(260, 18);
            this.searchTxt.TabIndex = 2;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            this.searchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTxt_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(273, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(2);
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Filter:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(328, 10);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 25);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Active";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton2.Location = new System.Drawing.Point(395, 10);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 25);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "Inactive";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(472, 10);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 25);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.Text = "All";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this._archive_retrieve);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 558);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(740, 40);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // _archive_retrieve
            // 
            this._archive_retrieve.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._archive_retrieve.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._archive_retrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._archive_retrieve.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._archive_retrieve.ForeColor = System.Drawing.Color.Black;
            this._archive_retrieve.Location = new System.Drawing.Point(0, 0);
            this._archive_retrieve.Margin = new System.Windows.Forms.Padding(0);
            this._archive_retrieve.Name = "_archive_retrieve";
            this._archive_retrieve.Size = new System.Drawing.Size(140, 40);
            this._archive_retrieve.TabIndex = 7;
            this._archive_retrieve.Text = "Archive";
            this._archive_retrieve.UseVisualStyleBackColor = false;
            this._archive_retrieve.Click += new System.EventHandler(this._archive_retrieve_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 26;
            // 
            // editCol
            // 
            this.editCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            this.editCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.editCol.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editCol.HeaderText = "";
            this.editCol.MinimumWidth = 60;
            this.editCol.Name = "editCol";
            this.editCol.ReadOnly = true;
            this.editCol.Text = "EDIT";
            this.editCol.UseColumnTextForButtonValue = true;
            this.editCol.Width = 60;
            // 
            // delCol
            // 
            this.delCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.delCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.delCol.HeaderText = "";
            this.delCol.MinimumWidth = 60;
            this.delCol.Name = "delCol";
            this.delCol.ReadOnly = true;
            this.delCol.Text = "VIEW";
            this.delCol.ToolTipText = "VIEW STOCK";
            this.delCol.UseColumnTextForButtonValue = true;
            this.delCol.Width = 60;
            // 
            // nameCol
            // 
            this.nameCol.DataPropertyName = "ProductName";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.nameCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.nameCol.HeaderText = "NAME";
            this.nameCol.MinimumWidth = 8;
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            // 
            // barcodeCol
            // 
            dataGridViewCellStyle5.NullValue = "*not set";
            this.barcodeCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.barcodeCol.HeaderText = "PRODUCT NUMBER";
            this.barcodeCol.MinimumWidth = 130;
            this.barcodeCol.Name = "barcodeCol";
            this.barcodeCol.ReadOnly = true;
            // 
            // descCol
            // 
            this.descCol.DataPropertyName = "Description";
            this.descCol.HeaderText = "DESCRIPTION";
            this.descCol.MinimumWidth = 8;
            this.descCol.Name = "descCol";
            this.descCol.ReadOnly = true;
            // 
            // unitCol
            // 
            this.unitCol.HeaderText = "UNIT";
            this.unitCol.MinimumWidth = 20;
            this.unitCol.Name = "unitCol";
            this.unitCol.ReadOnly = true;
            // 
            // ingCol
            // 
            this.ingCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ingCol.HeaderText = "INGREDIENT/S";
            this.ingCol.MinimumWidth = 8;
            this.ingCol.Name = "ingCol";
            this.ingCol.ReadOnly = true;
            // 
            // statusCol
            // 
            this.statusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.statusCol.HeaderText = "Status";
            this.statusCol.Name = "statusCol";
            this.statusCol.ReadOnly = true;
            this.statusCol.Width = 69;
            // 
            // ProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductsPage";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ProductsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this._prodTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView _prodTable;
        private Label label1;
        private Button _cancel;
        private Button _save;
        private Button _addRecipe;
        private TextBox _description;
        private TextBox _productName;
        private Label label4;
        private Label label3;
        private Label label2;
        private ListBox _recipe;
        private GroupBox groupBox1;
        private ComboBox _unitOption;
        private Label label5;
        private TextBox _barcode;
        private Button _removeRecipe;
        private Panel panel3;
        private Panel panel4;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel panel5;
        private TextBox searchTxt;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button _archive_retrieve;
        private FlowLayoutPanel flowLayoutPanel2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewButtonColumn editCol;
        private DataGridViewButtonColumn delCol;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn barcodeCol;
        private DataGridViewTextBoxColumn descCol;
        private DataGridViewTextBoxColumn unitCol;
        private DataGridViewTextBoxColumn ingCol;
        private DataGridViewTextBoxColumn statusCol;
    }
}
