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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            this._ingredientsTable = new System.Windows.Forms.DataGridView();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defCostCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this._statusOption = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._Add = new System.Windows.Forms.Button();
            this._archive_retrieve = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
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
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._ingredientsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
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
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._ingredientsTable.DefaultCellStyle = dataGridViewCellStyle39;
            this._ingredientsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ingredientsTable.EnableHeadersVisualStyles = false;
            this._ingredientsTable.Location = new System.Drawing.Point(30, 69);
            this._ingredientsTable.Margin = new System.Windows.Forms.Padding(0);
            this._ingredientsTable.MultiSelect = false;
            this._ingredientsTable.Name = "_ingredientsTable";
            this._ingredientsTable.ReadOnly = true;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._ingredientsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this._ingredientsTable.RowHeadersVisible = false;
            this._ingredientsTable.RowHeadersWidth = 62;
            this._ingredientsTable.RowTemplate.Height = 25;
            this._ingredientsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._ingredientsTable.Size = new System.Drawing.Size(640, 261);
            this._ingredientsTable.TabIndex = 0;
            this._ingredientsTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._ingredientsTable_CellMouseClick);
            this._ingredientsTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this._ingredientsTable_RowsAdded);
            this._ingredientsTable.SelectionChanged += new System.EventHandler(this._ingredientsTable_SelectionChanged);
            // 
            // editCol
            // 
            this.editCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Blue;
            this.editCol.DefaultCellStyle = dataGridViewCellStyle32;
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
            dataGridViewCellStyle33.Format = "P {0:n}";
            dataGridViewCellStyle33.NullValue = null;
            this.idCol.DefaultCellStyle = dataGridViewCellStyle33;
            this.idCol.HeaderText = "Id";
            this.idCol.MinimumWidth = 8;
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Visible = false;
            // 
            // nameCol
            // 
            this.nameCol.DataPropertyName = "Name";
            dataGridViewCellStyle34.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.nameCol.DefaultCellStyle = dataGridViewCellStyle34;
            this.nameCol.HeaderText = "Name";
            this.nameCol.MinimumWidth = 8;
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            // 
            // qtyCol
            // 
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle35.Format = "#,#0.####";
            dataGridViewCellStyle35.NullValue = "0";
            dataGridViewCellStyle35.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.qtyCol.DefaultCellStyle = dataGridViewCellStyle35;
            this.qtyCol.HeaderText = "Qty In Stock";
            this.qtyCol.MinimumWidth = 8;
            this.qtyCol.Name = "qtyCol";
            this.qtyCol.ReadOnly = true;
            // 
            // unitCol
            // 
            this.unitCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitCol.DataPropertyName = "GetUnit";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.unitCol.DefaultCellStyle = dataGridViewCellStyle36;
            this.unitCol.HeaderText = "Unit";
            this.unitCol.MinimumWidth = 8;
            this.unitCol.Name = "unitCol";
            this.unitCol.ReadOnly = true;
            // 
            // defCostCol
            // 
            dataGridViewCellStyle37.Format = "₱ #,#0.00";
            this.defCostCol.DefaultCellStyle = dataGridViewCellStyle37;
            this.defCostCol.HeaderText = "Default Cost";
            this.defCostCol.Name = "defCostCol";
            this.defCostCol.ReadOnly = true;
            // 
            // statusCol
            // 
            this.statusCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.statusCol.HeaderText = "Status";
            this.statusCol.Name = "statusCol";
            this.statusCol.ReadOnly = true;
            this.statusCol.Width = 69;
            // 
            // deleteBtnCol
            // 
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.Red;
            this.deleteBtnCol.DefaultCellStyle = dataGridViewCellStyle38;
            this.deleteBtnCol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtnCol.HeaderText = "";
            this.deleteBtnCol.MinimumWidth = 8;
            this.deleteBtnCol.Name = "deleteBtnCol";
            this.deleteBtnCol.ReadOnly = true;
            this.deleteBtnCol.Text = "REMOVE";
            this.deleteBtnCol.UseColumnTextForButtonValue = true;
            this.deleteBtnCol.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.searchTxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this._statusOption);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(30, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 39);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(428, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Filter:";
            // 
            // _statusOption
            // 
            this._statusOption.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._statusOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._statusOption.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._statusOption.FormattingEnabled = true;
            this._statusOption.Location = new System.Drawing.Point(475, 8);
            this._statusOption.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this._statusOption.Name = "_statusOption";
            this._statusOption.Size = new System.Drawing.Size(165, 23);
            this._statusOption.TabIndex = 14;
            this._statusOption.SelectedIndexChanged += new System.EventHandler(this._statusOption_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Name = "label1";
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
            // searchTxt
            // 
            this.searchTxt.AcceptsReturn = true;
            this.searchTxt.BackColor = System.Drawing.SystemColors.Control;
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchTxt.Location = new System.Drawing.Point(0, 5);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.PlaceholderText = "Search...";
            this.searchTxt.Size = new System.Drawing.Size(300, 29);
            this.searchTxt.TabIndex = 16;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            this.searchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTxt_KeyDown);
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
        private TextBox searchTxt;
    }
}
