namespace Lightstream.Forms
{
    partial class ConversionForm
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
            this._convertFromOpt = new System.Windows.Forms.ComboBox();
            this._convertToOpt = new System.Windows.Forms.ComboBox();
            this._0_Value = new System.Windows.Forms.NumericUpDown();
            this._1_ValueOption = new System.Windows.Forms.NumericUpDown();
            this._convertBackToOpt = new System.Windows.Forms.ComboBox();
            this._convertBackfromOpt = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._0_Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_ValueOption)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // _0_fromOpt
            // 
            this._convertFromOpt.DisplayMember = "Name";
            this._convertFromOpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this._convertFromOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._convertFromOpt.FormattingEnabled = true;
            this._convertFromOpt.Location = new System.Drawing.Point(5, 16);
            this._convertFromOpt.Margin = new System.Windows.Forms.Padding(2);
            this._convertFromOpt.Name = "_0_fromOpt";
            this._convertFromOpt.Size = new System.Drawing.Size(190, 23);
            this._convertFromOpt.TabIndex = 1;
            this._convertFromOpt.ValueMember = "Id";
            // 
            // _0_ToOpt
            // 
            this._convertToOpt.DisplayMember = "Name";
            this._convertToOpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this._convertToOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._convertToOpt.FormattingEnabled = true;
            this._convertToOpt.Location = new System.Drawing.Point(5, 16);
            this._convertToOpt.Margin = new System.Windows.Forms.Padding(2);
            this._convertToOpt.Name = "_0_ToOpt";
            this._convertToOpt.Size = new System.Drawing.Size(190, 23);
            this._convertToOpt.TabIndex = 3;
            this._convertToOpt.ValueMember = "Id";
            // 
            // _0_Value
            // 
            this._0_Value.DecimalPlaces = 4;
            this._0_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this._0_Value.Location = new System.Drawing.Point(5, 16);
            this._0_Value.Margin = new System.Windows.Forms.Padding(2);
            this._0_Value.Name = "_0_Value";
            this._0_Value.Size = new System.Drawing.Size(190, 23);
            this._0_Value.TabIndex = 4;
            // 
            // _1_ValueOption
            // 
            this._1_ValueOption.DecimalPlaces = 4;
            this._1_ValueOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this._1_ValueOption.Location = new System.Drawing.Point(5, 16);
            this._1_ValueOption.Margin = new System.Windows.Forms.Padding(2);
            this._1_ValueOption.Name = "_1_ValueOption";
            this._1_ValueOption.Size = new System.Drawing.Size(190, 23);
            this._1_ValueOption.TabIndex = 10;
            // 
            // _1_ToOpt
            // 
            this._convertBackToOpt.DisplayMember = "Name";
            this._convertBackToOpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this._convertBackToOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._convertBackToOpt.FormattingEnabled = true;
            this._convertBackToOpt.Location = new System.Drawing.Point(5, 16);
            this._convertBackToOpt.Margin = new System.Windows.Forms.Padding(2);
            this._convertBackToOpt.Name = "_1_ToOpt";
            this._convertBackToOpt.Size = new System.Drawing.Size(190, 23);
            this._convertBackToOpt.TabIndex = 9;
            this._convertBackToOpt.ValueMember = "Id";
            // 
            // _1_fromOpt
            // 
            this._convertBackfromOpt.DisplayMember = "Name";
            this._convertBackfromOpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this._convertBackfromOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._convertBackfromOpt.FormattingEnabled = true;
            this._convertBackfromOpt.Location = new System.Drawing.Point(5, 16);
            this._convertBackfromOpt.Margin = new System.Windows.Forms.Padding(2);
            this._convertBackfromOpt.Name = "_1_fromOpt";
            this._convertBackfromOpt.Size = new System.Drawing.Size(190, 23);
            this._convertBackfromOpt.TabIndex = 7;
            this._convertBackfromOpt.ValueMember = "Id";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(20, 179);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(413, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._convertFromOpt);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(200, 45);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._convertToOpt);
            this.groupBox2.Location = new System.Drawing.Point(20, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size(200, 45);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._0_Value);
            this.groupBox3.Location = new System.Drawing.Point(20, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.groupBox3.Size = new System.Drawing.Size(200, 45);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Value";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._convertBackfromOpt);
            this.groupBox4.Location = new System.Drawing.Point(233, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.groupBox4.Size = new System.Drawing.Size(200, 45);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "From";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this._convertBackToOpt);
            this.groupBox5.Location = new System.Drawing.Point(233, 63);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.groupBox5.Size = new System.Drawing.Size(200, 45);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "To";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this._1_ValueOption);
            this.groupBox6.Location = new System.Drawing.Point(233, 114);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.groupBox6.Size = new System.Drawing.Size(200, 45);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Value";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(226, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 156);
            this.panel1.TabIndex = 19;
            // 
            // ConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 220);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConversionForm";
            this.Text = "Conversion";
            this.Load += new System.EventHandler(this.ConversionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._0_Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._1_ValueOption)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBox _convertFromOpt;
        private ComboBox _convertToOpt;
        private NumericUpDown _0_Value;
        private NumericUpDown _1_ValueOption;
        private ComboBox _convertBackToOpt;
        private ComboBox _convertBackfromOpt;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Panel panel1;
    }
}