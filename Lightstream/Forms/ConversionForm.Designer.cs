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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversionForm));
            this.button1 = new System.Windows.Forms.Button();
            this._fromOpt = new System.Windows.Forms.ComboBox();
            this._toOpt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._conversionValue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._backConversionValue = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._conversionValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._backConversionValue)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(25, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(403, 30);
            this.button1.TabIndex = 12;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // _fromOpt
            // 
            this._fromOpt.DisplayMember = "Name";
            this._fromOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._fromOpt.FormattingEnabled = true;
            this._fromOpt.Location = new System.Drawing.Point(25, 31);
            this._fromOpt.Margin = new System.Windows.Forms.Padding(2);
            this._fromOpt.Name = "_fromOpt";
            this._fromOpt.Size = new System.Drawing.Size(190, 23);
            this._fromOpt.TabIndex = 20;
            this._fromOpt.ValueMember = "Id";
            // 
            // _toOpt
            // 
            this._toOpt.DisplayMember = "Name";
            this._toOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._toOpt.FormattingEnabled = true;
            this._toOpt.Location = new System.Drawing.Point(238, 31);
            this._toOpt.Margin = new System.Windows.Forms.Padding(2);
            this._toOpt.Name = "_toOpt";
            this._toOpt.Size = new System.Drawing.Size(190, 23);
            this._toOpt.TabIndex = 21;
            this._toOpt.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Unit A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(238, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Unit B";
            // 
            // _conversionValue
            // 
            this._conversionValue.DecimalPlaces = 2;
            this._conversionValue.Location = new System.Drawing.Point(118, 84);
            this._conversionValue.Margin = new System.Windows.Forms.Padding(2);
            this._conversionValue.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this._conversionValue.Name = "_conversionValue";
            this._conversionValue.Size = new System.Drawing.Size(310, 23);
            this._conversionValue.TabIndex = 24;
            this._conversionValue.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "A TO B CONVERSION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "B TO A CONVERSION";
            // 
            // _backConversionValue
            // 
            this._backConversionValue.DecimalPlaces = 2;
            this._backConversionValue.Location = new System.Drawing.Point(118, 123);
            this._backConversionValue.Margin = new System.Windows.Forms.Padding(2);
            this._backConversionValue.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this._backConversionValue.Name = "_backConversionValue";
            this._backConversionValue.Size = new System.Drawing.Size(310, 23);
            this._backConversionValue.TabIndex = 26;
            this._backConversionValue.ThousandsSeparator = true;
            // 
            // ConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 217);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._backConversionValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._conversionValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._toOpt);
            this.Controls.Add(this._fromOpt);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConversionForm";
            this.Text = "Conversion";
            this.Load += new System.EventHandler(this.ConversionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._conversionValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._backConversionValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private ComboBox _fromOpt;
        private ComboBox _toOpt;
        private Label label1;
        private Label label2;
        private NumericUpDown _conversionValue;
        private Label label3;
        private Label label4;
        private NumericUpDown _backConversionValue;
        private ToolTip toolTip1;
    }
}