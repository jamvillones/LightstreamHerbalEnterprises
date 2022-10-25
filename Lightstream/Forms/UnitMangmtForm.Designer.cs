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
            this.label1 = new System.Windows.Forms.Label();
            this._UMTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._cancel = new System.Windows.Forms.Button();
            this._save = new System.Windows.Forms.Button();
            this._statusOption = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this._UMTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            // 
            // _UMTable
            // 
            this._UMTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._UMTable.BackgroundColor = System.Drawing.Color.White;
            this._UMTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._UMTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._UMTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this._UMTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._UMTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column2,
            this.Column3});
            this._UMTable.Location = new System.Drawing.Point(59, 72);
            this._UMTable.Name = "_UMTable";
            this._UMTable.RowTemplate.Height = 25;
            this._UMTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._UMTable.Size = new System.Drawing.Size(671, 204);
            this._UMTable.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Management";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            // 
            // _cancel
            // 
            this._cancel.Location = new System.Drawing.Point(633, 313);
            this._cancel.Name = "_cancel";
            this._cancel.Size = new System.Drawing.Size(97, 34);
            this._cancel.TabIndex = 2;
            this._cancel.Text = "Cancel";
            this._cancel.UseVisualStyleBackColor = true;
            // 
            // _save
            // 
            this._save.Location = new System.Drawing.Point(517, 313);
            this._save.Name = "_save";
            this._save.Size = new System.Drawing.Size(97, 34);
            this._save.TabIndex = 3;
            this._save.Text = "Save";
            this._save.UseVisualStyleBackColor = true;
            // 
            // _statusOption
            // 
            this._statusOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._statusOption.FormattingEnabled = true;
            this._statusOption.Location = new System.Drawing.Point(525, 36);
            this._statusOption.Name = "_statusOption";
            this._statusOption.Size = new System.Drawing.Size(205, 23);
            this._statusOption.TabIndex = 4;
            // 
            // UnitMangmtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._statusOption);
            this.Controls.Add(this._save);
            this.Controls.Add(this._cancel);
            this.Controls.Add(this._UMTable);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnitMangmtForm";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._UMTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView _UMTable;
        private Button _cancel;
        private Button _save;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private ComboBox _statusOption;
    }
}