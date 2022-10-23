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
            this.SuspendLayout();
            // 
            // labelProductname
            // 
            this.labelProductname.AutoSize = true;
            this.labelProductname.Location = new System.Drawing.Point(21, 27);
            this.labelProductname.Name = "labelProductname";
            this.labelProductname.Size = new System.Drawing.Size(87, 15);
            this.labelProductname.TabIndex = 0;
            this.labelProductname.Text = "Product Name:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(52, 62);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(56, 15);
            this.labelQuantity.TabIndex = 1;
            this.labelQuantity.Text = "Quantity:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(114, 59);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(259, 23);
            this.textBoxQuantity.TabIndex = 2;
            // 
            // textBoxProdName
            // 
            this.textBoxProdName.Location = new System.Drawing.Point(114, 24);
            this.textBoxProdName.Name = "textBoxProdName";
            this.textBoxProdName.Size = new System.Drawing.Size(259, 23);
            this.textBoxProdName.TabIndex = 3;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(146, 107);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 4;
            this.Addbutton.Text = "ADD";
            this.Addbutton.UseVisualStyleBackColor = true;
            // 
            // PAYbutton
            // 
            this.PAYbutton.Location = new System.Drawing.Point(146, 160);
            this.PAYbutton.Name = "PAYbutton";
            this.PAYbutton.Size = new System.Drawing.Size(75, 23);
            this.PAYbutton.TabIndex = 5;
            this.PAYbutton.Text = "PAY";
            this.PAYbutton.UseVisualStyleBackColor = true;
            // 
            // DELETEbutton
            // 
            this.DELETEbutton.Location = new System.Drawing.Point(253, 107);
            this.DELETEbutton.Name = "DELETEbutton";
            this.DELETEbutton.Size = new System.Drawing.Size(75, 23);
            this.DELETEbutton.TabIndex = 6;
            this.DELETEbutton.Text = "DELETE";
            this.DELETEbutton.UseVisualStyleBackColor = true;
            // 
            // CANCELbutton
            // 
            this.CANCELbutton.Location = new System.Drawing.Point(253, 160);
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
            this.listView1.Location = new System.Drawing.Point(21, 204);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(427, 225);
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
            this.RETURNbtn.Location = new System.Drawing.Point(537, 377);
            this.RETURNbtn.Name = "RETURNbtn";
            this.RETURNbtn.Size = new System.Drawing.Size(75, 23);
            this.RETURNbtn.TabIndex = 9;
            this.RETURNbtn.Text = "RETURN";
            this.RETURNbtn.UseVisualStyleBackColor = true;
            // 
            // QUEUEbtn
            // 
            this.QUEUEbtn.Location = new System.Drawing.Point(537, 406);
            this.QUEUEbtn.Name = "QUEUEbtn";
            this.QUEUEbtn.Size = new System.Drawing.Size(75, 23);
            this.QUEUEbtn.TabIndex = 10;
            this.QUEUEbtn.Text = "QUEUE";
            this.QUEUEbtn.UseVisualStyleBackColor = true;
            // 
            // Totallbl
            // 
            this.Totallbl.AutoSize = true;
            this.Totallbl.Location = new System.Drawing.Point(520, 204);
            this.Totallbl.Name = "Totallbl";
            this.Totallbl.Size = new System.Drawing.Size(35, 15);
            this.Totallbl.TabIndex = 11;
            this.Totallbl.Text = "Total:";
            // 
            // Discountlbl
            // 
            this.Discountlbl.AutoSize = true;
            this.Discountlbl.Location = new System.Drawing.Point(498, 231);
            this.Discountlbl.Name = "Discountlbl";
            this.Discountlbl.Size = new System.Drawing.Size(57, 15);
            this.Discountlbl.TabIndex = 12;
            this.Discountlbl.Text = "Discount:";
            // 
            // VATlbl
            // 
            this.VATlbl.AutoSize = true;
            this.VATlbl.Location = new System.Drawing.Point(526, 256);
            this.VATlbl.Name = "VATlbl";
            this.VATlbl.Size = new System.Drawing.Size(29, 15);
            this.VATlbl.TabIndex = 13;
            this.VATlbl.Text = "VAT:";
            // 
            // GrandTotallbl
            // 
            this.GrandTotallbl.AutoSize = true;
            this.GrandTotallbl.Location = new System.Drawing.Point(485, 285);
            this.GrandTotallbl.Name = "GrandTotallbl";
            this.GrandTotallbl.Size = new System.Drawing.Size(70, 15);
            this.GrandTotallbl.TabIndex = 14;
            this.GrandTotallbl.Text = "Grand Total:";
            // 
            // cashlbl
            // 
            this.cashlbl.AutoSize = true;
            this.cashlbl.Location = new System.Drawing.Point(520, 309);
            this.cashlbl.Name = "cashlbl";
            this.cashlbl.Size = new System.Drawing.Size(36, 15);
            this.cashlbl.TabIndex = 15;
            this.cashlbl.Text = "Cash:";
            // 
            // changelbl
            // 
            this.changelbl.AutoSize = true;
            this.changelbl.Location = new System.Drawing.Point(505, 335);
            this.changelbl.Name = "changelbl";
            this.changelbl.Size = new System.Drawing.Size(51, 15);
            this.changelbl.TabIndex = 16;
            this.changelbl.Text = "Change:";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.Location = new System.Drawing.Point(481, 12);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(288, 171);
            this.listView2.TabIndex = 17;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quantity";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            // 
            // TOTALtextBox
            // 
            this.TOTALtextBox.Location = new System.Drawing.Point(562, 196);
            this.TOTALtextBox.Name = "TOTALtextBox";
            this.TOTALtextBox.Size = new System.Drawing.Size(168, 23);
            this.TOTALtextBox.TabIndex = 18;
            // 
            // DISCOUNTtextBox
            // 
            this.DISCOUNTtextBox.Location = new System.Drawing.Point(562, 223);
            this.DISCOUNTtextBox.Name = "DISCOUNTtextBox";
            this.DISCOUNTtextBox.Size = new System.Drawing.Size(168, 23);
            this.DISCOUNTtextBox.TabIndex = 19;
            // 
            // VATtextBox
            // 
            this.VATtextBox.Location = new System.Drawing.Point(562, 248);
            this.VATtextBox.Name = "VATtextBox";
            this.VATtextBox.Size = new System.Drawing.Size(168, 23);
            this.VATtextBox.TabIndex = 20;
            // 
            // GRANDTOTALtextbox
            // 
            this.GRANDTOTALtextbox.Location = new System.Drawing.Point(562, 277);
            this.GRANDTOTALtextbox.Name = "GRANDTOTALtextbox";
            this.GRANDTOTALtextbox.Size = new System.Drawing.Size(168, 23);
            this.GRANDTOTALtextbox.TabIndex = 21;
            // 
            // CASHtextBox
            // 
            this.CASHtextBox.Location = new System.Drawing.Point(562, 306);
            this.CASHtextBox.Name = "CASHtextBox";
            this.CASHtextBox.Size = new System.Drawing.Size(168, 23);
            this.CASHtextBox.TabIndex = 22;
            // 
            // CHANGEtextBox
            // 
            this.CHANGEtextBox.Location = new System.Drawing.Point(562, 332);
            this.CHANGEtextBox.Name = "CHANGEtextBox";
            this.CHANGEtextBox.Size = new System.Drawing.Size(168, 23);
            this.CHANGEtextBox.TabIndex = 23;
            // 
            // proc
            // 
            this.proc.Location = new System.Drawing.Point(633, 391);
            this.proc.Name = "proc";
            this.proc.Size = new System.Drawing.Size(97, 38);
            this.proc.TabIndex = 24;
            this.proc.Text = "PROCESS PAYMENT";
            this.proc.UseVisualStyleBackColor = true;
            this.proc.Click += new System.EventHandler(this.proc_Click);
            // 
            // FPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.proc);
            this.Controls.Add(this.CHANGEtextBox);
            this.Controls.Add(this.CASHtextBox);
            this.Controls.Add(this.GRANDTOTALtextbox);
            this.Controls.Add(this.VATtextBox);
            this.Controls.Add(this.DISCOUNTtextBox);
            this.Controls.Add(this.TOTALtextBox);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.changelbl);
            this.Controls.Add(this.cashlbl);
            this.Controls.Add(this.GrandTotallbl);
            this.Controls.Add(this.VATlbl);
            this.Controls.Add(this.Discountlbl);
            this.Controls.Add(this.Totallbl);
            this.Controls.Add(this.QUEUEbtn);
            this.Controls.Add(this.RETURNbtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.CANCELbutton);
            this.Controls.Add(this.DELETEbutton);
            this.Controls.Add(this.PAYbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.textBoxProdName);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelProductname);
            this.Controls.Add(this.labelQuantity);
            this.Name = "FPOS";
            this.Text = "Point of Sale";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}