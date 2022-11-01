namespace Lightstream.Forms
{
    partial class SupplierForm
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
            this._save = new System.Windows.Forms.Button();
            this._supplier = new System.Windows.Forms.DataGridView();
            this._searchTxt = new System.Windows.Forms.TextBox();
            this._supplierNameOption = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // _save
            // 
            this._save.BackColor = System.Drawing.Color.ForestGreen;
            this._save.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._save.ForeColor = System.Drawing.Color.White;
            this._save.Location = new System.Drawing.Point(290, 243);
            this._save.Margin = new System.Windows.Forms.Padding(2);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(95, 42);
            this._save.TabIndex = 9;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = false;
            // 
            // _supplier
            // 
            this._supplier.BackgroundColor = System.Drawing.Color.White;
            this._supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._supplier.Location = new System.Drawing.Point(29, 52);
            this._supplier.Margin = new System.Windows.Forms.Padding(2);
            this._supplier.Name = "_supplier";
            this._supplier.RowHeadersWidth = 62;
            this._supplier.RowTemplate.Height = 33;
            this._supplier.Size = new System.Drawing.Size(459, 187);
            this._supplier.TabIndex = 8;
            // 
            // _searchTxt
            // 
            this._searchTxt.Location = new System.Drawing.Point(312, 11);
            this._searchTxt.Margin = new System.Windows.Forms.Padding(2);
            this._searchTxt.Name = "_searchTxt";
            this._searchTxt.PlaceholderText = "Search....";
            this._searchTxt.Size = new System.Drawing.Size(176, 23);
            this._searchTxt.TabIndex = 7;
            // 
            // _supplierNameOption
            // 
            this._supplierNameOption.FormattingEnabled = true;
            this._supplierNameOption.Location = new System.Drawing.Point(125, 11);
            this._supplierNameOption.Margin = new System.Windows.Forms.Padding(2);
            this._supplierNameOption.Name = "_supplierNameOption";
            this._supplierNameOption.Size = new System.Drawing.Size(142, 23);
            this._supplierNameOption.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Supplier Name:";
            // 
            // _cancel
            // 
            this._cancel.BackColor = System.Drawing.Color.ForestGreen;
            this._cancel.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cancel.ForeColor = System.Drawing.Color.White;
            this._cancel.Location = new System.Drawing.Point(389, 243);
            this._cancel.Margin = new System.Windows.Forms.Padding(2);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(97, 42);
            this._cancel.TabIndex = 10;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = false;
            // 
            // FSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 330);
            this.Controls.Add(this._cancel);
            this.Controls.Add(this._save);
            this.Controls.Add(this._supplier);
            this.Controls.Add(this._searchTxt);
            this.Controls.Add(this._supplierNameOption);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FSupplier";
            this.Text = "Supplier";
            ((System.ComponentModel.ISupportInitialize)(this._supplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button _save;
        private DataGridView _supplier;
        private TextBox _searchTxt;
        private ComboBox _supplierNameOption;
        private Label label1;
        private Button _cancel;
    }
}