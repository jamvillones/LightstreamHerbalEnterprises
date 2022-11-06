namespace Lightstream.Forms
{
    partial class UnitMangmtForm
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
            this._unitsTable = new System.Windows.Forms.DataGridView();
            this._Add = new System.Windows.Forms.Button();
            this._Retrieve = new System.Windows.Forms.Button();
            this._Archive = new System.Windows.Forms.Button();
            this._Update = new System.Windows.Forms.Button();
            this._unitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._unitDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._unitsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // _unitsTable
            // 
            this._unitsTable.AllowUserToAddRows = false;
            this._unitsTable.AllowUserToDeleteRows = false;
            this._unitsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._unitsTable.BackgroundColor = System.Drawing.Color.White;
            this._unitsTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._unitsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._unitsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._unitsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._unitsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._unitsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._unitName,
            this._unitDesc});
            this._unitsTable.Location = new System.Drawing.Point(98, 81);
            this._unitsTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._unitsTable.Name = "_unitsTable";
            this._unitsTable.ReadOnly = true;
            this._unitsTable.RowHeadersVisible = false;
            this._unitsTable.RowHeadersWidth = 62;
            this._unitsTable.RowTemplate.Height = 25;
            this._unitsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._unitsTable.Size = new System.Drawing.Size(959, 537);
            this._unitsTable.TabIndex = 1;
            this._unitsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._UMTable_CellContentClick);
            // 
            // _Add
            // 
            this._Add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Add.BackColor = System.Drawing.Color.ForestGreen;
            this._Add.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Add.ForeColor = System.Drawing.Color.White;
            this._Add.Location = new System.Drawing.Point(297, 655);
            this._Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._Add.Name = "_Add";
            this._Add.Size = new System.Drawing.Size(139, 57);
            this._Add.TabIndex = 5;
            this._Add.Text = "Add";
            this._Add.UseVisualStyleBackColor = false;
            this._Add.Click += new System.EventHandler(this._Add_Click);
            // 
            // _Retrieve
            // 
            this._Retrieve.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Retrieve.BackColor = System.Drawing.Color.ForestGreen;
            this._Retrieve.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Retrieve.ForeColor = System.Drawing.Color.White;
            this._Retrieve.Location = new System.Drawing.Point(738, 655);
            this._Retrieve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._Retrieve.Name = "_Retrieve";
            this._Retrieve.Size = new System.Drawing.Size(139, 57);
            this._Retrieve.TabIndex = 6;
            this._Retrieve.Text = "Retrieve";
            this._Retrieve.UseVisualStyleBackColor = false;
            // 
            // _Archive
            // 
            this._Archive.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Archive.BackColor = System.Drawing.Color.ForestGreen;
            this._Archive.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Archive.ForeColor = System.Drawing.Color.White;
            this._Archive.Location = new System.Drawing.Point(591, 655);
            this._Archive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._Archive.Name = "_Archive";
            this._Archive.Size = new System.Drawing.Size(139, 57);
            this._Archive.TabIndex = 7;
            this._Archive.Text = "Archive";
            this._Archive.UseVisualStyleBackColor = false;
            // 
            // _Update
            // 
            this._Update.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._Update.BackColor = System.Drawing.Color.ForestGreen;
            this._Update.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._Update.ForeColor = System.Drawing.Color.White;
            this._Update.Location = new System.Drawing.Point(444, 655);
            this._Update.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._Update.Name = "_Update";
            this._Update.Size = new System.Drawing.Size(139, 57);
            this._Update.TabIndex = 8;
            this._Update.Text = "Update";
            this._Update.UseVisualStyleBackColor = false;
            this._Update.Click += new System.EventHandler(this._Update_Click);
            // 
            // _unitName
            // 
            this._unitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this._unitName.HeaderText = "Unit Name";
            this._unitName.MinimumWidth = 8;
            this._unitName.Name = "_unitName";
            this._unitName.ReadOnly = true;
            this._unitName.Width = 167;
            // 
            // _unitDesc
            // 
            this._unitDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._unitDesc.HeaderText = "Description";
            this._unitDesc.MinimumWidth = 8;
            this._unitDesc.Name = "_unitDesc";
            this._unitDesc.ReadOnly = true;
            // 
            // UnitMangmtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this._Update);
            this.Controls.Add(this._Archive);
            this.Controls.Add(this._Retrieve);
            this.Controls.Add(this._Add);
            this.Controls.Add(this._unitsTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitMangmtForm";
            this.Padding = new System.Windows.Forms.Padding(29, 0, 29, 33);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UnitMangmtForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._unitsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView _unitsTable;
        private Button _Add;
        private Button _Retrieve;
        private Button _Archive;
        private Button _Update;
        private DataGridViewTextBoxColumn _unitName;
        private DataGridViewTextBoxColumn _unitDesc;
    }
}