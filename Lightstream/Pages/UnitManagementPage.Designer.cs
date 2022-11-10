namespace Lightstream.Forms
{
    partial class UnitManagementPage
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
            this._unitsTable = new System.Windows.Forms.DataGridView();
            this._Add = new System.Windows.Forms.Button();
            this._Retrieve = new System.Windows.Forms.Button();
            this._Archive = new System.Windows.Forms.Button();
            this._Update = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.editBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abbreviationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pluralCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._unitsTable)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _unitsTable
            // 
            this._unitsTable.AllowUserToAddRows = false;
            this._unitsTable.AllowUserToDeleteRows = false;
            this._unitsTable.AllowUserToResizeRows = false;
            this._unitsTable.BackgroundColor = System.Drawing.Color.White;
            this._unitsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._unitsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._unitsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._unitsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._unitsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editBtnCol,
            this.idCol,
            this.abbreviationCol,
            this.nameCol,
            this.pluralCol,
            this.statusCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._unitsTable.DefaultCellStyle = dataGridViewCellStyle2;
            this._unitsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._unitsTable.EnableHeadersVisualStyles = false;
            this._unitsTable.Location = new System.Drawing.Point(35, 48);
            this._unitsTable.MultiSelect = false;
            this._unitsTable.Name = "_unitsTable";
            this._unitsTable.ReadOnly = true;
            this._unitsTable.RowHeadersVisible = false;
            this._unitsTable.RowHeadersWidth = 62;
            this._unitsTable.RowTemplate.Height = 25;
            this._unitsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._unitsTable.Size = new System.Drawing.Size(730, 354);
            this._unitsTable.TabIndex = 1;
            this._unitsTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this._unitsTable_RowsAdded);
            // 
            // _Add
            // 
            this._Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Add.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Add.ForeColor = System.Drawing.Color.Black;
            this._Add.Location = new System.Drawing.Point(0, 3);
            this._Add.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this._Add.Name = "_Add";
            this._Add.Size = new System.Drawing.Size(120, 30);
            this._Add.TabIndex = 5;
            this._Add.Text = "Add";
            this._Add.UseVisualStyleBackColor = false;
            this._Add.Click += new System.EventHandler(this._Add_Click);
            // 
            // _Retrieve
            // 
            this._Retrieve.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Retrieve.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._Retrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Retrieve.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Retrieve.ForeColor = System.Drawing.Color.Black;
            this._Retrieve.Location = new System.Drawing.Point(246, 3);
            this._Retrieve.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this._Retrieve.Name = "_Retrieve";
            this._Retrieve.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._Retrieve.Size = new System.Drawing.Size(120, 30);
            this._Retrieve.TabIndex = 6;
            this._Retrieve.Text = "Retrieve";
            this._Retrieve.UseVisualStyleBackColor = false;
            // 
            // _Archive
            // 
            this._Archive.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Archive.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._Archive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Archive.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Archive.ForeColor = System.Drawing.Color.Black;
            this._Archive.Location = new System.Drawing.Point(123, 3);
            this._Archive.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this._Archive.Name = "_Archive";
            this._Archive.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._Archive.Size = new System.Drawing.Size(120, 30);
            this._Archive.TabIndex = 7;
            this._Archive.Text = "Archive";
            this._Archive.UseVisualStyleBackColor = false;
            // 
            // _Update
            // 
            this._Update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Update.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Update.ForeColor = System.Drawing.Color.Black;
            this._Update.Location = new System.Drawing.Point(369, 3);
            this._Update.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this._Update.Name = "_Update";
            this._Update.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._Update.Size = new System.Drawing.Size(120, 30);
            this._Update.TabIndex = 8;
            this._Update.Text = "Update";
            this._Update.UseVisualStyleBackColor = false;
            this._Update.Visible = false;
            this._Update.Click += new System.EventHandler(this._Update_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this._Add);
            this.flowLayoutPanel1.Controls.Add(this._Archive);
            this.flowLayoutPanel1.Controls.Add(this._Retrieve);
            this.flowLayoutPanel1.Controls.Add(this._Update);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(35, 402);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(730, 36);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(35, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Units";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(35, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Search...";
            this.textBox1.Size = new System.Drawing.Size(730, 18);
            this.textBox1.TabIndex = 11;
            // 
            // editBtnCol
            // 
            this.editBtnCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtnCol.HeaderText = "";
            this.editBtnCol.MinimumWidth = 60;
            this.editBtnCol.Name = "editBtnCol";
            this.editBtnCol.ReadOnly = true;
            this.editBtnCol.Text = "EDIT";
            this.editBtnCol.UseColumnTextForButtonValue = true;
            this.editBtnCol.Width = 60;
            // 
            // idCol
            // 
            this.idCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idCol.HeaderText = "Id";
            this.idCol.MinimumWidth = 8;
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            this.idCol.Width = 26;
            // 
            // abbreviationCol
            // 
            this.abbreviationCol.HeaderText = "Abbreviation";
            this.abbreviationCol.MinimumWidth = 8;
            this.abbreviationCol.Name = "abbreviationCol";
            this.abbreviationCol.ReadOnly = true;
            this.abbreviationCol.Width = 150;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.MinimumWidth = 8;
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            this.nameCol.Width = 150;
            // 
            // pluralCol
            // 
            this.pluralCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pluralCol.FillWeight = 169.697F;
            this.pluralCol.HeaderText = "Plural";
            this.pluralCol.MinimumWidth = 8;
            this.pluralCol.Name = "pluralCol";
            this.pluralCol.ReadOnly = true;
            // 
            // statusCol
            // 
            this.statusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusCol.FillWeight = 30.30302F;
            this.statusCol.HeaderText = "Archived";
            this.statusCol.MinimumWidth = 8;
            this.statusCol.Name = "statusCol";
            this.statusCol.ReadOnly = true;
            this.statusCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusCol.Visible = false;
            // 
            // UnitManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this._unitsTable);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitManagementPage";
            this.Padding = new System.Windows.Forms.Padding(35, 0, 35, 35);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UnitMangmtForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._unitsTable)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView _unitsTable;
        private Button _Add;
        private Button _Retrieve;
        private Button _Archive;
        private Button _Update;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox textBox1;
        private DataGridViewButtonColumn editBtnCol;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn abbreviationCol;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn pluralCol;
        private DataGridViewCheckBoxColumn statusCol;
    }
}