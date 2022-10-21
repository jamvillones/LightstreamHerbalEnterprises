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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this._prodTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this._barcode = new System.Windows.Forms.TextBox();
            this._unitOption = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._recipe = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._prodTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTxt
            // 
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Location = new System.Drawing.Point(8, 8);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(10);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.PlaceholderText = "Search...";
            this.searchTxt.Size = new System.Drawing.Size(214, 16);
            this.searchTxt.TabIndex = 8;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            this.searchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTxt_KeyDown);
            // 
            // _prodTable
            // 
            this._prodTable.AllowUserToAddRows = false;
            this._prodTable.AllowUserToDeleteRows = false;
            this._prodTable.AllowUserToResizeRows = false;
            this._prodTable.BackgroundColor = System.Drawing.Color.White;
            this._prodTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._prodTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._prodTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._prodTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._prodTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.barcodeCol,
            this.Column4,
            this.unitCol,
            this.ingCol,
            this.editCol,
            this.delCol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._prodTable.DefaultCellStyle = dataGridViewCellStyle4;
            this._prodTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._prodTable.EnableHeadersVisualStyles = false;
            this._prodTable.Location = new System.Drawing.Point(0, 30);
            this._prodTable.Margin = new System.Windows.Forms.Padding(10);
            this._prodTable.MultiSelect = false;
            this._prodTable.Name = "_prodTable";
            this._prodTable.ReadOnly = true;
            this._prodTable.RowHeadersVisible = false;
            this._prodTable.RowTemplate.Height = 25;
            this._prodTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._prodTable.Size = new System.Drawing.Size(629, 181);
            this._prodTable.StandardTab = true;
            this._prodTable.TabIndex = 9;
            this._prodTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._prodTable_CellMouseClick);
            this._prodTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._prodTable_CellMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ProductName";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // barcodeCol
            // 
            this.barcodeCol.HeaderText = "Barcode";
            this.barcodeCol.Name = "barcodeCol";
            this.barcodeCol.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Description";
            this.Column4.HeaderText = "Description";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // unitCol
            // 
            this.unitCol.HeaderText = "Unit Measurement";
            this.unitCol.MinimumWidth = 20;
            this.unitCol.Name = "unitCol";
            this.unitCol.ReadOnly = true;
            this.unitCol.Width = 170;
            // 
            // ingCol
            // 
            this.ingCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ingCol.HeaderText = "Ingredients";
            this.ingCol.Name = "ingCol";
            this.ingCol.ReadOnly = true;
            // 
            // editCol
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            this.editCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.editCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            this.delCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.delCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delCol.HeaderText = "";
            this.delCol.MinimumWidth = 60;
            this.delCol.Name = "delCol";
            this.delCol.ReadOnly = true;
            this.delCol.Text = "DELETE";
            this.delCol.UseColumnTextForButtonValue = true;
            this.delCol.Width = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(50, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Barcode:";
            // 
            // _barcode
            // 
            this._barcode.Location = new System.Drawing.Point(99, 60);
            this._barcode.Name = "_barcode";
            this._barcode.PlaceholderText = "optional...";
            this._barcode.Size = new System.Drawing.Size(268, 23);
            this._barcode.TabIndex = 1;
            // 
            // _unitOption
            // 
            this._unitOption.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._unitOption.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this._unitOption.Location = new System.Drawing.Point(99, 122);
            this._unitOption.Name = "_unitOption";
            this._unitOption.Size = new System.Drawing.Size(268, 23);
            this._unitOption.TabIndex = 3;
            this._unitOption.Validated += new System.EventHandler(this._unitOption_Validated);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._recipe);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(387, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 167);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Required Ingredients";
            // 
            // _recipe
            // 
            this._recipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._recipe.DisplayMember = "DisplayMember";
            this._recipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this._recipe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._recipe.FormattingEnabled = true;
            this._recipe.ItemHeight = 15;
            this._recipe.Location = new System.Drawing.Point(3, 43);
            this._recipe.Margin = new System.Windows.Forms.Padding(5);
            this._recipe.Name = "_recipe";
            this._recipe.Size = new System.Drawing.Size(236, 121);
            this._recipe.TabIndex = 1;
            this._recipe.TabStop = false;
            this.toolTip1.SetToolTip(this._recipe, "Delete to remove ingredient");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._addRecipe);
            this.panel2.Controls.Add(this._removeRecipe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 25);
            this.panel2.TabIndex = 24;
            // 
            // _addRecipe
            // 
            this._addRecipe.BackColor = System.Drawing.SystemColors.Control;
            this._addRecipe.Dock = System.Windows.Forms.DockStyle.Right;
            this._addRecipe.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this._addRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._addRecipe.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._addRecipe.Location = new System.Drawing.Point(76, 0);
            this._addRecipe.Name = "_addRecipe";
            this._addRecipe.Size = new System.Drawing.Size(80, 25);
            this._addRecipe.TabIndex = 0;
            this._addRecipe.Text = "+ Add";
            this._addRecipe.UseVisualStyleBackColor = false;
            this._addRecipe.Click += new System.EventHandler(this._addIngredients_Click);
            // 
            // _removeRecipe
            // 
            this._removeRecipe.BackColor = System.Drawing.SystemColors.Control;
            this._removeRecipe.Dock = System.Windows.Forms.DockStyle.Right;
            this._removeRecipe.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this._removeRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._removeRecipe.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._removeRecipe.Location = new System.Drawing.Point(156, 0);
            this._removeRecipe.Name = "_removeRecipe";
            this._removeRecipe.Size = new System.Drawing.Size(80, 25);
            this._removeRecipe.TabIndex = 1;
            this._removeRecipe.Text = "- remove";
            this._removeRecipe.UseVisualStyleBackColor = false;
            this._removeRecipe.Click += new System.EventHandler(this._removeRecipe_Click);
            // 
            // _description
            // 
            this._description.Location = new System.Drawing.Point(99, 91);
            this._description.Name = "_description";
            this._description.PlaceholderText = "optional...";
            this._description.Size = new System.Drawing.Size(268, 23);
            this._description.TabIndex = 2;
            this._description.TextChanged += new System.EventHandler(this.fields_TextChanged);
            // 
            // _cancel
            // 
            this._cancel.Enabled = false;
            this._cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancel.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cancel.Location = new System.Drawing.Point(251, 158);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(116, 29);
            this._cancel.TabIndex = 6;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = true;
            this._cancel.Click += new System.EventHandler(this._cancel_Click);
            // 
            // _save
            // 
            this._save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._save.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._save.Location = new System.Drawing.Point(0, 158);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(245, 29);
            this._save.TabIndex = 5;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = false;
            this._save.Click += new System.EventHandler(this._save_Click);
            // 
            // _productName
            // 
            this._productName.Location = new System.Drawing.Point(99, 29);
            this._productName.Name = "_productName";
            this._productName.PlaceholderText = "required...";
            this._productName.Size = new System.Drawing.Size(268, 23);
            this._productName.TabIndex = 0;
            this._productName.TextChanged += new System.EventHandler(this.fields_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "UNIT OF MEASUREMENT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "DESCRIPTION:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "PRODUCT NAME:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(629, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Create Product";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.searchTxt);
            this.panel3.Controls.Add(this._prodTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(20, 257);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel3.Size = new System.Drawing.Size(629, 211);
            this.panel3.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this._barcode);
            this.panel4.Controls.Add(this._productName);
            this.panel4.Controls.Add(this._unitOption);
            this.panel4.Controls.Add(this._save);
            this.panel4.Controls.Add(this._cancel);
            this.panel4.Controls.Add(this._description);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(20, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(629, 206);
            this.panel4.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 1);
            this.panel1.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label6.Location = new System.Drawing.Point(20, 232);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label6.Size = new System.Drawing.Size(629, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Products";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 488);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductsPage";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ProductsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this._prodTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox searchTxt;
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn barcodeCol;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn unitCol;
        private DataGridViewTextBoxColumn ingCol;
        private DataGridViewButtonColumn editCol;
        private DataGridViewButtonColumn delCol;
        private ToolTip toolTip1;
        private Button _removeRecipe;
        private Panel panel3;
        private Panel panel4;
        private Panel panel1;
        private Label label6;
        private Panel panel2;
    }
}
