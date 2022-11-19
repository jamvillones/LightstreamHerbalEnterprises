namespace Lightstream.Forms
{
    partial class PriceManagementPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this._productsTable = new System.Windows.Forms.DataGridView();
            this.productNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._addmarkup = new System.Windows.Forms.Button();
            this._setDiscount = new System.Windows.Forms.Button();
            this._removedisc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._divider = new System.Windows.Forms.SplitContainer();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._variantsTable = new System.Windows.Forms.DataGridView();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.prodVariantDescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodVariantPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodVariantCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this._selectedProductName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this._productsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._divider)).BeginInit();
            this._divider.Panel1.SuspendLayout();
            this._divider.Panel2.SuspendLayout();
            this._divider.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._variantsTable)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _productsTable
            // 
            this._productsTable.AllowUserToAddRows = false;
            this._productsTable.AllowUserToDeleteRows = false;
            this._productsTable.AllowUserToResizeRows = false;
            this._productsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._productsTable.BackgroundColor = System.Drawing.Color.White;
            this._productsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._productsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._productsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this._productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._productsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNumCol,
            this.nameCol});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._productsTable.DefaultCellStyle = dataGridViewCellStyle21;
            this._productsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productsTable.EnableHeadersVisualStyles = false;
            this._productsTable.Location = new System.Drawing.Point(5, 51);
            this._productsTable.Margin = new System.Windows.Forms.Padding(10);
            this._productsTable.MultiSelect = false;
            this._productsTable.Name = "_productsTable";
            this._productsTable.ReadOnly = true;
            this._productsTable.RowHeadersVisible = false;
            this._productsTable.RowHeadersWidth = 62;
            this._productsTable.RowTemplate.Height = 25;
            this._productsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._productsTable.Size = new System.Drawing.Size(275, 317);
            this._productsTable.StandardTab = true;
            this._productsTable.TabIndex = 9;
            this._productsTable.SelectionChanged += new System.EventHandler(this._productsTable_SelectionChanged);
            // 
            // productNumCol
            // 
            this.productNumCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle20.NullValue = "--";
            this.productNumCol.DefaultCellStyle = dataGridViewCellStyle20;
            this.productNumCol.HeaderText = "Product Number";
            this.productNumCol.MinimumWidth = 130;
            this.productNumCol.Name = "productNumCol";
            this.productNumCol.ReadOnly = true;
            this.productNumCol.Width = 130;
            // 
            // nameCol
            // 
            this.nameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameCol.HeaderText = "Name";
            this.nameCol.MinimumWidth = 8;
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            // 
            // _addmarkup
            // 
            this._addmarkup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._addmarkup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._addmarkup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addmarkup.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._addmarkup.ForeColor = System.Drawing.Color.Black;
            this._addmarkup.Location = new System.Drawing.Point(0, 0);
            this._addmarkup.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._addmarkup.Name = "_addmarkup";
            this._addmarkup.Size = new System.Drawing.Size(140, 40);
            this._addmarkup.TabIndex = 2;
            this._addmarkup.Text = "Set Markup";
            this._addmarkup.UseVisualStyleBackColor = false;
            this._addmarkup.Click += new System.EventHandler(this._addmarkup_Click);
            // 
            // _setDiscount
            // 
            this._setDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._setDiscount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._setDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._setDiscount.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._setDiscount.ForeColor = System.Drawing.Color.Black;
            this._setDiscount.Location = new System.Drawing.Point(145, 0);
            this._setDiscount.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._setDiscount.Name = "_setDiscount";
            this._setDiscount.Size = new System.Drawing.Size(140, 40);
            this._setDiscount.TabIndex = 3;
            this._setDiscount.Text = "Set Discount";
            this._setDiscount.UseVisualStyleBackColor = false;
            this._setDiscount.Click += new System.EventHandler(this._setDiscount_Click);
            // 
            // _removedisc
            // 
            this._removedisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._removedisc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._removedisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._removedisc.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._removedisc.ForeColor = System.Drawing.Color.Black;
            this._removedisc.Location = new System.Drawing.Point(290, 0);
            this._removedisc.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._removedisc.Name = "_removedisc";
            this._removedisc.Size = new System.Drawing.Size(140, 40);
            this._removedisc.TabIndex = 4;
            this._removedisc.Text = "Remove Discount";
            this._removedisc.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Price Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _divider
            // 
            this._divider.Dock = System.Windows.Forms.DockStyle.Fill;
            this._divider.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._divider.Location = new System.Drawing.Point(30, 30);
            this._divider.Margin = new System.Windows.Forms.Padding(2);
            this._divider.Name = "_divider";
            // 
            // _divider.Panel1
            // 
            this._divider.Panel1.Controls.Add(this._productsTable);
            this._divider.Panel1.Controls.Add(this.searchTxt);
            this._divider.Panel1.Controls.Add(this.label3);
            this._divider.Panel1.Padding = new System.Windows.Forms.Padding(5);
            this._divider.Panel1MinSize = 200;
            // 
            // _divider.Panel2
            // 
            this._divider.Panel2.Controls.Add(this.panel1);
            this._divider.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this._divider.Size = new System.Drawing.Size(740, 373);
            this._divider.SplitterDistance = 285;
            this._divider.SplitterWidth = 7;
            this._divider.TabIndex = 10;
            // 
            // searchTxt
            // 
            this.searchTxt.AcceptsReturn = true;
            this.searchTxt.BackColor = System.Drawing.Color.White;
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchTxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTxt.Location = new System.Drawing.Point(5, 25);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.PlaceholderText = "Search...";
            this.searchTxt.Size = new System.Drawing.Size(275, 26);
            this.searchTxt.TabIndex = 17;
            this.searchTxt.TextChanged += new System.EventHandler(this._search_TextChanged);
            this.searchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this._search_KeyDown);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Products";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._variantsTable);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this._selectedProductName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 363);
            this.panel1.TabIndex = 0;
            // 
            // _variantsTable
            // 
            this._variantsTable.AllowUserToAddRows = false;
            this._variantsTable.AllowUserToDeleteRows = false;
            this._variantsTable.AllowUserToResizeRows = false;
            this._variantsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._variantsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this._variantsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._variantsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._variantsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this._variantsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._variantsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.editCol,
            this.delCol,
            this.prodVariantDescriptionCol,
            this.amountCol,
            this.prodVariantPrice,
            this.prodVariantCost});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._variantsTable.DefaultCellStyle = dataGridViewCellStyle27;
            this._variantsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._variantsTable.EnableHeadersVisualStyles = false;
            this._variantsTable.Location = new System.Drawing.Point(0, 46);
            this._variantsTable.Margin = new System.Windows.Forms.Padding(1);
            this._variantsTable.MultiSelect = false;
            this._variantsTable.Name = "_variantsTable";
            this._variantsTable.ReadOnly = true;
            this._variantsTable.RowHeadersVisible = false;
            this._variantsTable.RowHeadersWidth = 62;
            this._variantsTable.RowTemplate.Height = 25;
            this._variantsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._variantsTable.Size = new System.Drawing.Size(438, 287);
            this._variantsTable.StandardTab = true;
            this._variantsTable.TabIndex = 1;
            this._variantsTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._variants_CellMouseClick);
            this._variantsTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this._variantsTable_RowsAdded);
            // 
            // idCol
            // 
            this.idCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idCol.HeaderText = "Id";
            this.idCol.MinimumWidth = 8;
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            // 
            // editCol
            // 
            this.editCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.DarkBlue;
            this.editCol.DefaultCellStyle = dataGridViewCellStyle23;
            this.editCol.HeaderText = "";
            this.editCol.MinimumWidth = 60;
            this.editCol.Name = "editCol";
            this.editCol.ReadOnly = true;
            this.editCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editCol.Text = "EDIT";
            this.editCol.UseColumnTextForButtonValue = true;
            this.editCol.Width = 60;
            // 
            // delCol
            // 
            this.delCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Maroon;
            this.delCol.DefaultCellStyle = dataGridViewCellStyle24;
            this.delCol.HeaderText = "";
            this.delCol.MinimumWidth = 70;
            this.delCol.Name = "delCol";
            this.delCol.ReadOnly = true;
            this.delCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delCol.Text = "REMOVE";
            this.delCol.UseColumnTextForButtonValue = true;
            this.delCol.Width = 70;
            // 
            // prodVariantDescriptionCol
            // 
            this.prodVariantDescriptionCol.HeaderText = "Description";
            this.prodVariantDescriptionCol.MinimumWidth = 8;
            this.prodVariantDescriptionCol.Name = "prodVariantDescriptionCol";
            this.prodVariantDescriptionCol.ReadOnly = true;
            // 
            // amountCol
            // 
            this.amountCol.HeaderText = "Required  Amount";
            this.amountCol.Name = "amountCol";
            this.amountCol.ReadOnly = true;
            // 
            // prodVariantPrice
            // 
            dataGridViewCellStyle25.Format = "₱ #,##.00";
            this.prodVariantPrice.DefaultCellStyle = dataGridViewCellStyle25;
            this.prodVariantPrice.HeaderText = "Price";
            this.prodVariantPrice.MinimumWidth = 8;
            this.prodVariantPrice.Name = "prodVariantPrice";
            this.prodVariantPrice.ReadOnly = true;
            // 
            // prodVariantCost
            // 
            this.prodVariantCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle26.Format = "₱ #,##.00";
            this.prodVariantCost.DefaultCellStyle = dataGridViewCellStyle26;
            this.prodVariantCost.HeaderText = "Cost";
            this.prodVariantCost.MinimumWidth = 8;
            this.prodVariantCost.Name = "prodVariantCost";
            this.prodVariantCost.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 333);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(438, 30);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(161)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(161)))));
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(145, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "Save Changes";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // _selectedProductName
            // 
            this._selectedProductName.Dock = System.Windows.Forms.DockStyle.Top;
            this._selectedProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._selectedProductName.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._selectedProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this._selectedProductName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._selectedProductName.Location = new System.Drawing.Point(0, 20);
            this._selectedProductName.Name = "_selectedProductName";
            this._selectedProductName.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this._selectedProductName.Size = new System.Drawing.Size(438, 26);
            this._selectedProductName.TabIndex = 10;
            this._selectedProductName.Text = "Product_Name";
            this._selectedProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product Variants";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this._addmarkup);
            this.flowLayoutPanel2.Controls.Add(this._setDiscount);
            this.flowLayoutPanel2.Controls.Add(this._removedisc);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(30, 403);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(740, 40);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // PriceManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this._divider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PriceManagementPage";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Price Management";
            this.Load += new System.EventHandler(this.PriceManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._productsTable)).EndInit();
            this._divider.Panel1.ResumeLayout(false);
            this._divider.Panel1.PerformLayout();
            this._divider.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._divider)).EndInit();
            this._divider.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._variantsTable)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView _productsTable;
        private Button _addmarkup;
        private Button _setDiscount;
        private Button _removedisc;
        private Label label1;
        private SplitContainer _divider;
        private Panel panel1;
        private DataGridView _variantsTable;
        private Label label2;
        private Label label3;
        private Label _selectedProductName;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button4;
        private FlowLayoutPanel flowLayoutPanel2;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewButtonColumn editCol;
        private DataGridViewButtonColumn delCol;
        private DataGridViewTextBoxColumn prodVariantDescriptionCol;
        private DataGridViewTextBoxColumn amountCol;
        private DataGridViewTextBoxColumn prodVariantPrice;
        private DataGridViewTextBoxColumn prodVariantCost;
        private DataGridViewTextBoxColumn productNumCol;
        private DataGridViewTextBoxColumn nameCol;
        private TextBox searchTxt;
    }
}