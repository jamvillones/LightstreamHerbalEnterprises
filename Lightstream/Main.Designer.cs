namespace Lightstream
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this._sideButtonPanel = new System.Windows.Forms.Panel();
            this._reportsPanel = new System.Windows.Forms.Panel();
            this._btnStock = new System.Windows.Forms.Button();
            this._btnExpiration = new System.Windows.Forms.Button();
            this._btnSaleSummary = new System.Windows.Forms.Button();
            this._mainBtn_Reports = new System.Windows.Forms.Button();
            this._inventoryPanel = new System.Windows.Forms.Panel();
            this._btnVat = new System.Windows.Forms.Button();
            this._btnRawMaterials = new System.Windows.Forms.Button();
            this._btnProductionInventory = new System.Windows.Forms.Button();
            this._mainBtn_Inventory = new System.Windows.Forms.Button();
            this._transacPanel = new System.Windows.Forms.Panel();
            this._btnPurchaseOrder = new System.Windows.Forms.Button();
            this._btnPos = new System.Windows.Forms.Button();
            this._mainBtn_Transaction = new System.Windows.Forms.Button();
            this._filesButtonPanel = new System.Windows.Forms.Panel();
            this._btnSupplierManagement = new System.Windows.Forms.Button();
            this._btnUnitManagement = new System.Windows.Forms.Button();
            this._btnPriceManagement = new System.Windows.Forms.Button();
            this._btnIngredients = new System.Windows.Forms.Button();
            this._btnProduction = new System.Windows.Forms.Button();
            this._mainBtn_Files = new System.Windows.Forms.Button();
            this._sidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this._utilities = new System.Windows.Forms.Button();
            this._logout = new System.Windows.Forms.Button();
            this._contentsPanel = new System.Windows.Forms.Panel();
            this._notifPanel = new System.Windows.Forms.Panel();
            this.divider = new System.Windows.Forms.SplitContainer();
            this._sideButtonPanel.SuspendLayout();
            this._reportsPanel.SuspendLayout();
            this._inventoryPanel.SuspendLayout();
            this._transacPanel.SuspendLayout();
            this._filesButtonPanel.SuspendLayout();
            this._sidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.divider)).BeginInit();
            this.divider.Panel1.SuspendLayout();
            this.divider.Panel2.SuspendLayout();
            this.divider.SuspendLayout();
            this.SuspendLayout();
            // 
            // _sideButtonPanel
            // 
            this._sideButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this._sideButtonPanel.Controls.Add(this._reportsPanel);
            this._sideButtonPanel.Controls.Add(this._mainBtn_Reports);
            this._sideButtonPanel.Controls.Add(this._inventoryPanel);
            this._sideButtonPanel.Controls.Add(this._mainBtn_Inventory);
            this._sideButtonPanel.Controls.Add(this._transacPanel);
            this._sideButtonPanel.Controls.Add(this._mainBtn_Transaction);
            this._sideButtonPanel.Controls.Add(this._filesButtonPanel);
            this._sideButtonPanel.Controls.Add(this._mainBtn_Files);
            this._sideButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sideButtonPanel.Location = new System.Drawing.Point(0, 0);
            this._sideButtonPanel.Name = "_sideButtonPanel";
            this._sideButtonPanel.Size = new System.Drawing.Size(170, 471);
            this._sideButtonPanel.TabIndex = 1;
            // 
            // _reportsPanel
            // 
            this._reportsPanel.AutoSize = true;
            this._reportsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._reportsPanel.Controls.Add(this._btnStock);
            this._reportsPanel.Controls.Add(this._btnExpiration);
            this._reportsPanel.Controls.Add(this._btnSaleSummary);
            this._reportsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._reportsPanel.Location = new System.Drawing.Point(0, 635);
            this._reportsPanel.Name = "_reportsPanel";
            this._reportsPanel.Size = new System.Drawing.Size(170, 128);
            this._reportsPanel.TabIndex = 12;
            this._reportsPanel.Visible = false;
            // 
            // _btnStock
            // 
            this._btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnStock.FlatAppearance.BorderSize = 0;
            this._btnStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this._btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnStock.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._btnStock.Image = ((System.Drawing.Image)(resources.GetObject("_btnStock.Image")));
            this._btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnStock.Location = new System.Drawing.Point(0, 83);
            this._btnStock.Margin = new System.Windows.Forms.Padding(5);
            this._btnStock.Name = "_btnStock";
            this._btnStock.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this._btnStock.Size = new System.Drawing.Size(170, 45);
            this._btnStock.TabIndex = 6;
            this._btnStock.TabStop = false;
            this._btnStock.Text = "  STOCK";
            this._btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnStock.UseVisualStyleBackColor = false;
            this._btnStock.Click += new System.EventHandler(this._btnStock_Click);
            // 
            // _btnExpiration
            // 
            this._btnExpiration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._btnExpiration.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnExpiration.FlatAppearance.BorderSize = 0;
            this._btnExpiration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this._btnExpiration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnExpiration.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnExpiration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._btnExpiration.Image = ((System.Drawing.Image)(resources.GetObject("_btnExpiration.Image")));
            this._btnExpiration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnExpiration.Location = new System.Drawing.Point(0, 38);
            this._btnExpiration.Margin = new System.Windows.Forms.Padding(5);
            this._btnExpiration.Name = "_btnExpiration";
            this._btnExpiration.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this._btnExpiration.Size = new System.Drawing.Size(170, 45);
            this._btnExpiration.TabIndex = 5;
            this._btnExpiration.TabStop = false;
            this._btnExpiration.Text = "  EXPIRATION";
            this._btnExpiration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnExpiration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnExpiration.UseVisualStyleBackColor = false;
            this._btnExpiration.Click += new System.EventHandler(this._btnExpiration_Click);
            // 
            // _btnSaleSummary
            // 
            this._btnSaleSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._btnSaleSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnSaleSummary.FlatAppearance.BorderSize = 0;
            this._btnSaleSummary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this._btnSaleSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSaleSummary.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnSaleSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._btnSaleSummary.Image = ((System.Drawing.Image)(resources.GetObject("_btnSaleSummary.Image")));
            this._btnSaleSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSaleSummary.Location = new System.Drawing.Point(0, 0);
            this._btnSaleSummary.Margin = new System.Windows.Forms.Padding(5);
            this._btnSaleSummary.Name = "_btnSaleSummary";
            this._btnSaleSummary.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this._btnSaleSummary.Size = new System.Drawing.Size(170, 38);
            this._btnSaleSummary.TabIndex = 4;
            this._btnSaleSummary.TabStop = false;
            this._btnSaleSummary.Text = "  SALES SUMMARY";
            this._btnSaleSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSaleSummary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnSaleSummary.UseVisualStyleBackColor = false;
            this._btnSaleSummary.Click += new System.EventHandler(this._btnSaleSummary_Click);
            // 
            // _mainBtn_Reports
            // 
            this._mainBtn_Reports.Dock = System.Windows.Forms.DockStyle.Top;
            this._mainBtn_Reports.FlatAppearance.BorderSize = 0;
            this._mainBtn_Reports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this._mainBtn_Reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._mainBtn_Reports.Font = new System.Drawing.Font("The Bold Font", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._mainBtn_Reports.ForeColor = System.Drawing.Color.White;
            this._mainBtn_Reports.Image = ((System.Drawing.Image)(resources.GetObject("_mainBtn_Reports.Image")));
            this._mainBtn_Reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._mainBtn_Reports.Location = new System.Drawing.Point(0, 585);
            this._mainBtn_Reports.Margin = new System.Windows.Forms.Padding(5);
            this._mainBtn_Reports.Name = "_mainBtn_Reports";
            this._mainBtn_Reports.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._mainBtn_Reports.Size = new System.Drawing.Size(170, 50);
            this._mainBtn_Reports.TabIndex = 7;
            this._mainBtn_Reports.TabStop = false;
            this._mainBtn_Reports.Text = "  Reports";
            this._mainBtn_Reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._mainBtn_Reports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._mainBtn_Reports.UseVisualStyleBackColor = true;
            this._mainBtn_Reports.Click += new System.EventHandler(this.button7_Click);
            // 
            // _inventoryPanel
            // 
            this._inventoryPanel.AutoSize = true;
            this._inventoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._inventoryPanel.Controls.Add(this._btnVat);
            this._inventoryPanel.Controls.Add(this._btnRawMaterials);
            this._inventoryPanel.Controls.Add(this._btnProductionInventory);
            this._inventoryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._inventoryPanel.Location = new System.Drawing.Point(0, 465);
            this._inventoryPanel.Name = "_inventoryPanel";
            this._inventoryPanel.Size = new System.Drawing.Size(170, 120);
            this._inventoryPanel.TabIndex = 11;
            this._inventoryPanel.Visible = false;
            // 
            // _btnVat
            // 
            this._btnVat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._btnVat.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnVat.FlatAppearance.BorderSize = 0;
            this._btnVat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this._btnVat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnVat.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnVat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._btnVat.Image = ((System.Drawing.Image)(resources.GetObject("_btnVat.Image")));
            this._btnVat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnVat.Location = new System.Drawing.Point(0, 90);
            this._btnVat.Margin = new System.Windows.Forms.Padding(5);
            this._btnVat.Name = "_btnVat";
            this._btnVat.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this._btnVat.Size = new System.Drawing.Size(170, 30);
            this._btnVat.TabIndex = 6;
            this._btnVat.TabStop = false;
            this._btnVat.Text = "  VAT";
            this._btnVat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnVat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnVat.UseVisualStyleBackColor = false;
            this._btnVat.Click += new System.EventHandler(this._btnVat_Click);
            // 
            // _btnRawMaterials
            // 
            this._btnRawMaterials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._btnRawMaterials.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnRawMaterials.FlatAppearance.BorderSize = 0;
            this._btnRawMaterials.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this._btnRawMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnRawMaterials.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnRawMaterials.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._btnRawMaterials.Image = ((System.Drawing.Image)(resources.GetObject("_btnRawMaterials.Image")));
            this._btnRawMaterials.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnRawMaterials.Location = new System.Drawing.Point(0, 45);
            this._btnRawMaterials.Margin = new System.Windows.Forms.Padding(5);
            this._btnRawMaterials.Name = "_btnRawMaterials";
            this._btnRawMaterials.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this._btnRawMaterials.Size = new System.Drawing.Size(170, 45);
            this._btnRawMaterials.TabIndex = 5;
            this._btnRawMaterials.TabStop = false;
            this._btnRawMaterials.Text = "  RAW MATERIALS";
            this._btnRawMaterials.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnRawMaterials.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnRawMaterials.UseVisualStyleBackColor = false;
            // 
            // _btnProductionInventory
            // 
            this._btnProductionInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._btnProductionInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnProductionInventory.FlatAppearance.BorderSize = 0;
            this._btnProductionInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this._btnProductionInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnProductionInventory.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnProductionInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._btnProductionInventory.Image = ((System.Drawing.Image)(resources.GetObject("_btnProductionInventory.Image")));
            this._btnProductionInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnProductionInventory.Location = new System.Drawing.Point(0, 0);
            this._btnProductionInventory.Margin = new System.Windows.Forms.Padding(5);
            this._btnProductionInventory.Name = "_btnProductionInventory";
            this._btnProductionInventory.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this._btnProductionInventory.Size = new System.Drawing.Size(170, 45);
            this._btnProductionInventory.TabIndex = 4;
            this._btnProductionInventory.TabStop = false;
            this._btnProductionInventory.Text = "  INVENTORY";
            this._btnProductionInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnProductionInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnProductionInventory.UseVisualStyleBackColor = false;
            // 
            // _mainBtn_Inventory
            // 
            this._mainBtn_Inventory.Dock = System.Windows.Forms.DockStyle.Top;
            this._mainBtn_Inventory.FlatAppearance.BorderSize = 0;
            this._mainBtn_Inventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this._mainBtn_Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._mainBtn_Inventory.Font = new System.Drawing.Font("The Bold Font", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._mainBtn_Inventory.ForeColor = System.Drawing.Color.White;
            this._mainBtn_Inventory.Image = ((System.Drawing.Image)(resources.GetObject("_mainBtn_Inventory.Image")));
            this._mainBtn_Inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._mainBtn_Inventory.Location = new System.Drawing.Point(0, 415);
            this._mainBtn_Inventory.Margin = new System.Windows.Forms.Padding(5);
            this._mainBtn_Inventory.Name = "_mainBtn_Inventory";
            this._mainBtn_Inventory.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._mainBtn_Inventory.Size = new System.Drawing.Size(170, 50);
            this._mainBtn_Inventory.TabIndex = 4;
            this._mainBtn_Inventory.TabStop = false;
            this._mainBtn_Inventory.Text = "  Inventory";
            this._mainBtn_Inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._mainBtn_Inventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._mainBtn_Inventory.UseVisualStyleBackColor = true;
            this._mainBtn_Inventory.Click += new System.EventHandler(this.button4_Click);
            // 
            // _transacPanel
            // 
            this._transacPanel.AutoSize = true;
            this._transacPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._transacPanel.Controls.Add(this._btnPurchaseOrder);
            this._transacPanel.Controls.Add(this._btnPos);
            this._transacPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._transacPanel.Location = new System.Drawing.Point(0, 325);
            this._transacPanel.Name = "_transacPanel";
            this._transacPanel.Size = new System.Drawing.Size(170, 90);
            this._transacPanel.TabIndex = 10;
            this._transacPanel.Visible = false;
            // 
            // _btnPurchaseOrder
            // 
            this._btnPurchaseOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._btnPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnPurchaseOrder.FlatAppearance.BorderSize = 0;
            this._btnPurchaseOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this._btnPurchaseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnPurchaseOrder.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnPurchaseOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._btnPurchaseOrder.Image = ((System.Drawing.Image)(resources.GetObject("_btnPurchaseOrder.Image")));
            this._btnPurchaseOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnPurchaseOrder.Location = new System.Drawing.Point(0, 45);
            this._btnPurchaseOrder.Margin = new System.Windows.Forms.Padding(5);
            this._btnPurchaseOrder.Name = "_btnPurchaseOrder";
            this._btnPurchaseOrder.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this._btnPurchaseOrder.Size = new System.Drawing.Size(170, 45);
            this._btnPurchaseOrder.TabIndex = 5;
            this._btnPurchaseOrder.TabStop = false;
            this._btnPurchaseOrder.Text = "  PURCHASE ORDER";
            this._btnPurchaseOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnPurchaseOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnPurchaseOrder.UseVisualStyleBackColor = false;
            this._btnPurchaseOrder.Click += new System.EventHandler(this._btnPurchaseOrder_Click);
            // 
            // _btnPos
            // 
            this._btnPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._btnPos.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnPos.FlatAppearance.BorderSize = 0;
            this._btnPos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this._btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnPos.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._btnPos.Image = ((System.Drawing.Image)(resources.GetObject("_btnPos.Image")));
            this._btnPos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnPos.Location = new System.Drawing.Point(0, 0);
            this._btnPos.Margin = new System.Windows.Forms.Padding(5);
            this._btnPos.Name = "_btnPos";
            this._btnPos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this._btnPos.Size = new System.Drawing.Size(170, 45);
            this._btnPos.TabIndex = 4;
            this._btnPos.TabStop = false;
            this._btnPos.Text = "  POS";
            this._btnPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnPos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnPos.UseVisualStyleBackColor = false;
            this._btnPos.Click += new System.EventHandler(this.button14_Click);
            // 
            // _mainBtn_Transaction
            // 
            this._mainBtn_Transaction.Dock = System.Windows.Forms.DockStyle.Top;
            this._mainBtn_Transaction.FlatAppearance.BorderSize = 0;
            this._mainBtn_Transaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this._mainBtn_Transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._mainBtn_Transaction.Font = new System.Drawing.Font("The Bold Font", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._mainBtn_Transaction.ForeColor = System.Drawing.Color.White;
            this._mainBtn_Transaction.Image = ((System.Drawing.Image)(resources.GetObject("_mainBtn_Transaction.Image")));
            this._mainBtn_Transaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._mainBtn_Transaction.Location = new System.Drawing.Point(0, 275);
            this._mainBtn_Transaction.Margin = new System.Windows.Forms.Padding(5);
            this._mainBtn_Transaction.Name = "_mainBtn_Transaction";
            this._mainBtn_Transaction.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._mainBtn_Transaction.Size = new System.Drawing.Size(170, 50);
            this._mainBtn_Transaction.TabIndex = 8;
            this._mainBtn_Transaction.TabStop = false;
            this._mainBtn_Transaction.Text = "  Transaction";
            this._mainBtn_Transaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._mainBtn_Transaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._mainBtn_Transaction.UseVisualStyleBackColor = true;
            this._mainBtn_Transaction.Click += new System.EventHandler(this.button8_Click);
            // 
            // _filesButtonPanel
            // 
            this._filesButtonPanel.AutoSize = true;
            this._filesButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._filesButtonPanel.Controls.Add(this._btnSupplierManagement);
            this._filesButtonPanel.Controls.Add(this._btnUnitManagement);
            this._filesButtonPanel.Controls.Add(this._btnPriceManagement);
            this._filesButtonPanel.Controls.Add(this._btnIngredients);
            this._filesButtonPanel.Controls.Add(this._btnProduction);
            this._filesButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._filesButtonPanel.Location = new System.Drawing.Point(0, 50);
            this._filesButtonPanel.Name = "_filesButtonPanel";
            this._filesButtonPanel.Size = new System.Drawing.Size(170, 225);
            this._filesButtonPanel.TabIndex = 9;
            this._filesButtonPanel.Visible = false;
            // 
            // _btnSupplierManagement
            // 
            this._btnSupplierManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._btnSupplierManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnSupplierManagement.FlatAppearance.BorderSize = 0;
            this._btnSupplierManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this._btnSupplierManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSupplierManagement.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnSupplierManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._btnSupplierManagement.Image = ((System.Drawing.Image)(resources.GetObject("_btnSupplierManagement.Image")));
            this._btnSupplierManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSupplierManagement.Location = new System.Drawing.Point(0, 180);
            this._btnSupplierManagement.Margin = new System.Windows.Forms.Padding(5);
            this._btnSupplierManagement.Name = "_btnSupplierManagement";
            this._btnSupplierManagement.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this._btnSupplierManagement.Size = new System.Drawing.Size(170, 45);
            this._btnSupplierManagement.TabIndex = 8;
            this._btnSupplierManagement.TabStop = false;
            this._btnSupplierManagement.Text = "  SUPPLIERS";
            this._btnSupplierManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSupplierManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnSupplierManagement.UseVisualStyleBackColor = false;
            this._btnSupplierManagement.Click += new System.EventHandler(this._btnSupplierManagement_Click);
            // 
            // _btnUnitManagement
            // 
            this._btnUnitManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._btnUnitManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnUnitManagement.FlatAppearance.BorderSize = 0;
            this._btnUnitManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this._btnUnitManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnUnitManagement.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnUnitManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._btnUnitManagement.Image = ((System.Drawing.Image)(resources.GetObject("_btnUnitManagement.Image")));
            this._btnUnitManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnUnitManagement.Location = new System.Drawing.Point(0, 135);
            this._btnUnitManagement.Margin = new System.Windows.Forms.Padding(5);
            this._btnUnitManagement.Name = "_btnUnitManagement";
            this._btnUnitManagement.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this._btnUnitManagement.Size = new System.Drawing.Size(170, 45);
            this._btnUnitManagement.TabIndex = 7;
            this._btnUnitManagement.TabStop = false;
            this._btnUnitManagement.Text = "  UNITS";
            this._btnUnitManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnUnitManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnUnitManagement.UseVisualStyleBackColor = false;
            this._btnUnitManagement.Click += new System.EventHandler(this.button12_Click);
            // 
            // _btnPriceManagement
            // 
            this._btnPriceManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._btnPriceManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnPriceManagement.FlatAppearance.BorderSize = 0;
            this._btnPriceManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this._btnPriceManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnPriceManagement.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnPriceManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._btnPriceManagement.Image = ((System.Drawing.Image)(resources.GetObject("_btnPriceManagement.Image")));
            this._btnPriceManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnPriceManagement.Location = new System.Drawing.Point(0, 90);
            this._btnPriceManagement.Margin = new System.Windows.Forms.Padding(5);
            this._btnPriceManagement.Name = "_btnPriceManagement";
            this._btnPriceManagement.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this._btnPriceManagement.Size = new System.Drawing.Size(170, 45);
            this._btnPriceManagement.TabIndex = 6;
            this._btnPriceManagement.TabStop = false;
            this._btnPriceManagement.Text = "  PRICE MANAGEMENT";
            this._btnPriceManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnPriceManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnPriceManagement.UseVisualStyleBackColor = false;
            this._btnPriceManagement.Click += new System.EventHandler(this.button11_Click_1);
            // 
            // _btnIngredients
            // 
            this._btnIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._btnIngredients.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnIngredients.FlatAppearance.BorderSize = 0;
            this._btnIngredients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this._btnIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnIngredients.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnIngredients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._btnIngredients.Image = ((System.Drawing.Image)(resources.GetObject("_btnIngredients.Image")));
            this._btnIngredients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnIngredients.Location = new System.Drawing.Point(0, 45);
            this._btnIngredients.Margin = new System.Windows.Forms.Padding(5);
            this._btnIngredients.Name = "_btnIngredients";
            this._btnIngredients.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this._btnIngredients.Size = new System.Drawing.Size(170, 45);
            this._btnIngredients.TabIndex = 5;
            this._btnIngredients.TabStop = false;
            this._btnIngredients.Text = "  INGREDIENTS";
            this._btnIngredients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnIngredients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnIngredients.UseVisualStyleBackColor = false;
            this._btnIngredients.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // _btnProduction
            // 
            this._btnProduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this._btnProduction.Dock = System.Windows.Forms.DockStyle.Top;
            this._btnProduction.FlatAppearance.BorderSize = 0;
            this._btnProduction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this._btnProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnProduction.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btnProduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this._btnProduction.Image = ((System.Drawing.Image)(resources.GetObject("_btnProduction.Image")));
            this._btnProduction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnProduction.Location = new System.Drawing.Point(0, 0);
            this._btnProduction.Margin = new System.Windows.Forms.Padding(5);
            this._btnProduction.Name = "_btnProduction";
            this._btnProduction.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this._btnProduction.Size = new System.Drawing.Size(170, 45);
            this._btnProduction.TabIndex = 4;
            this._btnProduction.TabStop = false;
            this._btnProduction.Text = "  PRODUCTS";
            this._btnProduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnProduction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._btnProduction.UseVisualStyleBackColor = false;
            this._btnProduction.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // _mainBtn_Files
            // 
            this._mainBtn_Files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this._mainBtn_Files.Dock = System.Windows.Forms.DockStyle.Top;
            this._mainBtn_Files.FlatAppearance.BorderSize = 0;
            this._mainBtn_Files.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this._mainBtn_Files.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._mainBtn_Files.Font = new System.Drawing.Font("The Bold Font", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._mainBtn_Files.ForeColor = System.Drawing.Color.White;
            this._mainBtn_Files.Image = ((System.Drawing.Image)(resources.GetObject("_mainBtn_Files.Image")));
            this._mainBtn_Files.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._mainBtn_Files.Location = new System.Drawing.Point(0, 0);
            this._mainBtn_Files.Margin = new System.Windows.Forms.Padding(5);
            this._mainBtn_Files.Name = "_mainBtn_Files";
            this._mainBtn_Files.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this._mainBtn_Files.Size = new System.Drawing.Size(170, 50);
            this._mainBtn_Files.TabIndex = 3;
            this._mainBtn_Files.TabStop = false;
            this._mainBtn_Files.Text = "  Files";
            this._mainBtn_Files.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._mainBtn_Files.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._mainBtn_Files.UseVisualStyleBackColor = false;
            this._mainBtn_Files.Click += new System.EventHandler(this._filesBtn_Click);
            // 
            // _sidePanel
            // 
            this._sidePanel.Controls.Add(this._sideButtonPanel);
            this._sidePanel.Controls.Add(this.panel1);
            this._sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this._sidePanel.Location = new System.Drawing.Point(0, 0);
            this._sidePanel.Name = "_sidePanel";
            this._sidePanel.Size = new System.Drawing.Size(170, 531);
            this._sidePanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this._utilities);
            this.panel1.Controls.Add(this._logout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 60);
            this.panel1.TabIndex = 2;
            // 
            // _utilities
            // 
            this._utilities.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._utilities.FlatAppearance.BorderSize = 0;
            this._utilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._utilities.Font = new System.Drawing.Font("The Bold Font", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._utilities.ForeColor = System.Drawing.Color.White;
            this._utilities.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._utilities.Location = new System.Drawing.Point(0, 0);
            this._utilities.Margin = new System.Windows.Forms.Padding(5);
            this._utilities.Name = "_utilities";
            this._utilities.Size = new System.Drawing.Size(170, 30);
            this._utilities.TabIndex = 3;
            this._utilities.TabStop = false;
            this._utilities.Text = "Utilities";
            this._utilities.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._utilities.UseVisualStyleBackColor = true;
            this._utilities.Click += new System.EventHandler(this.button2_Click);
            // 
            // _logout
            // 
            this._logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._logout.FlatAppearance.BorderSize = 0;
            this._logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._logout.Font = new System.Drawing.Font("The Bold Font", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._logout.ForeColor = System.Drawing.Color.White;
            this._logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._logout.Location = new System.Drawing.Point(0, 30);
            this._logout.Margin = new System.Windows.Forms.Padding(5);
            this._logout.Name = "_logout";
            this._logout.Size = new System.Drawing.Size(170, 30);
            this._logout.TabIndex = 2;
            this._logout.TabStop = false;
            this._logout.Text = "Log out";
            this._logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._logout.UseVisualStyleBackColor = true;
            this._logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // _contentsPanel
            // 
            this._contentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._contentsPanel.Location = new System.Drawing.Point(0, 0);
            this._contentsPanel.Name = "_contentsPanel";
            this._contentsPanel.Size = new System.Drawing.Size(602, 531);
            this._contentsPanel.TabIndex = 4;
            this._contentsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this._contentsPanel_Paint);
            // 
            // _notifPanel
            // 
            this._notifPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this._notifPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._notifPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._notifPanel.Location = new System.Drawing.Point(0, 0);
            this._notifPanel.Name = "_notifPanel";
            this._notifPanel.Size = new System.Drawing.Size(96, 100);
            this._notifPanel.TabIndex = 5;
            // 
            // divider
            // 
            this.divider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divider.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.divider.Location = new System.Drawing.Point(170, 0);
            this.divider.Name = "divider";
            // 
            // divider.Panel1
            // 
            this.divider.Panel1.Controls.Add(this._contentsPanel);
            this.divider.Panel1MinSize = 300;
            // 
            // divider.Panel2
            // 
            this.divider.Panel2.Controls.Add(this._notifPanel);
            this.divider.Panel2Collapsed = true;
            this.divider.Panel2MinSize = 110;
            this.divider.Size = new System.Drawing.Size(602, 531);
            this.divider.SplitterDistance = 300;
            this.divider.SplitterWidth = 2;
            this.divider.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 531);
            this.ControlBox = false;
            this.Controls.Add(this.divider);
            this.Controls.Add(this._sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this._sideButtonPanel.ResumeLayout(false);
            this._sideButtonPanel.PerformLayout();
            this._reportsPanel.ResumeLayout(false);
            this._inventoryPanel.ResumeLayout(false);
            this._transacPanel.ResumeLayout(false);
            this._filesButtonPanel.ResumeLayout(false);
            this._sidePanel.ResumeLayout(false);
            this._sidePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.divider.Panel1.ResumeLayout(false);
            this.divider.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.divider)).EndInit();
            this.divider.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel _sideButtonPanel;
        private Button _mainBtn_Files;
        private Button _mainBtn_Transaction;
        private Button _mainBtn_Reports;
        private Button _mainBtn_Inventory;
        private Panel _sidePanel;
        private Panel _contentsPanel;
        private Panel _filesButtonPanel;
        private Button _btnProduction;
        private Button _btnUnitManagement;
        private Button _btnPriceManagement;
        private Button _btnIngredients;
        private Panel _transacPanel;
        private Button _btnPurchaseOrder;
        private Button _btnPos;
        private Panel _inventoryPanel;
        private Button _btnVat;
        private Button _btnRawMaterials;
        private Button _btnProductionInventory;
        private Panel _reportsPanel;
        private Button _btnStock;
        private Button _btnExpiration;
        private Button _btnSaleSummary;
        private Panel panel1;
        private Button _utilities;
        private Button _logout;
        private Panel _notifPanel;
        private SplitContainer divider;
        private Button _btnSupplierManagement;
    }
}