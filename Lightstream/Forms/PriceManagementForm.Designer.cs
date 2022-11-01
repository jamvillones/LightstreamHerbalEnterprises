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
            ((System.ComponentModel.ISupportInitialize)(this._productsTable)).BeginInit();
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
            this._productsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._productsTable.BackgroundColor = System.Drawing.Color.White;
            this._productsTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._productsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._productsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNumCol,
            this.nameCol,
            this.costCol,
            this.discountCol});
            this._productsTable.EnableHeadersVisualStyles = false;
            this._productsTable.Location = new System.Drawing.Point(22, 62);
            this._productsTable.Margin = new System.Windows.Forms.Padding(10);
            this._productsTable.MultiSelect = false;
            this._productsTable.Name = "_productsTable";
            this._productsTable.ReadOnly = true;
            this._productsTable.RowHeadersVisible = false;
            this._productsTable.RowTemplate.Height = 25;
            this._productsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._productsTable.Size = new System.Drawing.Size(509, 372);
            this._productsTable.StandardTab = true;
            this._productsTable.TabIndex = 9;
            // 
            // productNumCol
            // 
            this.productNumCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productNumCol.HeaderText = "Product Number";
            this.productNumCol.Name = "productNumCol";
            this.productNumCol.ReadOnly = true;
            this.productNumCol.Width = 357;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            // 
            // costCol
            // 
            this.costCol.HeaderText = "Cost";
            this.costCol.Name = "costCol";
            this.costCol.ReadOnly = true;
            // 
            // discountCol
            // 
            this.discountCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.discountCol.HeaderText = "Discount";
            this.discountCol.Name = "discountCol";
            this.discountCol.ReadOnly = true;
            // 
            // _addmarkup
            // 
            this._addmarkup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._addmarkup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._addmarkup.Location = new System.Drawing.Point(257, 447);
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
            this._setDiscount.Location = new System.Drawing.Point(403, 447);
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
            this._removedisc.Location = new System.Drawing.Point(549, 447);
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
            this.label1.Size = new System.Drawing.Size(660, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Price Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._removedisc);
            this.Controls.Add(this._setDiscount);
            this.Controls.Add(this._addmarkup);
            this.Controls.Add(this._productsTable);
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
    }
}