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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this._statusOption = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this._save = new System.Windows.Forms.Button();
            this._cancel = new System.Windows.Forms.Button();
            this._contactnumber = new System.Windows.Forms.TextBox();
            this._address = new System.Windows.Forms.TextBox();
            this._contactperson = new System.Windows.Forms.TextBox();
            this._supplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._searchtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._supplierTable = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this._statusOption.Location = new System.Drawing.Point(582, 16);
            this._statusOption.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._statusOption.Name = "_statusOption";
            this._statusOption.Size = new System.Drawing.Size(190, 27);
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
            this.panel1.Controls.Add(this._supplier);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(23, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 263);
            this.panel1.TabIndex = 2;
            // 
            // _save
            // 
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
            // 
            // _cancel
            // 
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
            this._contactnumber.Location = new System.Drawing.Point(157, 103);
            this._contactnumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._contactnumber.Name = "_contactnumber";
            this._contactnumber.Size = new System.Drawing.Size(441, 27);
            this._contactnumber.TabIndex = 7;
            // 
            // _address
            // 
            this._address.Location = new System.Drawing.Point(157, 148);
            this._address.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(441, 27);
            this._address.TabIndex = 6;
            // 
            // _contactperson
            // 
            this._contactperson.Location = new System.Drawing.Point(157, 59);
            this._contactperson.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._contactperson.Name = "_contactperson";
            this._contactperson.Size = new System.Drawing.Size(441, 27);
            this._contactperson.TabIndex = 5;
            // 
            // _supplier
            // 
            this._supplier.Location = new System.Drawing.Point(157, 14);
            this._supplier.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._supplier.Name = "_supplier";
            this._supplier.Size = new System.Drawing.Size(441, 27);
            this._supplier.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Person:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
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
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier:";
            // 
            // _searchtxt
            // 
            this._searchtxt.Font = new System.Drawing.Font("Bebas Neue", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._searchtxt.Location = new System.Drawing.Point(23, 12);
            this._searchtxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._searchtxt.Name = "_searchtxt";
            this._searchtxt.PlaceholderText = "Search....";
            this._searchtxt.Size = new System.Drawing.Size(605, 30);
            this._searchtxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(512, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._supplierTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._supplierTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._supplierTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column3});
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
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Supplier Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 103;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Contact Person";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 109;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Contact Number";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 111;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Address";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 65;
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
            this._Add.Click += new System.EventHandler(this._Add_Click);
            // 
            // SupplierManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
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
        private TextBox _supplier;
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
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column3;
    }
}