namespace Lightstream.Forms
{
    partial class PriceMangmtForm
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
            this._PMTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._addmarkup = new System.Windows.Forms.Button();
            this._setDiscount = new System.Windows.Forms.Button();
            this._removedisc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._PMTable)).BeginInit();
            this.SuspendLayout();
            // 
            // _search
            // 
            this._search.Location = new System.Drawing.Point(22, 59);
            this._search.Name = "_search";
            this._search.Size = new System.Drawing.Size(254, 23);
            this._search.TabIndex = 0;
            this._search.Text = "Search...";
            // 
            // _PMTable
            // 
            this._PMTable.AllowUserToAddRows = false;
            this._PMTable.AllowUserToDeleteRows = false;
            this._PMTable.AllowUserToResizeRows = false;
            this._PMTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._PMTable.BackgroundColor = System.Drawing.Color.White;
            this._PMTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._PMTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._PMTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._PMTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this._PMTable.EnableHeadersVisualStyles = false;
            this._PMTable.Location = new System.Drawing.Point(22, 111);
            this._PMTable.Margin = new System.Windows.Forms.Padding(10);
            this._PMTable.MultiSelect = false;
            this._PMTable.Name = "_PMTable";
            this._PMTable.ReadOnly = true;
            this._PMTable.RowHeadersVisible = false;
            this._PMTable.RowTemplate.Height = 25;
            this._PMTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._PMTable.Size = new System.Drawing.Size(657, 248);
            this._PMTable.StandardTab = true;
            this._PMTable.TabIndex = 9;
            this._PMTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._PMTable_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Product Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 357;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cost";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Discount";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // _addmarkup
            // 
            this._addmarkup.Location = new System.Drawing.Point(259, 378);
            this._addmarkup.Name = "_addmarkup";
            this._addmarkup.Size = new System.Drawing.Size(128, 33);
            this._addmarkup.TabIndex = 2;
            this._addmarkup.Text = "Add MarkUp";
            this._addmarkup.UseVisualStyleBackColor = true;
            // 
            // _setDiscount
            // 
            this._setDiscount.Location = new System.Drawing.Point(409, 378);
            this._setDiscount.Name = "_setDiscount";
            this._setDiscount.Size = new System.Drawing.Size(128, 33);
            this._setDiscount.TabIndex = 3;
            this._setDiscount.Text = "Set Discount";
            this._setDiscount.UseVisualStyleBackColor = true;
            // 
            // _removedisc
            // 
            this._removedisc.Location = new System.Drawing.Point(551, 378);
            this._removedisc.Name = "_removedisc";
            this._removedisc.Size = new System.Drawing.Size(128, 33);
            this._removedisc.TabIndex = 4;
            this._removedisc.Text = "Remove Discount";
            this._removedisc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Price";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceMangmtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 488);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._removedisc);
            this.Controls.Add(this._setDiscount);
            this.Controls.Add(this._addmarkup);
            this.Controls.Add(this._PMTable);
            this.Controls.Add(this._search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PriceMangmtForm";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Price Management";
            ((System.ComponentModel.ISupportInitialize)(this._PMTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox _search;
        private DataGridView _PMTable;
        private Button _addmarkup;
        private Button _setDiscount;
        private Button _removedisc;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}