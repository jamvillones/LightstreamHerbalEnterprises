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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this._prodTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this._archive_retrieve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._prodTable)).BeginInit();
            this.panel3.SuspendLayout();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._prodTable.DefaultCellStyle = dataGridViewCellStyle7;
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
            this._prodTable.Size = new System.Drawing.Size(740, 473);
            this._prodTable.StandardTab = true;
            this._prodTable.TabIndex = 9;
            this._prodTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._prodTable_CellMouseClick);
            this._prodTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._prodTable_CellMouseDoubleClick);
            this._prodTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this._prodTable_RowsAdded);
            this._prodTable.SelectionChanged += new System.EventHandler(this._prodTable_SelectionChanged);
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
            dataGridViewCellStyle5.NullValue = "--";
            this.barcodeCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.barcodeCol.HeaderText = "PRODUCT NUMBER";
            this.barcodeCol.MinimumWidth = 130;
            this.barcodeCol.Name = "barcodeCol";
            this.barcodeCol.ReadOnly = true;
            // 
            // descCol
            // 
            this.descCol.DataPropertyName = "Description";
            dataGridViewCellStyle6.NullValue = "--";
            this.descCol.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.statusCol.Width = 68;
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
            this.label1.Text = "Products";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this._prodTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(30, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 473);
            this.panel3.TabIndex = 24;
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
            this.panel5.Location = new System.Drawing.Point(30, 30);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel5.Size = new System.Drawing.Size(740, 55);
            this.panel5.TabIndex = 28;
            // 
            // searchTxt
            // 
            this.searchTxt.AcceptsReturn = true;
            this.searchTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchTxt.BackColor = System.Drawing.SystemColors.Control;
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTxt.Location = new System.Drawing.Point(0, 13);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.PlaceholderText = "Search...";
            this.searchTxt.Size = new System.Drawing.Size(300, 29);
            this.searchTxt.TabIndex = 2;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            this.searchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTxt_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(330, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label6.Size = new System.Drawing.Size(44, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Filter:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(380, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 23);
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
            this.radioButton2.Location = new System.Drawing.Point(446, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 23);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "Inactive";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton3.Location = new System.Drawing.Point(522, 13);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(45, 23);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.Text = "All";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this._archive_retrieve);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 558);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(740, 40);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _archive_retrieve
            // 
            this._archive_retrieve.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._archive_retrieve.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._archive_retrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._archive_retrieve.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._archive_retrieve.ForeColor = System.Drawing.Color.Black;
            this._archive_retrieve.Location = new System.Drawing.Point(143, 0);
            this._archive_retrieve.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._archive_retrieve.Name = "_archive_retrieve";
            this._archive_retrieve.Size = new System.Drawing.Size(140, 40);
            this._archive_retrieve.TabIndex = 7;
            this._archive_retrieve.Text = "Archive";
            this._archive_retrieve.UseVisualStyleBackColor = false;
            this._archive_retrieve.Click += new System.EventHandler(this._archive_retrieve_Click);
            // 
            // ProductsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
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
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView _prodTable;
        private Label label1;
        private Panel panel3;
        private FlowLayoutPanel panel5;
        private TextBox searchTxt;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button _archive_retrieve;
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
        private Button button1;
    }
}
