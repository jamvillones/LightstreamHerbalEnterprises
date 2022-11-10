﻿namespace Lightstream.Forms
{
    partial class SupplierManagement
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
            this._searchtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._supplierTable = new System.Windows.Forms.DataGridView();
            this.snCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._Update = new System.Windows.Forms.Button();
            this._Archive = new System.Windows.Forms.Button();
            this._Retrieve = new System.Windows.Forms.Button();
            this._Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._supplierTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _statusOption
            // 
            this._statusOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._statusOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._statusOption.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._statusOption.FormattingEnabled = true;
            this._statusOption.Location = new System.Drawing.Point(1244, 3);
            this._statusOption.Name = "_statusOption";
            this._statusOption.Size = new System.Drawing.Size(261, 31);
            this._statusOption.TabIndex = 0;
            this._statusOption.SelectedIndexChanged += new System.EventHandler(this._statusOption_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panel1.Enabled = false;
            this.panel1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(57, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1507, 318);
            this.panel1.TabIndex = 2;
            // 
            // _save
            // 
            this._save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._save.BackColor = System.Drawing.Color.ForestGreen;
            this._save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._save.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._save.ForeColor = System.Drawing.Color.White;
            this._save.Location = new System.Drawing.Point(1043, 252);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(230, 63);
            this._save.TabIndex = 9;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = false;
            this._save.Click += new System.EventHandler(this._save_Click);
            // 
            // _cancel
            // 
            this._cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancel.BackColor = System.Drawing.Color.ForestGreen;
            this._cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancel.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cancel.ForeColor = System.Drawing.Color.White;
            this._cancel.Location = new System.Drawing.Point(1279, 252);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(226, 63);
            this._cancel.TabIndex = 8;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = false;
            this._cancel.Click += new System.EventHandler(this._cancel_Click);
            // 
            // _contactnumber
            // 
            this._contactnumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._contactnumber.Location = new System.Drawing.Point(224, 126);
            this._contactnumber.Name = "_contactnumber";
            this._contactnumber.Size = new System.Drawing.Size(1278, 39);
            this._contactnumber.TabIndex = 7;
            // 
            // _address
            // 
            this._address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._address.Location = new System.Drawing.Point(224, 184);
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(1278, 39);
            this._address.TabIndex = 6;
            // 
            // _contactperson
            // 
            this._contactperson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._contactperson.Location = new System.Drawing.Point(224, 70);
            this._contactperson.Name = "_contactperson";
            this._contactperson.Size = new System.Drawing.Size(1278, 39);
            this._contactperson.TabIndex = 5;
            // 
            // _supplierName
            // 
            this._supplierName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._supplierName.Location = new System.Drawing.Point(224, 12);
            this._supplierName.Name = "_supplierName";
            this._supplierName.Size = new System.Drawing.Size(1278, 39);
            this._supplierName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Person:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(86, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier:";
            // 
            // _searchtxt
            // 
            this._searchtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._searchtxt.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._searchtxt.Location = new System.Drawing.Point(3, 7);
            this._searchtxt.Name = "_searchtxt";
            this._searchtxt.PlaceholderText = "Search....";
            this._searchtxt.Size = new System.Drawing.Size(584, 24);
            this._searchtxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1136, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Filter:";
            // 
            // _supplierTable
            // 
            this._supplierTable.AllowUserToAddRows = false;
            this._supplierTable.AllowUserToDeleteRows = false;
            this._supplierTable.AllowUserToResizeRows = false;
            this._supplierTable.BackgroundColor = System.Drawing.Color.White;
            this._supplierTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._supplierTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._supplierTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this._supplierTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._supplierTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snCol,
            this.cpCol,
            this.cnCol,
            this.addressCol,
            this.statCol});
            this._supplierTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._supplierTable.Location = new System.Drawing.Point(0, 43);
            this._supplierTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._supplierTable.Name = "_supplierTable";
            this._supplierTable.ReadOnly = true;
            this._supplierTable.RowHeadersVisible = false;
            this._supplierTable.RowHeadersWidth = 62;
            this._supplierTable.RowTemplate.Height = 25;
            this._supplierTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._supplierTable.Size = new System.Drawing.Size(1510, 208);
            this._supplierTable.TabIndex = 11;
            this._supplierTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this._supplierTable_RowsAdded);
            this._supplierTable.SelectionChanged += new System.EventHandler(this._supplierTable_SelectionChanged);
            // 
            // snCol
            // 
            this.snCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.snCol.HeaderText = "Supplier Name";
            this.snCol.MinimumWidth = 8;
            this.snCol.Name = "snCol";
            this.snCol.ReadOnly = true;
            this.snCol.Width = 165;
            // 
            // cpCol
            // 
            this.cpCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cpCol.HeaderText = "Contact Person";
            this.cpCol.MinimumWidth = 8;
            this.cpCol.Name = "cpCol";
            this.cpCol.ReadOnly = true;
            this.cpCol.Width = 153;
            // 
            // cnCol
            // 
            this.cnCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cnCol.HeaderText = "Contact Number";
            this.cnCol.MinimumWidth = 8;
            this.cnCol.Name = "cnCol";
            this.cnCol.ReadOnly = true;
            this.cnCol.Width = 164;
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
            this.statCol.Width = 96;
            // 
            // _Update
            // 
            this._Update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Update.BackColor = System.Drawing.Color.LightGreen;
            this._Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Update.Font = new System.Drawing.Font("Cinzel Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._Update.ForeColor = System.Drawing.Color.Black;
            this._Update.Location = new System.Drawing.Point(604, 670);
            this._Update.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this._Update.Name = "_Update";
            this._Update.Size = new System.Drawing.Size(199, 43);
            this._Update.TabIndex = 15;
            this._Update.Text = "Update";
            this._Update.UseVisualStyleBackColor = false;
            this._Update.Click += new System.EventHandler(this._Update_Click);
            // 
            // _Archive
            // 
            this._Archive.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Archive.BackColor = System.Drawing.Color.LightGreen;
            this._Archive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Archive.Font = new System.Drawing.Font("Cinzel Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._Archive.ForeColor = System.Drawing.Color.Black;
            this._Archive.Location = new System.Drawing.Point(814, 670);
            this._Archive.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this._Archive.Name = "_Archive";
            this._Archive.Size = new System.Drawing.Size(199, 43);
            this._Archive.TabIndex = 14;
            this._Archive.Text = "Archive";
            this._Archive.UseVisualStyleBackColor = false;
            this._Archive.Click += new System.EventHandler(this._Archive_Click);
            // 
            // _Retrieve
            // 
            this._Retrieve.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Retrieve.BackColor = System.Drawing.Color.LightGreen;
            this._Retrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Retrieve.Font = new System.Drawing.Font("Cinzel Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._Retrieve.ForeColor = System.Drawing.Color.Black;
            this._Retrieve.Location = new System.Drawing.Point(1024, 670);
            this._Retrieve.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this._Retrieve.Name = "_Retrieve";
            this._Retrieve.Size = new System.Drawing.Size(206, 43);
            this._Retrieve.TabIndex = 13;
            this._Retrieve.Text = "Retrieve";
            this._Retrieve.UseVisualStyleBackColor = false;
            this._Retrieve.Click += new System.EventHandler(this._Retrieve_Click);
            // 
            // _Add
            // 
            this._Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Add.BackColor = System.Drawing.Color.LightGreen;
            this._Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Add.Font = new System.Drawing.Font("Cinzel Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._Add.ForeColor = System.Drawing.Color.Black;
            this._Add.Location = new System.Drawing.Point(394, 670);
            this._Add.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this._Add.Name = "_Add";
            this._Add.Size = new System.Drawing.Size(199, 43);
            this._Add.TabIndex = 12;
            this._Add.Text = "Add";
            this._Add.UseVisualStyleBackColor = false;
            this._Add.Click += new System.EventHandler(this._Add_Click);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(50, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1519, 33);
            this.label6.TabIndex = 16;
            this.label6.Text = "Suppliers";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this._searchtxt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this._statusOption);
            this.panel2.Controls.Add(this._supplierTable);
            this.panel2.Location = new System.Drawing.Point(54, 410);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 43, 0, 0);
            this.panel2.Size = new System.Drawing.Size(1510, 251);
            this.panel2.TabIndex = 17;
            // 
            // SupplierManagement
            // 
            this.AcceptButton = this._save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 757);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this._Update);
            this.Controls.Add(this._Archive);
            this.Controls.Add(this._Retrieve);
            this.Controls.Add(this._Add);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierManagement";
            this.Padding = new System.Windows.Forms.Padding(50, 0, 50, 38);
            this.Load += new System.EventHandler(this.SupplierManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._supplierTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox _statusOption;
        private Panel panel1;
        private TextBox _searchtxt;
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
        private Button _Retrieve;
        private Button _Add;
        private DataGridViewTextBoxColumn snCol;
        private DataGridViewTextBoxColumn cpCol;
        private DataGridViewTextBoxColumn cnCol;
        private DataGridViewTextBoxColumn addressCol;
        private DataGridViewTextBoxColumn statCol;
        private Label label6;
        private Panel panel2;
    }
}