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
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abbreviationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pluralCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this._Add = new System.Windows.Forms.Button();
            this._archive_retrieve = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.idCol,
            this.abbreviationCol,
            this.nameCol,
            this.pluralCol,
            this.statusCol,
            this.editBtnCol});
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
            this._unitsTable.Location = new System.Drawing.Point(30, 48);
            this._unitsTable.MultiSelect = false;
            this._unitsTable.Name = "_unitsTable";
            this._unitsTable.ReadOnly = true;
            this._unitsTable.RowHeadersVisible = false;
            this._unitsTable.RowHeadersWidth = 62;
            this._unitsTable.RowTemplate.Height = 25;
            this._unitsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._unitsTable.Size = new System.Drawing.Size(740, 365);
            this._unitsTable.TabIndex = 1;
            this._unitsTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this._unitsTable_RowsAdded);
            this._unitsTable.SelectionChanged += new System.EventHandler(this._unitsTable_SelectionChanged);
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
            this.statusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.statusCol.FillWeight = 30.30302F;
            this.statusCol.HeaderText = "Status";
            this.statusCol.MinimumWidth = 8;
            this.statusCol.Name = "statusCol";
            this.statusCol.ReadOnly = true;
            this.statusCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusCol.Width = 69;
            // 
            // editBtnCol
            // 
            this.editBtnCol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editBtnCol.HeaderText = "";
            this.editBtnCol.MinimumWidth = 60;
            this.editBtnCol.Name = "editBtnCol";
            this.editBtnCol.ReadOnly = true;
            this.editBtnCol.Text = "EDIT";
            this.editBtnCol.UseColumnTextForButtonValue = true;
            this.editBtnCol.Width = 60;
            // 
            // _Add
            // 
            this._Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Add.Font = new System.Drawing.Font("Bebas Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Add.ForeColor = System.Drawing.Color.Black;
            this._Add.Location = new System.Drawing.Point(0, 0);
            this._Add.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._Add.Name = "_Add";
            this._Add.Size = new System.Drawing.Size(140, 30);
            this._Add.TabIndex = 5;
            this._Add.Text = "Add";
            this._Add.UseVisualStyleBackColor = false;
            this._Add.Click += new System.EventHandler(this._Add_Click);
            // 
            // _archive_retrieve
            // 
            this._archive_retrieve.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._archive_retrieve.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._archive_retrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._archive_retrieve.Font = new System.Drawing.Font("Bebas Neue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._archive_retrieve.ForeColor = System.Drawing.Color.Black;
            this._archive_retrieve.Location = new System.Drawing.Point(145, 0);
            this._archive_retrieve.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._archive_retrieve.Name = "_archive_retrieve";
            this._archive_retrieve.Size = new System.Drawing.Size(140, 30);
            this._archive_retrieve.TabIndex = 7;
            this._archive_retrieve.Text = "Archive";
            this._archive_retrieve.UseVisualStyleBackColor = false;
            this._archive_retrieve.Click += new System.EventHandler(this._archive_retrieve_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this._Add);
            this.flowLayoutPanel1.Controls.Add(this._archive_retrieve);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 413);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(740, 30);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 30);
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
            this.textBox1.Location = new System.Drawing.Point(30, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Search...";
            this.textBox1.Size = new System.Drawing.Size(740, 18);
            this.textBox1.TabIndex = 11;
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
            this.Padding = new System.Windows.Forms.Padding(30, 0, 30, 30);
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
        private Button _archive_retrieve;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn abbreviationCol;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn pluralCol;
        private DataGridViewTextBoxColumn statusCol;
        private DataGridViewButtonColumn editBtnCol;
    }
}