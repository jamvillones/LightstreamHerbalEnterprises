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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientsPage));
            this._ingredientsTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this._delete = new System.Windows.Forms.Button();
            this._edit = new System.Windows.Forms.Button();
            this._create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._ingredientsTable)).BeginInit();
            this.ingredientActions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ingredientsTable
            // 
            this._ingredientsTable.AllowUserToAddRows = false;
            this._ingredientsTable.AllowUserToDeleteRows = false;
            this._ingredientsTable.AllowUserToResizeRows = false;
            this._ingredientsTable.BackgroundColor = System.Drawing.Color.White;
            this._ingredientsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._ingredientsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._ingredientsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._ingredientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._ingredientsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(144)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._ingredientsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this._ingredientsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ingredientsTable.EnableHeadersVisualStyles = false;
            this._ingredientsTable.Location = new System.Drawing.Point(10, 40);
            this._ingredientsTable.Margin = new System.Windows.Forms.Padding(10);
            this._ingredientsTable.MultiSelect = false;
            this._ingredientsTable.Name = "_ingredientsTable";
            this._ingredientsTable.ReadOnly = true;
            this._ingredientsTable.RowHeadersVisible = false;
            this._ingredientsTable.RowTemplate.Height = 25;
            this._ingredientsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._ingredientsTable.Size = new System.Drawing.Size(460, 325);
            this._ingredientsTable.TabIndex = 0;
            //this._ingredientsTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ingredientsTable_CellMouseClick);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Unit of Measurement";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ingredientActions
            // 
            this.ingredientActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.showToolStripMenuItem});
            this.ingredientActions.Name = "contextMenuStrip1";
            this.ingredientActions.Size = new System.Drawing.Size(108, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.searchTxt);
            this.panel1.Controls.Add(this._ingredientsTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(120, 25);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 40, 10, 10);
            this.panel1.Size = new System.Drawing.Size(480, 375);
            this.panel1.TabIndex = 1;
            // 
            // searchTxt
            // 
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Location = new System.Drawing.Point(10, 10);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(10);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.PlaceholderText = "Search...";
            this.searchTxt.Size = new System.Drawing.Size(281, 16);
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
            this.label1.Size = new System.Drawing.Size(600, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingredients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._delete);
            this.panel2.Controls.Add(this._edit);
            this.panel2.Controls.Add(this._create);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 375);
            this.panel2.TabIndex = 10;
            // 
            // _delete
            // 
            this._delete.Dock = System.Windows.Forms.DockStyle.Top;
            this._delete.FlatAppearance.BorderSize = 0;
            this._delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._delete.Font = new System.Drawing.Font("The Bold Font", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._delete.ForeColor = System.Drawing.Color.Maroon;
            this._delete.Image = ((System.Drawing.Image)(resources.GetObject("_delete.Image")));
            this._delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._delete.Location = new System.Drawing.Point(0, 80);
            this._delete.Name = "_delete";
            this._delete.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._delete.Size = new System.Drawing.Size(120, 40);
            this._delete.TabIndex = 7;
            this._delete.Text = "Remove";
            this._delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._delete.UseVisualStyleBackColor = true;
            this._delete.Click += new System.EventHandler(this._delete_Click);
            // 
            // _edit
            // 
            this._edit.Dock = System.Windows.Forms.DockStyle.Top;
            this._edit.FlatAppearance.BorderSize = 0;
            this._edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._edit.Font = new System.Drawing.Font("The Bold Font", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this._edit.Image = ((System.Drawing.Image)(resources.GetObject("_edit.Image")));
            this._edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._edit.Location = new System.Drawing.Point(0, 40);
            this._edit.Name = "_edit";
            this._edit.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._edit.Size = new System.Drawing.Size(120, 40);
            this._edit.TabIndex = 6;
            this._edit.Text = "Edit";
            this._edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._edit.UseVisualStyleBackColor = true;
            // 
            // _create
            // 
            this._create.Dock = System.Windows.Forms.DockStyle.Top;
            this._create.FlatAppearance.BorderSize = 0;
            this._create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._create.Font = new System.Drawing.Font("The Bold Font", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._create.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(120)))), ((int)(((byte)(37)))));
            this._create.Image = ((System.Drawing.Image)(resources.GetObject("_create.Image")));
            this._create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._create.Location = new System.Drawing.Point(0, 0);
            this._create.Name = "_create";
            this._create.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._create.Size = new System.Drawing.Size(120, 40);
            this._create.TabIndex = 5;
            this._create.Text = "Create";
            this._create.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._create.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._create.UseVisualStyleBackColor = true;
            this._create.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // IngredientsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IngredientsPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.IngredientUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this._ingredientsTable)).EndInit();
            this.ingredientActions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView _ingredientsTable;
        private Panel panel1;
        private TextBox searchTxt;
        private ContextMenuStrip ingredientActions;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem showToolStripMenuItem;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label1;
        private Panel panel2;
        private Button _delete;
        private Button _edit;
        private Button _create;
    }
}
