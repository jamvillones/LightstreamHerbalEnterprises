namespace Lightstream.Usercontrols
{
    partial class IngredientsPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this._ingredientsTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this._statusOption = new System.Windows.Forms.ComboBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._Add = new System.Windows.Forms.Button();
            this._archive_retrieve = new System.Windows.Forms.Button();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defCostCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this._ingredientsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ingredientsTable
            // 
            this._ingredientsTable.AllowUserToAddRows = false;
            this._ingredientsTable.AllowUserToDeleteRows = false;
            this._ingredientsTable.AllowUserToResizeRows = false;
            this._ingredientsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._ingredientsTable.BackgroundColor = System.Drawing.Color.White;
            this._ingredientsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._ingredientsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._ingredientsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._ingredientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._ingredientsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editCol,
            this.idCol,
            this.nameCol,
            this.qtyCol,
            this.unitCol,
            this.defCostCol,
            this.statusCol,
            this.deleteBtnCol});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._ingredientsTable.DefaultCellStyle = dataGridViewCellStyle9;
            this._ingredientsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ingredientsTable.EnableHeadersVisualStyles = false;
            this._ingredientsTable.Location = new System.Drawing.Point(30, 63);
            this._ingredientsTable.Margin = new System.Windows.Forms.Padding(0);
            this._ingredientsTable.MultiSelect = false;
            this._ingredientsTable.Name = "_ingredientsTable";
            this._ingredientsTable.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._ingredientsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this._ingredientsTable.RowHeadersVisible = false;
            this._ingredientsTable.RowHeadersWidth = 62;
            this._ingredientsTable.RowTemplate.Height = 25;
            this._ingredientsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._ingredientsTable.Size = new System.Drawing.Size(640, 267);
            this._ingredientsTable.TabIndex = 0;
            this._ingredientsTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._ingredientsTable_CellMouseClick);
            this._ingredientsTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this._ingredientsTable_RowsAdded);
            this._ingredientsTable.SelectionChanged += new System.EventHandler(this._ingredientsTable_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this._statusOption);
            this.panel1.Controls.Add(this.searchTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(30, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 33);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(428, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Filter:";
            // 
            // _statusOption
            // 
            this._statusOption.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._statusOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._statusOption.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._statusOption.FormattingEnabled = true;
            this._statusOption.Location = new System.Drawing.Point(475, 5);
            this._statusOption.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this._statusOption.Name = "_statusOption";
            this._statusOption.Size = new System.Drawing.Size(165, 23);
            this._statusOption.TabIndex = 14;
            this._statusOption.SelectedIndexChanged += new System.EventHandler(this._statusOption_SelectedIndexChanged);
            // 
            // searchTxt
            // 
            this.searchTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTxt.Location = new System.Drawing.Point(0, 7);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.PlaceholderText = "Search...";
            this.searchTxt.Size = new System.Drawing.Size(280, 18);
            this.searchTxt.TabIndex = 2;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            this.searchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTxt_KeyDown);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(640, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingredients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this._Add);
            this.flowLayoutPanel1.Controls.Add(this._archive_retrieve);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 330);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(640, 40);
            this.flowLayoutPanel1.TabIndex = 10;
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
            this._Add.Click += new System.EventHandler(this.addNewBtn_Click);
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
            // editCol
            // 
            this.editCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            this.editCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.editCol.HeaderText = "";
            this.editCol.MinimumWidth = 8;
            this.editCol.Name = "editCol";
            this.editCol.ReadOnly = true;
            this.editCol.Text = "EDIT";
            this.editCol.UseColumnTextForButtonValue = true;
            this.editCol.Width = 60;
            // 
            // idCol
            // 
            this.idCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idCol.DataPropertyName = "Id";
            dataGridViewCellStyle3.Format = "P {0:n}";
            dataGridViewCellStyle3.NullValue = null;
            this.idCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.idCol.HeaderText = "Id";
            this.idCol.MinimumWidth = 8;
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            this.idCol.Width = 25;
            // 
            // nameCol
            // 
            this.nameCol.DataPropertyName = "Name";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.nameCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.nameCol.HeaderText = "Name";
            this.nameCol.MinimumWidth = 8;
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            // 
            // qtyCol
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N4";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.qtyCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.qtyCol.HeaderText = "Qty In Stock";
            this.qtyCol.MinimumWidth = 8;
            this.qtyCol.Name = "qtyCol";
            this.qtyCol.ReadOnly = true;
            // 
            // unitCol
            // 
            this.unitCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitCol.DataPropertyName = "GetUnit";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.unitCol.DefaultCellStyle = dataGridViewCellStyle6;
            this.unitCol.HeaderText = "Unit";
            this.unitCol.MinimumWidth = 8;
            this.unitCol.Name = "unitCol";
            this.unitCol.ReadOnly = true;
            // 
            // defCostCol
            // 
            dataGridViewCellStyle7.Format = "₱ 0.00";
            this.defCostCol.DefaultCellStyle = dataGridViewCellStyle7;
            this.defCostCol.HeaderText = "Default Cost";
            this.defCostCol.Name = "defCostCol";
            this.defCostCol.ReadOnly = true;
            // 
            // statusCol
            // 
            this.statusCol.HeaderText = "Status";
            this.statusCol.Name = "statusCol";
            this.statusCol.ReadOnly = true;
            // 
            // deleteBtnCol
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Red;
            this.deleteBtnCol.DefaultCellStyle = dataGridViewCellStyle8;
            this.deleteBtnCol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtnCol.HeaderText = "";
            this.deleteBtnCol.MinimumWidth = 8;
            this.deleteBtnCol.Name = "deleteBtnCol";
            this.deleteBtnCol.ReadOnly = true;
            this.deleteBtnCol.Text = "REMOVE";
            this.deleteBtnCol.UseColumnTextForButtonValue = true;
            this.deleteBtnCol.Visible = false;
            // 
            // IngredientsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this._ingredientsTable);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IngredientsPage";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 30, 30);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.IngredientUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this._ingredientsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView _ingredientsTable;
        private Panel panel1;
        private TextBox searchTxt;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button _Add;
        private Button _archive_retrieve;
        private Label label5;
        private ComboBox _statusOption;
        private DataGridViewButtonColumn editCol;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn qtyCol;
        private DataGridViewTextBoxColumn unitCol;
        private DataGridViewTextBoxColumn defCostCol;
        private DataGridViewTextBoxColumn statusCol;
        private DataGridViewButtonColumn deleteBtnCol;
    }
}
