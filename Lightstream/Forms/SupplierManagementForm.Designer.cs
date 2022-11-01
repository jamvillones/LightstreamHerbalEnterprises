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
            this._statusOption = new System.Windows.Forms.ComboBox();
            this._supplierTable = new System.Windows.Forms.DataGridView();
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
            this._add = new System.Windows.Forms.Button();
            this._edit = new System.Windows.Forms.Button();
            this._archive = new System.Windows.Forms.Button();
            this._retrieve = new System.Windows.Forms.Button();
            this._searchtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._supplierTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _statusOption
            // 
            this._statusOption.FormattingEnabled = true;
            this._statusOption.Location = new System.Drawing.Point(344, 23);
            this._statusOption.Margin = new System.Windows.Forms.Padding(2);
            this._statusOption.Name = "_statusOption";
            this._statusOption.Size = new System.Drawing.Size(172, 23);
            this._statusOption.TabIndex = 0;
            // 
            // _supplierTable
            // 
            this._supplierTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._supplierTable.Location = new System.Drawing.Point(17, 211);
            this._supplierTable.Margin = new System.Windows.Forms.Padding(2);
            this._supplierTable.Name = "_supplierTable";
            this._supplierTable.RowHeadersWidth = 62;
            this._supplierTable.RowTemplate.Height = 33;
            this._supplierTable.Size = new System.Drawing.Size(396, 159);
            this._supplierTable.TabIndex = 1;
            this._supplierTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(23, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 128);
            this.panel1.TabIndex = 2;
            // 
            // _save
            // 
            this._save.BackColor = System.Drawing.Color.ForestGreen;
            this._save.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._save.ForeColor = System.Drawing.Color.White;
            this._save.Location = new System.Drawing.Point(341, 74);
            this._save.Margin = new System.Windows.Forms.Padding(2);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(88, 39);
            this._save.TabIndex = 9;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = false;
            // 
            // _cancel
            // 
            this._cancel.BackColor = System.Drawing.Color.ForestGreen;
            this._cancel.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cancel.ForeColor = System.Drawing.Color.White;
            this._cancel.Location = new System.Drawing.Point(341, 31);
            this._cancel.Margin = new System.Windows.Forms.Padding(2);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(88, 39);
            this._cancel.TabIndex = 8;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = false;
            // 
            // _contactnumber
            // 
            this._contactnumber.Location = new System.Drawing.Point(114, 90);
            this._contactnumber.Margin = new System.Windows.Forms.Padding(2);
            this._contactnumber.Name = "_contactnumber";
            this._contactnumber.Size = new System.Drawing.Size(212, 23);
            this._contactnumber.TabIndex = 7;
            // 
            // _address
            // 
            this._address.Location = new System.Drawing.Point(114, 37);
            this._address.Margin = new System.Windows.Forms.Padding(2);
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(212, 23);
            this._address.TabIndex = 6;
            // 
            // _contactperson
            // 
            this._contactperson.Location = new System.Drawing.Point(114, 68);
            this._contactperson.Margin = new System.Windows.Forms.Padding(2);
            this._contactperson.Name = "_contactperson";
            this._contactperson.Size = new System.Drawing.Size(212, 23);
            this._contactperson.TabIndex = 5;
            // 
            // _supplier
            // 
            this._supplier.Location = new System.Drawing.Point(113, 11);
            this._supplier.Margin = new System.Windows.Forms.Padding(2);
            this._supplier.Name = "_supplier";
            this._supplier.Size = new System.Drawing.Size(212, 23);
            this._supplier.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier";
            // 
            // _add
            // 
            this._add.BackColor = System.Drawing.Color.ForestGreen;
            this._add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._add.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._add.ForeColor = System.Drawing.Color.White;
            this._add.Location = new System.Drawing.Point(438, 211);
            this._add.Margin = new System.Windows.Forms.Padding(2);
            this._add.Name = "_add";
            this._add.Size = new System.Drawing.Size(87, 32);
            this._add.TabIndex = 3;
            this._add.Text = "Add";
            this._add.UseVisualStyleBackColor = false;
            // 
            // _edit
            // 
            this._edit.BackColor = System.Drawing.Color.ForestGreen;
            this._edit.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._edit.ForeColor = System.Drawing.Color.White;
            this._edit.Location = new System.Drawing.Point(438, 247);
            this._edit.Margin = new System.Windows.Forms.Padding(2);
            this._edit.Name = "_edit";
            this._edit.Size = new System.Drawing.Size(85, 32);
            this._edit.TabIndex = 4;
            this._edit.Text = "Edit";
            this._edit.UseVisualStyleBackColor = false;
            // 
            // _archive
            // 
            this._archive.BackColor = System.Drawing.Color.ForestGreen;
            this._archive.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._archive.ForeColor = System.Drawing.Color.White;
            this._archive.Location = new System.Drawing.Point(438, 295);
            this._archive.Margin = new System.Windows.Forms.Padding(2);
            this._archive.Name = "_archive";
            this._archive.Size = new System.Drawing.Size(85, 32);
            this._archive.TabIndex = 5;
            this._archive.Text = "Archive";
            this._archive.UseVisualStyleBackColor = false;
            // 
            // _retrieve
            // 
            this._retrieve.BackColor = System.Drawing.Color.ForestGreen;
            this._retrieve.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._retrieve.ForeColor = System.Drawing.Color.White;
            this._retrieve.Location = new System.Drawing.Point(438, 338);
            this._retrieve.Margin = new System.Windows.Forms.Padding(2);
            this._retrieve.Name = "_retrieve";
            this._retrieve.Size = new System.Drawing.Size(85, 32);
            this._retrieve.TabIndex = 6;
            this._retrieve.Text = "Retrieve";
            this._retrieve.UseVisualStyleBackColor = false;
            // 
            // _searchtxt
            // 
            this._searchtxt.Location = new System.Drawing.Point(23, 25);
            this._searchtxt.Margin = new System.Windows.Forms.Padding(2);
            this._searchtxt.Name = "_searchtxt";
            this._searchtxt.PlaceholderText = "Search....";
            this._searchtxt.Size = new System.Drawing.Size(196, 23);
            this._searchtxt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status";
            // 
            // SupplierManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 399);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this._searchtxt);
            this.Controls.Add(this._retrieve);
            this.Controls.Add(this._archive);
            this.Controls.Add(this._edit);
            this.Controls.Add(this._add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._supplierTable);
            this.Controls.Add(this._statusOption);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SupplierManagement";
            this.Text = "FSupplierManagement";
            ((System.ComponentModel.ISupportInitialize)(this._supplierTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox _statusOption;
        private DataGridView _supplierTable;
        private Panel panel1;
        private Button _add;
        private Button _edit;
        private Button _archive;
        private Button _retrieve;
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
    }
}