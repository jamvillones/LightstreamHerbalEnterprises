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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this._ingredientsTable = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtnCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this._create = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._ingredientsTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ingredientsTable
            // 
            this._ingredientsTable.AllowUserToAddRows = false;
            this._ingredientsTable.AllowUserToDeleteRows = false;
            this._ingredientsTable.AllowUserToResizeRows = false;
            this._ingredientsTable.BackgroundColor = System.Drawing.Color.White;
            this._ingredientsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._ingredientsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this._ingredientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._ingredientsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.editCol,
            this.deleteBtnCol});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._ingredientsTable.DefaultCellStyle = dataGridViewCellStyle10;
            this._ingredientsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ingredientsTable.EnableHeadersVisualStyles = false;
            this._ingredientsTable.Location = new System.Drawing.Point(35, 40);
            this._ingredientsTable.Margin = new System.Windows.Forms.Padding(10);
            this._ingredientsTable.MultiSelect = false;
            this._ingredientsTable.Name = "_ingredientsTable";
            this._ingredientsTable.ReadOnly = true;
            this._ingredientsTable.RowHeadersVisible = false;
            this._ingredientsTable.RowTemplate.Height = 25;
            this._ingredientsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._ingredientsTable.Size = new System.Drawing.Size(630, 300);
            this._ingredientsTable.TabIndex = 0;
            this._ingredientsTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._ingredientsTable_CellMouseClick);
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.ToolTipText = "Select";
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GetFormattedCost";
            this.Column3.HeaderText = "Cost";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "GetUnit";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column4.HeaderText = "Unit of Measurement";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // editCol
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Blue;
            this.editCol.DefaultCellStyle = dataGridViewCellStyle8;
            this.editCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCol.HeaderText = "";
            this.editCol.Name = "editCol";
            this.editCol.ReadOnly = true;
            this.editCol.Text = "EDIT";
            this.editCol.UseColumnTextForButtonValue = true;
            this.editCol.Width = 60;
            // 
            // deleteBtnCol
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Red;
            this.deleteBtnCol.DefaultCellStyle = dataGridViewCellStyle9;
            this.deleteBtnCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtnCol.HeaderText = "";
            this.deleteBtnCol.Name = "deleteBtnCol";
            this.deleteBtnCol.ReadOnly = true;
            this.deleteBtnCol.Text = "DELETE";
            this.deleteBtnCol.UseColumnTextForButtonValue = true;
            this.deleteBtnCol.Width = 60;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this._create);
            this.panel1.Controls.Add(this.searchTxt);
            this.panel1.Controls.Add(this._ingredientsTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(35, 40, 35, 35);
            this.panel1.Size = new System.Drawing.Size(700, 375);
            this.panel1.TabIndex = 1;
            // 
            // _create
            // 
            this._create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._create.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this._create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._create.Font = new System.Drawing.Font("Bebas Neue", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._create.ForeColor = System.Drawing.Color.Black;
            this._create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._create.Location = new System.Drawing.Point(545, 3);
            this._create.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._create.Name = "_create";
            this._create.Size = new System.Drawing.Size(120, 30);
            this._create.TabIndex = 5;
            this._create.Text = "Create";
            this._create.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._create.UseVisualStyleBackColor = false;
            this._create.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Location = new System.Drawing.Point(35, 10);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(10);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.PlaceholderText = "Search...";
            this.searchTxt.Size = new System.Drawing.Size(280, 16);
            this.searchTxt.TabIndex = 2;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            this.searchTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTxt_KeyDown);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(700, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingredients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IngredientsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IngredientsPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.IngredientUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this._ingredientsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView _ingredientsTable;
        private Panel panel1;
        private TextBox searchTxt;
        private Label label1;
        private Button _create;
        private DataGridViewCheckBoxColumn Column6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn editCol;
        private DataGridViewButtonColumn deleteBtnCol;
    }
}
