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
            this.label1 = new System.Windows.Forms.Label();
            this._UMTable = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._statusOption = new System.Windows.Forms.ComboBox();
            this._Add = new System.Windows.Forms.Button();
            this._Retrieve = new System.Windows.Forms.Button();
            this._Archive = new System.Windows.Forms.Button();
            this._Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._UMTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(744, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter:";
            // 
            // _UMTable
            // 
            this._UMTable.AllowUserToAddRows = false;
            this._UMTable.AllowUserToDeleteRows = false;
            this._UMTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._UMTable.BackgroundColor = System.Drawing.Color.White;
            this._UMTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._UMTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._UMTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._UMTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._UMTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._UMTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3});
            this._UMTable.Location = new System.Drawing.Point(98, 81);
            this._UMTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._UMTable.Name = "_UMTable";
            this._UMTable.ReadOnly = true;
            this._UMTable.RowHeadersVisible = false;
            this._UMTable.RowHeadersWidth = 62;
            this._UMTable.RowTemplate.Height = 25;
            this._UMTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._UMTable.Size = new System.Drawing.Size(959, 537);
            this._UMTable.TabIndex = 1;
            this._UMTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._UMTable_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Unit Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 167;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Description";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 129;
            // 
            // _statusOption
            // 
            this._statusOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._statusOption.Font = new System.Drawing.Font("Bebas Neue", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._statusOption.FormattingEnabled = true;
            this._statusOption.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this._statusOption.Location = new System.Drawing.Point(843, 13);
            this._statusOption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._statusOption.Name = "_statusOption";
            this._statusOption.Size = new System.Drawing.Size(214, 52);
            this._statusOption.TabIndex = 4;
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
            this.Controls.Add(this._statusOption);
            this.Controls.Add(this._UMTable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitMangmtForm";
            this.Padding = new System.Windows.Forms.Padding(29, 0, 29, 33);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._UMTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView _UMTable;
        private ComboBox _statusOption;
        private Button _Add;
        private Button _Retrieve;
        private Button _Archive;
        private Button _Update;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
    }
}