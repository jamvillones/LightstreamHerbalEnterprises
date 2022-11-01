namespace Lightstream.Forms
{
    partial class PriceManagementForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this._search = new System.Windows.Forms.TextBox();
            this._productsTable = new System.Windows.Forms.DataGridView();
            this.productNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._addmarkup = new System.Windows.Forms.Button();
            this._setDiscount = new System.Windows.Forms.Button();
            this._removedisc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._divider = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this._variantsTable = new System.Windows.Forms.DataGridView();
            this.prodVariantDescriptionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodVariantPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodVariantCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this._selectedProductName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._productsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._divider)).BeginInit();
            this._divider.Panel1.SuspendLayout();
            this._divider.Panel2.SuspendLayout();
            this._divider.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._variantsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // _search
            // 
            this._search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._search.Location = new System.Drawing.Point(26, 41);
            this._search.Name = "_search";
            this._search.PlaceholderText = "Search...";
            this._search.Size = new System.Drawing.Size(269, 16);
            this._search.TabIndex = 0;
            this._search.TextChanged += new System.EventHandler(this._search_TextChanged);
            this._search.KeyDown += new System.Windows.Forms.KeyEventHandler(this._search_KeyDown);
            // 
            // _productsTable
            // 
            this._productsTable.AllowUserToAddRows = false;
            this._productsTable.AllowUserToDeleteRows = false;
            this._productsTable.AllowUserToResizeRows = false;
            this._productsTable.BackgroundColor = System.Drawing.Color.White;
            this._productsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._productsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._productsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNumCol,
            this.nameCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._productsTable.DefaultCellStyle = dataGridViewCellStyle2;
            this._productsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productsTable.EnableHeadersVisualStyles = false;
            this._productsTable.Location = new System.Drawing.Point(4, 23);
            this._productsTable.Margin = new System.Windows.Forms.Padding(10);
            this._productsTable.MultiSelect = false;
            this._productsTable.Name = "_productsTable";
            this._productsTable.ReadOnly = true;
            this._productsTable.RowHeadersVisible = false;
            this._productsTable.RowHeadersWidth = 62;
            this._productsTable.RowTemplate.Height = 25;
            this._productsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._productsTable.Size = new System.Drawing.Size(277, 315);
            this._productsTable.StandardTab = true;
            this._productsTable.TabIndex = 9;
            this._productsTable.SelectionChanged += new System.EventHandler(this._productsTable_SelectionChanged);
            // 
            // productNumCol
            // 
            this.productNumCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productNumCol.HeaderText = "Product Number";
            this.productNumCol.MinimumWidth = 8;
            this.productNumCol.Name = "productNumCol";
            this.productNumCol.ReadOnly = true;
            this.productNumCol.Width = 150;
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
            this._addmarkup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addmarkup.Location = new System.Drawing.Point(289, 420);
            this._addmarkup.Name = "_addmarkup";
            this._addmarkup.Size = new System.Drawing.Size(125, 30);
            this._addmarkup.TabIndex = 2;
            this._addmarkup.Text = "Add MarkUp";
            this._addmarkup.UseVisualStyleBackColor = true;
            // 
            // _setDiscount
            // 
            this._setDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._setDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._setDiscount.Location = new System.Drawing.Point(416, 420);
            this._setDiscount.Name = "_setDiscount";
            this._setDiscount.Size = new System.Drawing.Size(128, 30);
            this._setDiscount.TabIndex = 3;
            this._setDiscount.Text = "Set Discount";
            this._setDiscount.UseVisualStyleBackColor = true;
            // 
            // _removedisc
            // 
            this._removedisc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._removedisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._removedisc.Location = new System.Drawing.Point(546, 420);
            this._removedisc.Name = "_removedisc";
            this._removedisc.Size = new System.Drawing.Size(128, 30);
            this._removedisc.TabIndex = 4;
            this._removedisc.Text = "Remove Discount";
            this._removedisc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(660, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Price Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _divider
            // 
            this._divider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._divider.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._divider.Location = new System.Drawing.Point(20, 74);
            this._divider.Margin = new System.Windows.Forms.Padding(2);
            this._divider.Name = "_divider";
            // 
            // _divider.Panel1
            // 
            this._divider.Panel1.Controls.Add(this._productsTable);
            this._divider.Panel1.Controls.Add(this.label3);
            this._divider.Panel1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._divider.Panel1MinSize = 200;
            // 
            // _divider.Panel2
            // 
            this._divider.Panel2.Controls.Add(this.panel1);
            this._divider.Panel2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._divider.Size = new System.Drawing.Size(657, 341);
            this._divider.SplitterDistance = 285;
            this._divider.SplitterWidth = 3;
            this._divider.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Products";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._variantsTable);
            this.panel1.Controls.Add(this._selectedProductName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 335);
            this.panel1.TabIndex = 0;
            // 
            // _variantsTable
            // 
            this._variantsTable.AllowUserToAddRows = false;
            this._variantsTable.AllowUserToDeleteRows = false;
            this._variantsTable.AllowUserToResizeRows = false;
            this._variantsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(237)))));
            this._variantsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._variantsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._variantsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._variantsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodVariantDescriptionCol,
            this.prodVariantPrice,
            this.prodVariantCost,
            this.Column1,
            this.delCol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._variantsTable.DefaultCellStyle = dataGridViewCellStyle4;
            this._variantsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._variantsTable.EnableHeadersVisualStyles = false;
            this._variantsTable.Location = new System.Drawing.Point(0, 40);
            this._variantsTable.Margin = new System.Windows.Forms.Padding(2);
            this._variantsTable.MultiSelect = false;
            this._variantsTable.Name = "_variantsTable";
            this._variantsTable.ReadOnly = true;
            this._variantsTable.RowHeadersVisible = false;
            this._variantsTable.RowHeadersWidth = 62;
            this._variantsTable.RowTemplate.Height = 33;
            this._variantsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._variantsTable.Size = new System.Drawing.Size(361, 295);
            this._variantsTable.TabIndex = 1;
            this._variantsTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._variants_CellMouseClick);
            // 
            // prodVariantDescriptionCol
            // 
            this.prodVariantDescriptionCol.HeaderText = "Description";
            this.prodVariantDescriptionCol.Name = "prodVariantDescriptionCol";
            this.prodVariantDescriptionCol.ReadOnly = true;
            // 
            // prodVariantPrice
            // 
            this.prodVariantPrice.HeaderText = "Price";
            this.prodVariantPrice.Name = "prodVariantPrice";
            this.prodVariantPrice.ReadOnly = true;
            // 
            // prodVariantCost
            // 
            this.prodVariantCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodVariantCost.HeaderText = "Cost";
            this.prodVariantCost.Name = "prodVariantCost";
            this.prodVariantCost.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Edit";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 60;
            // 
            // delCol
            // 
            this.delCol.HeaderText = "";
            this.delCol.Name = "delCol";
            this.delCol.ReadOnly = true;
            this.delCol.Text = "Delete";
            this.delCol.UseColumnTextForButtonValue = true;
            this.delCol.Width = 60;
            // 
            // _selectedProductName
            // 
            this._selectedProductName.Dock = System.Windows.Forms.DockStyle.Top;
            this._selectedProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._selectedProductName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._selectedProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this._selectedProductName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._selectedProductName.Location = new System.Drawing.Point(0, 20);
            this._selectedProductName.Name = "_selectedProductName";
            this._selectedProductName.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this._selectedProductName.Size = new System.Drawing.Size(361, 20);
            this._selectedProductName.TabIndex = 10;
            this._selectedProductName.Text = "Product_Name";
            this._selectedProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product Variants";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 473);
            this.Controls.Add(this._divider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._removedisc);
            this.Controls.Add(this._setDiscount);
            this.Controls.Add(this._addmarkup);
            this.Controls.Add(this._search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PriceManagementForm";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Price Management";
            this.Load += new System.EventHandler(this.PriceManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._productsTable)).EndInit();
            this._divider.Panel1.ResumeLayout(false);
            this._divider.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._divider)).EndInit();
            this._divider.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._variantsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox _search;
        private DataGridView _productsTable;
        private Button _addmarkup;
        private Button _setDiscount;
        private Button _removedisc;
        private Label label1;
        private SplitContainer _divider;
        private Panel panel1;
        private DataGridView _variantsTable;
        private DataGridViewTextBoxColumn prodVariantDescriptionCol;
        private DataGridViewTextBoxColumn prodVariantPrice;
        private DataGridViewTextBoxColumn prodVariantCost;
        private DataGridViewButtonColumn Column1;
        private DataGridViewButtonColumn delCol;
        private Label label2;
        private Label label3;
        private Label _selectedProductName;
        private DataGridViewTextBoxColumn productNumCol;
        private DataGridViewTextBoxColumn nameCol;
    }
}