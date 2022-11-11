namespace Lightstream.Forms
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
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
            this._IngredientsTable = new System.Windows.Forms.DataGridView();
            this._pick = new System.Windows.Forms.Button();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeCol = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this._IngredientsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // _save
            // 
            this._save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._save.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._save.ForeColor = System.Drawing.Color.Black;
            this._save.Location = new System.Drawing.Point(255, 417);
            this._save.Margin = new System.Windows.Forms.Padding(2);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(85, 30);
            this._save.TabIndex = 6;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = false;
            this._save.Click += new System.EventHandler(this._save_Click);
            // 
            // _cancel
            // 
            this._cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._cancel.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cancel.ForeColor = System.Drawing.Color.Black;
            this._cancel.Location = new System.Drawing.Point(343, 417);
            this._cancel.Margin = new System.Windows.Forms.Padding(2);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(85, 30);
            this._cancel.TabIndex = 7;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = false;
            this._cancel.Click += new System.EventHandler(this._cancel_Click);
            // 
            // _contactnumber
            // 
            this._contactnumber.Location = new System.Drawing.Point(96, 94);
            this._contactnumber.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this._contactnumber.Name = "_contactnumber";
            this._contactnumber.Size = new System.Drawing.Size(333, 23);
            this._contactnumber.TabIndex = 2;
            this._contactnumber.TextChanged += new System.EventHandler(this._supplierName_TextChanged);
            // 
            // _address
            // 
            this._address.Location = new System.Drawing.Point(96, 126);
            this._address.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this._address.Name = "_address";
            this._address.Size = new System.Drawing.Size(333, 23);
            this._address.TabIndex = 3;
            this._address.TextChanged += new System.EventHandler(this._supplierName_TextChanged);
            // 
            // _contactperson
            // 
            this._contactperson.Location = new System.Drawing.Point(96, 63);
            this._contactperson.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this._contactperson.Name = "_contactperson";
            this._contactperson.Size = new System.Drawing.Size(333, 23);
            this._contactperson.TabIndex = 1;
            this._contactperson.TextChanged += new System.EventHandler(this._supplierName_TextChanged);
            // 
            // _supplierName
            // 
            this._supplierName.Location = new System.Drawing.Point(96, 31);
            this._supplierName.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this._supplierName.Name = "_supplierName";
            this._supplierName.Size = new System.Drawing.Size(333, 23);
            this._supplierName.TabIndex = 0;
            this._supplierName.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contact Person:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Supplier:";
            // 
            // _IngredientsTable
            // 
            this._IngredientsTable.AllowUserToAddRows = false;
            this._IngredientsTable.AllowUserToDeleteRows = false;
            this._IngredientsTable.AllowUserToResizeRows = false;
            this._IngredientsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._IngredientsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this._IngredientsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._IngredientsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._IngredientsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._IngredientsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._IngredientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._IngredientsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCol,
            this.Column1,
            this.removeCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._IngredientsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this._IngredientsTable.EnableHeadersVisualStyles = false;
            this._IngredientsTable.Location = new System.Drawing.Point(18, 194);
            this._IngredientsTable.Margin = new System.Windows.Forms.Padding(2);
            this._IngredientsTable.MultiSelect = false;
            this._IngredientsTable.Name = "_IngredientsTable";
            this._IngredientsTable.ReadOnly = true;
            this._IngredientsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this._IngredientsTable.RowHeadersVisible = false;
            this._IngredientsTable.RowHeadersWidth = 62;
            this._IngredientsTable.RowTemplate.Height = 33;
            this._IngredientsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._IngredientsTable.Size = new System.Drawing.Size(410, 216);
            this._IngredientsTable.StandardTab = true;
            this._IngredientsTable.TabIndex = 5;
            this._IngredientsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this._IngredientsTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._IngredientsTable_CellMouseClick);
            // 
            // _pick
            // 
            this._pick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pick.BackColor = System.Drawing.SystemColors.Control;
            this._pick.FlatAppearance.BorderSize = 0;
            this._pick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._pick.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._pick.ForeColor = System.Drawing.Color.Black;
            this._pick.Location = new System.Drawing.Point(18, 157);
            this._pick.Margin = new System.Windows.Forms.Padding(2);
            this._pick.Name = "_pick";
            this._pick.Size = new System.Drawing.Size(410, 30);
            this._pick.TabIndex = 4;
            this._pick.Text = "Pick Ingredient";
            this._pick.UseVisualStyleBackColor = false;
            this._pick.Click += new System.EventHandler(this.button1_Click);
            // 
            // idCol
            // 
            this.idCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idCol.HeaderText = "Id";
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            this.idCol.Width = 22;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Ingredient";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // removeCol
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.IndianRed;
            this.removeCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.removeCol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeCol.HeaderText = "";
            this.removeCol.MinimumWidth = 60;
            this.removeCol.Name = "removeCol";
            this.removeCol.ReadOnly = true;
            this.removeCol.Text = "REMOVE";
            this.removeCol.UseColumnTextForButtonValue = true;
            this.removeCol.Width = 60;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 461);
            this.Controls.Add(this._pick);
            this.Controls.Add(this._IngredientsTable);
            this.Controls.Add(this._contactnumber);
            this.Controls.Add(this._address);
            this.Controls.Add(this._contactperson);
            this.Controls.Add(this._supplierName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cancel);
            this.Controls.Add(this._save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 500);
            this.Name = "SupplierForm";
            this.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Supplier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SupplierForm_FormClosing);
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._IngredientsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DataGridView _IngredientsTable;
        private Button _pick;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewButtonColumn removeCol;
    }
}