namespace Lightstream.Forms
{
    partial class AssignSupplierForm
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
            this._chooseSupplierOption = new System.Windows.Forms.ComboBox();
            this._searchTxt = new System.Windows.Forms.TextBox();
            this._assignTable = new System.Windows.Forms.DataGridView();
            this._assign = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._assignTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Supplier";
            // 
            // _chooseSupplierOption
            // 
            this._chooseSupplierOption.FormattingEnabled = true;
            this._chooseSupplierOption.Location = new System.Drawing.Point(125, 16);
            this._chooseSupplierOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._chooseSupplierOption.Name = "_chooseSupplierOption";
            this._chooseSupplierOption.Size = new System.Drawing.Size(129, 23);
            this._chooseSupplierOption.TabIndex = 1;
            // 
            // _searchTxt
            // 
            this._searchTxt.Location = new System.Drawing.Point(302, 16);
            this._searchTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._searchTxt.Name = "_searchTxt";
            this._searchTxt.PlaceholderText = "Search....";
            this._searchTxt.Size = new System.Drawing.Size(176, 23);
            this._searchTxt.TabIndex = 2;
            // 
            // _assignTable
            // 
            this._assignTable.BackgroundColor = System.Drawing.Color.White;
            this._assignTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._assignTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._assignTable.Location = new System.Drawing.Point(43, 46);
            this._assignTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._assignTable.Name = "_assignTable";
            this._assignTable.RowHeadersWidth = 62;
            this._assignTable.RowTemplate.Height = 33;
            this._assignTable.Size = new System.Drawing.Size(434, 187);
            this._assignTable.TabIndex = 3;
            // 
            // _assign
            // 
            this._assign.BackColor = System.Drawing.Color.ForestGreen;
            this._assign.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._assign.ForeColor = System.Drawing.Color.White;
            this._assign.Location = new System.Drawing.Point(382, 242);
            this._assign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._assign.Name = "_assign";
            this._assign.Size = new System.Drawing.Size(94, 38);
            this._assign.TabIndex = 4;
            this._assign.Text = "Assign";
            this._assign.UseVisualStyleBackColor = false;
            // 
            // AssignSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 345);
            this.Controls.Add(this._assign);
            this.Controls.Add(this._assignTable);
            this.Controls.Add(this._searchTxt);
            this.Controls.Add(this._chooseSupplierOption);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AssignSupplierForm";
            this.Text = "AssignSupplier";
            ((System.ComponentModel.ISupportInitialize)(this._assignTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox _chooseSupplierOption;
        private TextBox _searchTxt;
        private DataGridView _assignTable;
        private Button _assign;
    }
}