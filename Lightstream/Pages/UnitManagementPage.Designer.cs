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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this._unitsTable = new System.Windows.Forms.DataGridView();
            this.editBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abbreviationCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pluralCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Add = new System.Windows.Forms.Button();
            this._archive_retrieve = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this._search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._statusOption = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._unitsTable)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _unitsTable
            // 
            this._unitsTable.AllowUserToAddRows = false;
            this._unitsTable.AllowUserToDeleteRows = false;
            this._unitsTable.AllowUserToResizeRows = false;
            this._unitsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.nameCol,
            this.abbreviationCol,
            this.pluralCol,
            this.statusCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._unitsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this._unitsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._unitsTable.EnableHeadersVisualStyles = false;
            this._unitsTable.Location = new System.Drawing.Point(30, 64);
            this._unitsTable.MultiSelect = false;
            this._unitsTable.Name = "_unitsTable";
            this._unitsTable.ReadOnly = true;
            this._unitsTable.RowHeadersVisible = false;
            this._unitsTable.RowHeadersWidth = 62;
            this._unitsTable.RowTemplate.Height = 25;
            this._unitsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._unitsTable.Size = new System.Drawing.Size(740, 339);
            this._unitsTable.StandardTab = true;
            this._unitsTable.TabIndex = 1;
            this._unitsTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._unitsTable_CellMouseClick);
            this._unitsTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this._unitsTable_RowsAdded);
            this._unitsTable.SelectionChanged += new System.EventHandler(this._unitsTable_SelectionChanged);
            // 
            // editBtnCol
            // 
            this.editBtnCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
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
            // 
            // nameCol
            // 
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.nameCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.nameCol.HeaderText = "Name";
            this.nameCol.MinimumWidth = 8;
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            // 
            // abbreviationCol
            // 
            this.abbreviationCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.abbreviationCol.HeaderText = "Abbreviation";
            this.abbreviationCol.MinimumWidth = 8;
            this.abbreviationCol.Name = "abbreviationCol";
            this.abbreviationCol.ReadOnly = true;
            // 
            // pluralCol
            // 
            this.pluralCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pluralCol.FillWeight = 169.697F;
            this.pluralCol.HeaderText = "Plural";
            this.pluralCol.MinimumWidth = 8;
            this.pluralCol.Name = "pluralCol";
            this.pluralCol.ReadOnly = true;
            this.pluralCol.Visible = false;
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
            // _Add
            // 
            this._Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Add.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Add.ForeColor = System.Drawing.Color.Black;
            this._Add.Location = new System.Drawing.Point(0, 0);
            this._Add.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._Add.Name = "_Add";
            this._Add.Size = new System.Drawing.Size(140, 40);
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
            this._archive_retrieve.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._archive_retrieve.ForeColor = System.Drawing.Color.Black;
            this._archive_retrieve.Location = new System.Drawing.Point(145, 0);
            this._archive_retrieve.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._archive_retrieve.Name = "_archive_retrieve";
            this._archive_retrieve.Size = new System.Drawing.Size(140, 40);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 403);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(740, 40);
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
            // _search
            // 
            this._search.AcceptsReturn = true;
            this._search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._search.Location = new System.Drawing.Point(0, 9);
            this._search.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this._search.Name = "_search";
            this._search.PlaceholderText = "Search...";
            this._search.Size = new System.Drawing.Size(280, 16);
            this._search.TabIndex = 11;
            this._search.TextChanged += new System.EventHandler(this._search_TextChanged);
            this._search.KeyDown += new System.Windows.Forms.KeyEventHandler(this._search_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(528, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Filter:";
            // 
            // _statusOption
            // 
            this._statusOption.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._statusOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._statusOption.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._statusOption.FormattingEnabled = true;
            this._statusOption.Location = new System.Drawing.Point(575, 6);
            this._statusOption.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this._statusOption.Name = "_statusOption";
            this._statusOption.Size = new System.Drawing.Size(165, 23);
            this._statusOption.TabIndex = 12;
            this._statusOption.SelectedIndexChanged += new System.EventHandler(this._statusOption_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this._search);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this._statusOption);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(30, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 34);
            this.panel1.TabIndex = 14;
            // 
            // UnitManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this._unitsTable);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView _unitsTable;
        private Button _Add;
        private Button _archive_retrieve;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox _search;
        private Label label5;
        private ComboBox _statusOption;
        private Panel panel1;
        private DataGridViewButtonColumn editBtnCol;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn abbreviationCol;
        private DataGridViewTextBoxColumn pluralCol;
        private DataGridViewTextBoxColumn statusCol;
    }
}