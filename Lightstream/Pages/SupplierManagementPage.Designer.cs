namespace Lightstream.Forms
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._supplierTable)).BeginInit();
            this.SuspendLayout();
            // 
            // _statusOption
            // 
            this._statusOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._statusOption.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._statusOption.FormattingEnabled = true;
            this._statusOption.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this._statusOption.Location = new System.Drawing.Point(588, 16);
            this._statusOption.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._statusOption.Name = "_statusOption";
            this._statusOption.Size = new System.Drawing.Size(184, 39);
            this._statusOption.TabIndex = 0;
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
            this.panel1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(23, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 263);
            this.panel1.TabIndex = 2;
            // 
            // _save
            // 
            this._save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._save.BackColor = System.Drawing.Color.ForestGreen;
            this._save.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._save.ForeColor = System.Drawing.Color.White;
            this._save.Location = new System.Drawing.Point(231, 202);
            this._save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(158, 46);
            this._save.TabIndex = 9;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = false;
            this._save.Click += new System.EventHandler(this._save_Click);
            // 
            // _cancel
            // 
            this._cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancel.BackColor = System.Drawing.Color.ForestGreen;
            this._cancel.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cancel.ForeColor = System.Drawing.Color.White;
            this._cancel.Location = new System.Drawing.Point(393, 202);
            this._cancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(158, 46);
            this._cancel.TabIndex = 8;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = false;
            // 
            // _contactnumber
            // 
            this._contactnumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._contactnumber.Location = new System.Drawing.Point(157, 103);
            this._contactnumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._contactnumber.Name = "_contactnumber";
            this._contactnumber.Size = new System.Drawing.Size(391, 39);
            this._contactnumber.TabIndex = 7;
            // 
            // _address
            // 
            this._address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._address.Location = new System.Drawing.Point(157, 148);
            this._address.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(391, 39);
            this._address.TabIndex = 6;
            // 
            // _contactperson
            // 
            this._contactperson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._contactperson.Location = new System.Drawing.Point(157, 59);
            this._contactperson.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._contactperson.Name = "_contactperson";
            this._contactperson.Size = new System.Drawing.Size(391, 39);
            this._contactperson.TabIndex = 5;
            // 
            // _supplierName
            // 
            this._supplierName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._supplierName.Location = new System.Drawing.Point(157, 14);
            this._supplierName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._supplierName.Name = "_supplierName";
            this._supplierName.Size = new System.Drawing.Size(391, 39);
            this._supplierName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Person:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier:";
            // 
            // _searchtxt
            // 
            this._searchtxt.Location = new System.Drawing.Point(23, 12);
            this._searchtxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._searchtxt.Name = "_searchtxt";
            this._searchtxt.PlaceholderText = "Search....";
            this._searchtxt.Size = new System.Drawing.Size(409, 31);
            this._searchtxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(512, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Filter:";
            // 
            // _supplierTable
            // 
            this._supplierTable.AllowUserToAddRows = false;
            this._supplierTable.AllowUserToDeleteRows = false;
            this._supplierTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._supplierTable.BackgroundColor = System.Drawing.Color.White;
            this._supplierTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._supplierTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._supplierTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bebas Neue", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._supplierTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this._supplierTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._supplierTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snCol,
            this.cpCol,
            this.cnCol,
            this.addressCol,
            this.statCol});
            this._supplierTable.Location = new System.Drawing.Point(23, 343);
            this._supplierTable.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this._supplierTable.Name = "_supplierTable";
            this._supplierTable.ReadOnly = true;
            this._supplierTable.RowHeadersVisible = false;
            this._supplierTable.RowHeadersWidth = 62;
            this._supplierTable.RowTemplate.Height = 25;
            this._supplierTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._supplierTable.Size = new System.Drawing.Size(765, 76);
            this._supplierTable.TabIndex = 11;
            // 
            // snCol
            // 
            this.snCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.snCol.HeaderText = "Supplier Name";
            this.snCol.MinimumWidth = 8;
            this.snCol.Name = "snCol";
            this.snCol.ReadOnly = true;
            this.snCol.Width = 153;
            // 
            // cpCol
            // 
            this.cpCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cpCol.HeaderText = "Contact Person";
            this.cpCol.MinimumWidth = 8;
            this.cpCol.Name = "cpCol";
            this.cpCol.ReadOnly = true;
            this.cpCol.Width = 162;
            // 
            // cnCol
            // 
            this.cnCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cnCol.HeaderText = "Contact Number";
            this.cnCol.MinimumWidth = 8;
            this.cnCol.Name = "cnCol";
            this.cnCol.ReadOnly = true;
            this.cnCol.Width = 167;
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
            this.statCol.Width = 97;
            // 
            // _Update
            // 
            this._Update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Update.BackColor = System.Drawing.Color.ForestGreen;
            this._Update.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Update.ForeColor = System.Drawing.Color.White;
            this._Update.Location = new System.Drawing.Point(249, 429);
            this._Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._Update.Name = "_Update";
            this._Update.Size = new System.Drawing.Size(139, 57);
            this._Update.TabIndex = 15;
            this._Update.Text = "Update";
            this._Update.UseVisualStyleBackColor = false;
            this._Update.Click += new System.EventHandler(this._Update_Click);
            // 
            // _Archive
            // 
            this._Archive.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Archive.BackColor = System.Drawing.Color.ForestGreen;
            this._Archive.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Archive.ForeColor = System.Drawing.Color.White;
            this._Archive.Location = new System.Drawing.Point(396, 429);
            this._Archive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._Archive.Name = "_Archive";
            this._Archive.Size = new System.Drawing.Size(139, 57);
            this._Archive.TabIndex = 14;
            this._Archive.Text = "Archive";
            this._Archive.UseVisualStyleBackColor = false;
            // 
            // _Retrieve
            // 
            this._Retrieve.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Retrieve.BackColor = System.Drawing.Color.ForestGreen;
            this._Retrieve.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Retrieve.ForeColor = System.Drawing.Color.White;
            this._Retrieve.Location = new System.Drawing.Point(543, 429);
            this._Retrieve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._Retrieve.Name = "_Retrieve";
            this._Retrieve.Size = new System.Drawing.Size(139, 57);
            this._Retrieve.TabIndex = 13;
            this._Retrieve.Text = "Retrieve";
            this._Retrieve.UseVisualStyleBackColor = false;
            // 
            // _Add
            // 
            this._Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Add.BackColor = System.Drawing.Color.ForestGreen;
            this._Add.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Add.ForeColor = System.Drawing.Color.White;
            this._Add.Location = new System.Drawing.Point(102, 429);
            this._Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._Add.Name = "_Add";
            this._Add.Size = new System.Drawing.Size(139, 57);
            this._Add.TabIndex = 12;
            this._Add.Text = "Add";
            this._Add.UseVisualStyleBackColor = false;
            this._Add.Visible = false;
            this._Add.Click += new System.EventHandler(this._Add_Click);
            // 
            // SupplierManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this._Update);
            this.Controls.Add(this._Archive);
            this.Controls.Add(this._Retrieve);
            this.Controls.Add(this._Add);
            this.Controls.Add(this._supplierTable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._searchtxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._statusOption);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SupplierManagement";
            this.Load += new System.EventHandler(this.SupplierManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._supplierTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}