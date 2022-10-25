namespace Lightstream
{
    partial class FPOS
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
            this.labelProductname = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxProdName = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.PAYbutton = new System.Windows.Forms.Button();
            this.DELETEbutton = new System.Windows.Forms.Button();
            this.CANCELbutton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ProdCH = new System.Windows.Forms.ColumnHeader();
            this.DescCH = new System.Windows.Forms.ColumnHeader();
            this.PriceCH = new System.Windows.Forms.ColumnHeader();
            this.RETURNbtn = new System.Windows.Forms.Button();
            this.QUEUEbtn = new System.Windows.Forms.Button();
            this.Totallbl = new System.Windows.Forms.Label();
            this.Discountlbl = new System.Windows.Forms.Label();
            this.VATlbl = new System.Windows.Forms.Label();
            this.GrandTotallbl = new System.Windows.Forms.Label();
            this.cashlbl = new System.Windows.Forms.Label();
            this.changelbl = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.TOTALtextBox = new System.Windows.Forms.TextBox();
            this.DISCOUNTtextBox = new System.Windows.Forms.TextBox();
            this.VATtextBox = new System.Windows.Forms.TextBox();
            this.GRANDTOTALtextbox = new System.Windows.Forms.TextBox();
            this.CASHtextBox = new System.Windows.Forms.TextBox();
            this.CHANGEtextBox = new System.Windows.Forms.TextBox();
            this.proc = new System.Windows.Forms.Button();
            this.srchText = new System.Windows.Forms.TextBox();
            this.pnlPOS1 = new System.Windows.Forms.Panel();
            this.pnlPOS2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pnlPOS1.SuspendLayout();
            this.pnlPOS2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProductname
            // 
            this.labelProductname.AutoSize = true;
            this.labelProductname.Location = new System.Drawing.Point(23, 77);
            this.labelProductname.Name = "labelProductname";
            this.labelProductname.Size = new System.Drawing.Size(87, 15);
            this.labelProductname.TabIndex = 0;
            this.labelProductname.Text = "Product Name:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(66, 133);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(33, 15);
            this.labelQuantity.TabIndex = 1;
            this.labelQuantity.Text = "Price";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(116, 130);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(259, 23);
            this.textBoxQuantity.TabIndex = 2;
            // 
            // textBoxProdName
            // 
            this.textBoxProdName.Location = new System.Drawing.Point(116, 72);
            this.textBoxProdName.Name = "textBoxProdName";
            this.textBoxProdName.Size = new System.Drawing.Size(259, 23);
            this.textBoxProdName.TabIndex = 3;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(116, 166);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 4;
            this.Addbutton.Text = "ADD";
            this.Addbutton.UseVisualStyleBackColor = true;
            // 
            // PAYbutton
            // 
            this.PAYbutton.Location = new System.Drawing.Point(116, 195);
            this.PAYbutton.Name = "PAYbutton";
            this.PAYbutton.Size = new System.Drawing.Size(75, 23);
            this.PAYbutton.TabIndex = 5;
            this.PAYbutton.Text = "PAY";
            this.PAYbutton.UseVisualStyleBackColor = true;
            // 
            // DELETEbutton
            // 
            this.DELETEbutton.Location = new System.Drawing.Point(197, 166);
            this.DELETEbutton.Name = "DELETEbutton";
            this.DELETEbutton.Size = new System.Drawing.Size(75, 23);
            this.DELETEbutton.TabIndex = 6;
            this.DELETEbutton.Text = "DELETE";
            this.DELETEbutton.UseVisualStyleBackColor = true;
            // 
            // CANCELbutton
            // 
            this.CANCELbutton.Location = new System.Drawing.Point(197, 195);
            this.CANCELbutton.Name = "CANCELbutton";
            this.CANCELbutton.Size = new System.Drawing.Size(75, 23);
            this.CANCELbutton.TabIndex = 7;
            this.CANCELbutton.Text = "button4";
            this.CANCELbutton.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProdCH,
            this.DescCH,
            this.PriceCH});
            this.listView1.Location = new System.Drawing.Point(402, 14);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(427, 189);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ProdCH
            // 
            this.ProdCH.Text = "Product Name";
            // 
            // DescCH
            // 
            this.DescCH.Text = "Description";
            // 
            // PriceCH
            // 
            this.PriceCH.Text = "Price";
            // 
            // RETURNbtn
            // 
            this.RETURNbtn.Location = new System.Drawing.Point(537, 718);
            this.RETURNbtn.Name = "RETURNbtn";
            this.RETURNbtn.Size = new System.Drawing.Size(75, 23);
            this.RETURNbtn.TabIndex = 9;
            this.RETURNbtn.Text = "RETURN";
            this.RETURNbtn.UseVisualStyleBackColor = true;
            // 
            // QUEUEbtn
            // 
            this.QUEUEbtn.Location = new System.Drawing.Point(537, 747);
            this.QUEUEbtn.Name = "QUEUEbtn";
            this.QUEUEbtn.Size = new System.Drawing.Size(75, 23);
            this.QUEUEbtn.TabIndex = 10;
            this.QUEUEbtn.Text = "QUEUE";
            this.QUEUEbtn.UseVisualStyleBackColor = true;
            // 
            // Totallbl
            // 
            this.Totallbl.AutoSize = true;
            this.Totallbl.Location = new System.Drawing.Point(554, 43);
            this.Totallbl.Name = "Totallbl";
            this.Totallbl.Size = new System.Drawing.Size(35, 15);
            this.Totallbl.TabIndex = 11;
            this.Totallbl.Text = "Total:";
            // 
            // Discountlbl
            // 
            this.Discountlbl.AutoSize = true;
            this.Discountlbl.Location = new System.Drawing.Point(545, 76);
            this.Discountlbl.Name = "Discountlbl";
            this.Discountlbl.Size = new System.Drawing.Size(57, 15);
            this.Discountlbl.TabIndex = 12;
            this.Discountlbl.Text = "Discount:";
            // 
            // VATlbl
            // 
            this.VATlbl.AutoSize = true;
            this.VATlbl.Location = new System.Drawing.Point(560, 107);
            this.VATlbl.Name = "VATlbl";
            this.VATlbl.Size = new System.Drawing.Size(29, 15);
            this.VATlbl.TabIndex = 13;
            this.VATlbl.Text = "VAT:";
            // 
            // GrandTotallbl
            // 
            this.GrandTotallbl.AutoSize = true;
            this.GrandTotallbl.Location = new System.Drawing.Point(532, 141);
            this.GrandTotallbl.Name = "GrandTotallbl";
            this.GrandTotallbl.Size = new System.Drawing.Size(70, 15);
            this.GrandTotallbl.TabIndex = 14;
            this.GrandTotallbl.Text = "Grand Total:";
            // 
            // cashlbl
            // 
            this.cashlbl.AutoSize = true;
            this.cashlbl.Location = new System.Drawing.Point(547, 174);
            this.cashlbl.Name = "cashlbl";
            this.cashlbl.Size = new System.Drawing.Size(36, 15);
            this.cashlbl.TabIndex = 15;
            this.cashlbl.Text = "Cash:";
            // 
            // changelbl
            // 
            this.changelbl.AutoSize = true;
            this.changelbl.Location = new System.Drawing.Point(538, 199);
            this.changelbl.Name = "changelbl";
            this.changelbl.Size = new System.Drawing.Size(51, 15);
            this.changelbl.TabIndex = 16;
            this.changelbl.Text = "Change:";
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.Location = new System.Drawing.Point(33, 43);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(400, 171);
            this.listView2.TabIndex = 17;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Price";
            // 
            // TOTALtextBox
            // 
            this.TOTALtextBox.Location = new System.Drawing.Point(626, 35);
            this.TOTALtextBox.Name = "TOTALtextBox";
            this.TOTALtextBox.Size = new System.Drawing.Size(168, 23);
            this.TOTALtextBox.TabIndex = 18;
            // 
            // DISCOUNTtextBox
            // 
            this.DISCOUNTtextBox.Location = new System.Drawing.Point(626, 76);
            this.DISCOUNTtextBox.Name = "DISCOUNTtextBox";
            this.DISCOUNTtextBox.Size = new System.Drawing.Size(168, 23);
            this.DISCOUNTtextBox.TabIndex = 19;
            // 
            // VATtextBox
            // 
            this.VATtextBox.Location = new System.Drawing.Point(626, 118);
            this.VATtextBox.Name = "VATtextBox";
            this.VATtextBox.Size = new System.Drawing.Size(168, 23);
            this.VATtextBox.TabIndex = 20;
            // 
            // GRANDTOTALtextbox
            // 
            this.GRANDTOTALtextbox.Location = new System.Drawing.Point(626, 157);
            this.GRANDTOTALtextbox.Name = "GRANDTOTALtextbox";
            this.GRANDTOTALtextbox.Size = new System.Drawing.Size(168, 23);
            this.GRANDTOTALtextbox.TabIndex = 21;
            // 
            // CASHtextBox
            // 
            this.CASHtextBox.Location = new System.Drawing.Point(626, 186);
            this.CASHtextBox.Name = "CASHtextBox";
            this.CASHtextBox.Size = new System.Drawing.Size(168, 23);
            this.CASHtextBox.TabIndex = 22;
            // 
            // CHANGEtextBox
            // 
            this.CHANGEtextBox.Location = new System.Drawing.Point(626, 215);
            this.CHANGEtextBox.Name = "CHANGEtextBox";
            this.CHANGEtextBox.Size = new System.Drawing.Size(168, 23);
            this.CHANGEtextBox.TabIndex = 23;
            // 
            // proc
            // 
            this.proc.Location = new System.Drawing.Point(633, 732);
            this.proc.Name = "proc";
            this.proc.Size = new System.Drawing.Size(97, 38);
            this.proc.TabIndex = 24;
            this.proc.Text = "PROCESS PAYMENT";
            this.proc.UseVisualStyleBackColor = true;
            this.proc.Click += new System.EventHandler(this.proc_Click);
            // 
            // srchText
            // 
            this.srchText.Location = new System.Drawing.Point(18, 14);
            this.srchText.Name = "srchText";
            this.srchText.PlaceholderText = "Search....";
            this.srchText.Size = new System.Drawing.Size(173, 23);
            this.srchText.TabIndex = 25;
            // 
            // pnlPOS1
            // 
            this.pnlPOS1.Controls.Add(this.textBox2);
            this.pnlPOS1.Controls.Add(this.label3);
            this.pnlPOS1.Controls.Add(this.textBox1);
            this.pnlPOS1.Controls.Add(this.label2);
            this.pnlPOS1.Controls.Add(this.srchText);
            this.pnlPOS1.Controls.Add(this.labelProductname);
            this.pnlPOS1.Controls.Add(this.textBoxProdName);
            this.pnlPOS1.Controls.Add(this.textBoxQuantity);
            this.pnlPOS1.Controls.Add(this.labelQuantity);
            this.pnlPOS1.Controls.Add(this.Addbutton);
            this.pnlPOS1.Controls.Add(this.DELETEbutton);
            this.pnlPOS1.Controls.Add(this.PAYbutton);
            this.pnlPOS1.Controls.Add(this.CANCELbutton);
            this.pnlPOS1.Controls.Add(this.listView1);
            this.pnlPOS1.Location = new System.Drawing.Point(12, 12);
            this.pnlPOS1.Name = "pnlPOS1";
            this.pnlPOS1.Size = new System.Drawing.Size(854, 236);
            this.pnlPOS1.TabIndex = 26;
            // 
            // pnlPOS2
            // 
            this.pnlPOS2.Controls.Add(this.label1);
            this.pnlPOS2.Controls.Add(this.TOTALtextBox);
            this.pnlPOS2.Controls.Add(this.DISCOUNTtextBox);
            this.pnlPOS2.Controls.Add(this.VATtextBox);
            this.pnlPOS2.Controls.Add(this.changelbl);
            this.pnlPOS2.Controls.Add(this.CHANGEtextBox);
            this.pnlPOS2.Controls.Add(this.cashlbl);
            this.pnlPOS2.Controls.Add(this.GRANDTOTALtextbox);
            this.pnlPOS2.Controls.Add(this.GrandTotallbl);
            this.pnlPOS2.Controls.Add(this.listView2);
            this.pnlPOS2.Controls.Add(this.CASHtextBox);
            this.pnlPOS2.Controls.Add(this.VATlbl);
            this.pnlPOS2.Controls.Add(this.Totallbl);
            this.pnlPOS2.Controls.Add(this.Discountlbl);
            this.pnlPOS2.Location = new System.Drawing.Point(13, 269);
            this.pnlPOS2.Name = "pnlPOS2";
            this.pnlPOS2.Size = new System.Drawing.Size(853, 262);
            this.pnlPOS2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 23);
            this.textBox1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Product number";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 23);
            this.textBox2.TabIndex = 29;
            // 
            // FPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 567);
            this.Controls.Add(this.pnlPOS2);
            this.Controls.Add(this.pnlPOS1);
            this.Controls.Add(this.proc);
            this.Controls.Add(this.QUEUEbtn);
            this.Controls.Add(this.RETURNbtn);
            this.Name = "FPOS";
            this.Text = "Point of Sale";
            this.pnlPOS1.ResumeLayout(false);
            this.pnlPOS1.PerformLayout();
            this.pnlPOS2.ResumeLayout(false);
            this.pnlPOS2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label labelProductname;
        private Label labelQuantity;
        private TextBox textBoxQuantity;
        private TextBox textBoxProdName;
        private Button Addbutton;
        private Button PAYbutton;
        private Button DELETEbutton;
        private Button CANCELbutton;
        private ListView listView1;
        private ColumnHeader ProdCH;
        private ColumnHeader DescCH;
        private ColumnHeader PriceCH;
        private Button RETURNbtn;
        private Button QUEUEbtn;
        private Label Totallbl;
        private Label Discountlbl;
        private Label VATlbl;
        private Label GrandTotallbl;
        private Label cashlbl;
        private Label changelbl;
        private ListView listView2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox TOTALtextBox;
        private TextBox DISCOUNTtextBox;
        private TextBox VATtextBox;
        private TextBox GRANDTOTALtextbox;
        private TextBox CASHtextBox;
        private TextBox CHANGEtextBox;
        private Button proc;
        private TextBox srchText;
        private Panel pnlPOS1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Panel pnlPOS2;
        private Label label1;
    }
}