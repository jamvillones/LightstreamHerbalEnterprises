namespace Lightstream.Forms
{
    partial class SupplierManagementPage
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
            this._statusOption = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._save = new System.Windows.Forms.Button();
            this._cancel = new System.Windows.Forms.Button();
            this._contactnumber = new System.Windows.Forms.TextBox();
            this._address = new System.Windows.Forms.TextBox();
            this._contactperson = new System.Windows.Forms.TextBox();
            this._supplierName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._supplierTable = new System.Windows.Forms.DataGridView();
            this._Update = new System.Windows.Forms.Button();
            this._Archive = new System.Windows.Forms.Button();
            this._Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.snCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._supplierTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _statusOption
            // 
            this._statusOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._statusOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._statusOption.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._statusOption.FormattingEnabled = true;
            this._statusOption.Location = new System.Drawing.Point(579, 9);
            this._statusOption.Name = "_statusOption";
            this._statusOption.Size = new System.Drawing.Size(160, 23);
            this._statusOption.TabIndex = 0;
            this._statusOption.SelectedIndexChanged += new System.EventHandler(this._statusOption_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._save);
            this.panel1.Controls.Add(this._cancel);
            this.panel1.Controls.Add(this._contactnumber);
            this.panel1.Controls.Add(this._address);
            this.panel1.Controls.Add(this._contactperson);
            this.panel1.Controls.Add(this._supplierName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Enabled = false;
            this.panel1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(30, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 161);
            this.panel1.TabIndex = 2;
            // 
            // _save
            // 
            this._save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._save.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._save.ForeColor = System.Drawing.Color.Black;
            this._save.Location = new System.Drawing.Point(145, 119);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(140, 30);
            this._save.TabIndex = 4;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = false;
            this._save.Click += new System.EventHandler(this._save_Click);
            // 
            // _cancel
            // 
            this._cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancel.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cancel.ForeColor = System.Drawing.Color.Black;
            this._cancel.Location = new System.Drawing.Point(290, 119);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(140, 30);
            this._cancel.TabIndex = 5;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = false;
            this._cancel.Click += new System.EventHandler(this._cancel_Click);
            // 
            // _contactnumber
            // 
            this._contactnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._contactnumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._contactnumber.Location = new System.Drawing.Point(145, 60);
            this._contactnumber.Name = "_contactnumber";
            this._contactnumber.Size = new System.Drawing.Size(285, 23);
            this._contactnumber.TabIndex = 2;
            // 
            // _address
            // 
            this._address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._address.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._address.Location = new System.Drawing.Point(145, 89);
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(285, 23);
            this._address.TabIndex = 3;
            // 
            // _contactperson
            // 
            this._contactperson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._contactperson.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._contactperson.Location = new System.Drawing.Point(145, 32);
            this._contactperson.Name = "_contactperson";
            this._contactperson.Size = new System.Drawing.Size(285, 23);
            this._contactperson.TabIndex = 1;
            // 
            // _supplierName
            // 
            this._supplierName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._supplierName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._supplierName.Location = new System.Drawing.Point(145, 3);
            this._supplierName.Name = "_supplierName";
            this._supplierName.Size = new System.Drawing.Size(285, 23);
            this._supplierName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Person:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Name:";
            // 
            // _search
            // 
            this._search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._search.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._search.Location = new System.Drawing.Point(0, 12);
            this._search.Name = "_search";
            this._search.PlaceholderText = "Search....";
            this._search.Size = new System.Drawing.Size(275, 16);
            this._search.TabIndex = 7;
            this._search.TextChanged += new System.EventHandler(this._search_TextChanged);
            this._search.KeyDown += new System.Windows.Forms.KeyEventHandler(this._search_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(529, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Filter:";
            // 
            // _supplierTable
            // 
            this._supplierTable.AllowUserToAddRows = false;
            this._supplierTable.AllowUserToDeleteRows = false;
            this._supplierTable.AllowUserToResizeRows = false;
            this._supplierTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._supplierTable.BackgroundColor = System.Drawing.Color.White;
            this._supplierTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._supplierTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._supplierTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._supplierTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._supplierTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editCol,
            this.snCol,
            this.cpCol,
            this.cnCol,
            this.addressCol,
            this.statCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._supplierTable.DefaultCellStyle = dataGridViewCellStyle3;
            this._supplierTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._supplierTable.EnableHeadersVisualStyles = false;
            this._supplierTable.Location = new System.Drawing.Point(30, 231);
            this._supplierTable.Margin = new System.Windows.Forms.Padding(0);
            this._supplierTable.MultiSelect = false;
            this._supplierTable.Name = "_supplierTable";
            this._supplierTable.ReadOnly = true;
            this._supplierTable.RowHeadersVisible = false;
            this._supplierTable.RowHeadersWidth = 62;
            this._supplierTable.RowTemplate.Height = 25;
            this._supplierTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._supplierTable.Size = new System.Drawing.Size(740, 189);
            this._supplierTable.TabIndex = 11;
            this._supplierTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._supplierTable_CellMouseClick);
            this._supplierTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this._supplierTable_RowsAdded);
            this._supplierTable.SelectionChanged += new System.EventHandler(this._supplierTable_SelectionChanged);
            // 
            // _Update
            // 
            this._Update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Update.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._Update.Location = new System.Drawing.Point(145, 10);
            this._Update.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._Update.Name = "_Update";
            this._Update.Size = new System.Drawing.Size(140, 40);
            this._Update.TabIndex = 15;
            this._Update.Text = "Update";
            this._Update.UseVisualStyleBackColor = false;
            this._Update.Click += new System.EventHandler(this._Update_Click);
            // 
            // _Archive
            // 
            this._Archive.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Archive.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._Archive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Archive.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Archive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._Archive.Location = new System.Drawing.Point(290, 10);
            this._Archive.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._Archive.Name = "_Archive";
            this._Archive.Size = new System.Drawing.Size(140, 40);
            this._Archive.TabIndex = 14;
            this._Archive.Text = "Archive";
            this._Archive.UseVisualStyleBackColor = false;
            this._Archive.Click += new System.EventHandler(this.ArchiveRetrieve_Click);
            // 
            // _Add
            // 
            this._Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Add.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._Add.Location = new System.Drawing.Point(0, 10);
            this._Add.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this._Add.Name = "_Add";
            this._Add.Size = new System.Drawing.Size(140, 40);
            this._Add.TabIndex = 12;
            this._Add.Text = "Add";
            this._Add.UseVisualStyleBackColor = false;
            this._Add.Click += new System.EventHandler(this._Add_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label6.Location = new System.Drawing.Point(30, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(740, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "Suppliers";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._search);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this._statusOption);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(30, 191);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 40, 0, 5);
            this.panel2.Size = new System.Drawing.Size(740, 40);
            this.panel2.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this._Add);
            this.flowLayoutPanel1.Controls.Add(this._Update);
            this.flowLayoutPanel1.Controls.Add(this._Archive);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 420);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(740, 50);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // editCol
            // 
            this.editCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editCol.HeaderText = "";
            this.editCol.MinimumWidth = 60;
            this.editCol.Name = "editCol";
            this.editCol.ReadOnly = true;
            this.editCol.Text = "EDIT";
            this.editCol.UseColumnTextForButtonValue = true;
            this.editCol.Width = 60;
            // 
            // snCol
            // 
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.snCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.snCol.HeaderText = "Name";
            this.snCol.MinimumWidth = 8;
            this.snCol.Name = "snCol";
            this.snCol.ReadOnly = true;
            // 
            // cpCol
            // 
            this.cpCol.HeaderText = "Contact Person";
            this.cpCol.MinimumWidth = 120;
            this.cpCol.Name = "cpCol";
            this.cpCol.ReadOnly = true;
            // 
            // cnCol
            // 
            this.cnCol.HeaderText = "Contact Details";
            this.cnCol.MinimumWidth = 120;
            this.cnCol.Name = "cnCol";
            this.cnCol.ReadOnly = true;
            // 
            // addressCol
            // 
            this.addressCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressCol.HeaderText = "Address";
            this.addressCol.MinimumWidth = 8;
            this.addressCol.Name = "addressCol";
            this.addressCol.ReadOnly = true;
            // 
            // statCol
            // 
            this.statCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.statCol.HeaderText = "Status";
            this.statCol.MinimumWidth = 8;
            this.statCol.Name = "statCol";
            this.statCol.ReadOnly = true;
            this.statCol.Width = 69;
            // 
            // SupplierManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this._supplierTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SupplierManagement";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.Load += new System.EventHandler(this.SupplierManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._supplierTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox _statusOption;
        private Panel panel1;
        private TextBox _search;
        private Button _save;
        private Button _cancel;
        private TextBox _contactnumber;
        private TextBox _address;
        private TextBox _contactperson;
        private TextBox _supplierName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private DataGridView _supplierTable;
        private Button _Update;
        private Button _Archive;
        private Button _Add;
        private Label label6;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridViewButtonColumn editCol;
        private DataGridViewTextBoxColumn snCol;
        private DataGridViewTextBoxColumn cpCol;
        private DataGridViewTextBoxColumn cnCol;
        private DataGridViewTextBoxColumn addressCol;
        private DataGridViewTextBoxColumn statCol;
    }
}