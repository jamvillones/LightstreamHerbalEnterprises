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
            this._search = new System.Windows.Forms.TextBox();
            this._productsTable = new System.Windows.Forms.DataGridView();
            this.productNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._addmarkup = new System.Windows.Forms.Button();
            this._setDiscount = new System.Windows.Forms.Button();
            this._removedisc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this._variants = new System.Windows.Forms.DataGridView();
            this._Load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._productsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._variants)).BeginInit();
            this.SuspendLayout();
            // 
            // _search
            // 
            this._search.Location = new System.Drawing.Point(20, 26);
            this._search.Name = "_search";
            this._search.Size = new System.Drawing.Size(254, 23);
            this._search.TabIndex = 0;
            this._search.Text = "Search...";
            // 
            // _productsTable
            // 
            this._productsTable.AllowUserToAddRows = false;
            this._productsTable.AllowUserToDeleteRows = false;
            this._productsTable.AllowUserToResizeRows = false;
            this._productsTable.BackgroundColor = System.Drawing.Color.White;
            this._productsTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._productsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._productsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNumCol,
            this.nameCol,
            this.costCol,
            this.discountCol});
            this._productsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._productsTable.EnableHeadersVisualStyles = false;
            this._productsTable.Location = new System.Drawing.Point(4, 3);
            this._productsTable.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this._productsTable.MultiSelect = false;
            this._productsTable.Name = "_productsTable";
            this._productsTable.ReadOnly = true;
            this._productsTable.RowHeadersVisible = false;
            this._productsTable.RowHeadersWidth = 62;
            this._productsTable.RowTemplate.Height = 25;
            this._productsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._productsTable.Size = new System.Drawing.Size(201, 340);
            this._productsTable.StandardTab = true;
            this._productsTable.TabIndex = 9;
            // 
            // productNumCol
            // 
            this.productNumCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productNumCol.HeaderText = "Product Number";
            this.productNumCol.MinimumWidth = 8;
            this.productNumCol.Name = "productNumCol";
            this.productNumCol.ReadOnly = true;
            this.productNumCol.Width = 357;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.MinimumWidth = 8;
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            this.nameCol.Width = 150;
            // 
            // costCol
            // 
            this.costCol.HeaderText = "Cost";
            this.costCol.MinimumWidth = 8;
            this.costCol.Name = "costCol";
            this.costCol.ReadOnly = true;
            this.costCol.Width = 150;
            // 
            // discountCol
            // 
            this.discountCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.discountCol.HeaderText = "Discount";
            this.discountCol.MinimumWidth = 8;
            this.discountCol.Name = "discountCol";
            this.discountCol.ReadOnly = true;
            // 
            // _addmarkup
            // 
            this._addmarkup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._addmarkup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addmarkup.Location = new System.Drawing.Point(205, 433);
            this._addmarkup.Name = "_addmarkup";
            this._addmarkup.Size = new System.Drawing.Size(128, 30);
            this._addmarkup.TabIndex = 2;
            this._addmarkup.Text = "Add MarkUp";
            this._addmarkup.UseVisualStyleBackColor = true;
            // 
            // _setDiscount
            // 
            this._setDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._setDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._setDiscount.Location = new System.Drawing.Point(351, 433);
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
            this._removedisc.Location = new System.Drawing.Point(497, 433);
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
            this.label1.Size = new System.Drawing.Size(608, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Price Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(20, 74);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._productsTable);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Size = new System.Drawing.Size(605, 346);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this._variants);
            this.panel1.Controls.Add(this._Load);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 340);
            this.panel1.TabIndex = 0;
            // 
            // _variants
            // 
            this._variants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._variants.Dock = System.Windows.Forms.DockStyle.Fill;
            this._variants.Location = new System.Drawing.Point(0, 0);
            this._variants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._variants.Name = "_variants";
            this._variants.RowHeadersWidth = 62;
            this._variants.RowTemplate.Height = 33;
            this._variants.Size = new System.Drawing.Size(383, 318);
            this._variants.TabIndex = 1;
            // 
            // _Load
            // 
            this._Load.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._Load.Location = new System.Drawing.Point(0, 318);
            this._Load.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._Load.Name = "_Load";
            this._Load.Size = new System.Drawing.Size(383, 20);
            this._Load.TabIndex = 0;
            this._Load.Text = "Load";
            this._Load.UseVisualStyleBackColor = true;
            // 
            // PriceManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 459);
            this.Controls.Add(this.splitContainer1);
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._variants)).EndInit();
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
        private DataGridViewTextBoxColumn productNumCol;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn costCol;
        private DataGridViewTextBoxColumn discountCol;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private DataGridView _variants;
        private Button _Load;
    }
}