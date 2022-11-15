using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.Forms
{
    partial class ViewStockForm
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStockForm));
            this._variantsTable = new System.Windows.Forms.DataGridView();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addStockCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this._stockinsTable = new System.Windows.Forms.DataGridView();
            this.stockinQtyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateProducedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockRemoveCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._variantsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._stockinsTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // _variantsTable
            // 
            this._variantsTable.AllowUserToAddRows = false;
            this._variantsTable.AllowUserToDeleteRows = false;
            this._variantsTable.AllowUserToResizeRows = false;
            this._variantsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._variantsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this._variantsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._variantsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._variantsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._variantsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._variantsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameCol,
            this.stockCol,
            this.addStockCol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._variantsTable.DefaultCellStyle = dataGridViewCellStyle2;
            this._variantsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._variantsTable.EnableHeadersVisualStyles = false;
            this._variantsTable.Location = new System.Drawing.Point(10, 40);
            this._variantsTable.Margin = new System.Windows.Forms.Padding(10);
            this._variantsTable.MultiSelect = false;
            this._variantsTable.Name = "_variantsTable";
            this._variantsTable.ReadOnly = true;
            this._variantsTable.RowHeadersVisible = false;
            this._variantsTable.RowHeadersWidth = 62;
            this._variantsTable.RowTemplate.Height = 25;
            this._variantsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._variantsTable.Size = new System.Drawing.Size(299, 411);
            this._variantsTable.StandardTab = true;
            this._variantsTable.TabIndex = 10;
            this._variantsTable.SelectionChanged += new System.EventHandler(this._variantsTable_SelectionChanged);
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            // 
            // stockCol
            // 
            this.stockCol.HeaderText = "Stocks Qty";
            this.stockCol.Name = "stockCol";
            this.stockCol.ReadOnly = true;
            // 
            // addStockCol
            // 
            this.addStockCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.addStockCol.HeaderText = "";
            this.addStockCol.MinimumWidth = 100;
            this.addStockCol.Name = "addStockCol";
            this.addStockCol.ReadOnly = true;
            this.addStockCol.Text = "Add Stock";
            this.addStockCol.UseColumnTextForButtonValue = true;
            this.addStockCol.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 20);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._variantsTable);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._stockinsTable);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(721, 461);
            this.splitContainer1.SplitterDistance = 319;
            this.splitContainer1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Variants";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _stockinsTable
            // 
            this._stockinsTable.AllowUserToAddRows = false;
            this._stockinsTable.AllowUserToDeleteRows = false;
            this._stockinsTable.AllowUserToResizeRows = false;
            this._stockinsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._stockinsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this._stockinsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._stockinsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._stockinsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._stockinsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._stockinsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockinQtyCol,
            this.dateProducedCol,
            this.stockRemoveCol});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(180)))), ((int)(((byte)(114)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._stockinsTable.DefaultCellStyle = dataGridViewCellStyle6;
            this._stockinsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this._stockinsTable.EnableHeadersVisualStyles = false;
            this._stockinsTable.Location = new System.Drawing.Point(10, 40);
            this._stockinsTable.Margin = new System.Windows.Forms.Padding(10);
            this._stockinsTable.MultiSelect = false;
            this._stockinsTable.Name = "_stockinsTable";
            this._stockinsTable.ReadOnly = true;
            this._stockinsTable.RowHeadersVisible = false;
            this._stockinsTable.RowHeadersWidth = 62;
            this._stockinsTable.RowTemplate.Height = 25;
            this._stockinsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._stockinsTable.Size = new System.Drawing.Size(378, 322);
            this._stockinsTable.StandardTab = true;
            this._stockinsTable.TabIndex = 11;
            this._stockinsTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._stockinsTable_CellMouseClick);
            this._stockinsTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this._stockinsTable_RowsAdded);
            // 
            // stockinQtyCol
            // 
            dataGridViewCellStyle4.NullValue = null;
            this.stockinQtyCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.stockinQtyCol.HeaderText = "Qty";
            this.stockinQtyCol.Name = "stockinQtyCol";
            this.stockinQtyCol.ReadOnly = true;
            // 
            // dateProducedCol
            // 
            dataGridViewCellStyle5.Format = "MMM d, yyyy h:mm tt";
            dataGridViewCellStyle5.NullValue = null;
            this.dateProducedCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.dateProducedCol.HeaderText = "Date Produced";
            this.dateProducedCol.Name = "dateProducedCol";
            this.dateProducedCol.ReadOnly = true;
            // 
            // stockRemoveCol
            // 
            this.stockRemoveCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stockRemoveCol.HeaderText = "";
            this.stockRemoveCol.MinimumWidth = 60;
            this.stockRemoveCol.Name = "stockRemoveCol";
            this.stockRemoveCol.ReadOnly = true;
            this.stockRemoveCol.Text = "Remove";
            this.stockRemoveCol.UseColumnTextForButtonValue = true;
            this.stockRemoveCol.Width = 60;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 29);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Production Qty:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(101, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(274, 23);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ThousandsSeparator = true;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("The Bold Font", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Production Log";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(10, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(378, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "Produce";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(10, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(378, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "Save Changes";
            this.toolTip1.SetToolTip(this.button2, "Saves newly added production(marked in gray)");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewStockForm
            // 
            this.ClientSize = new System.Drawing.Size(761, 501);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ViewStockForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Stock";
            this.Load += new System.EventHandler(this.ViewStockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._variantsTable)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._stockinsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        private DataGridView _variantsTable;
        private SplitContainer splitContainer1;
        private DataGridView _stockinsTable;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn nameCol;
        private DataGridViewTextBoxColumn stockCol;
        private DataGridViewButtonColumn addStockCol;
        private DataGridViewTextBoxColumn stockinQtyCol;
        private DataGridViewTextBoxColumn dateProducedCol;
        private DataGridViewButtonColumn stockRemoveCol;
    }
}
