﻿using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.Forms;
using Lightstream.Pages;
using Lightstream.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Lightstream
{
    public partial class Main : Form, ILogoutForm
    {
        Panel[] collapsiblePanels;
        Button? currentButton = null;
        Form? currentForm = null;
        Color selectedButtonColor = Color.FromArgb(66, 120, 37);
        Color normalButtonColor = Color.FromArgb(45, 45, 45);
        public bool IsLoggedout { get; private set; } = false;
        public Main()
        {
            InitializeComponent();

            collapsiblePanels = new Panel[] {
                _filesButtonPanel,
                _transacPanel,
                _inventoryPanel,
                _reportsPanel,
            };
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void logout_Click(object sender, EventArgs e)
        {

        }

        void ChangeButtonStateUponClick(Button nextButton)
        {
            if (currentButton is not null)
                currentButton.BackColor = normalButtonColor;

            currentButton = nextButton;

            currentButton.BackColor = selectedButtonColor;
        }
        void TogglePanel(Panel p)
        {
            p.Visible = !p.Visible;

            //if (p.Visible)
            //{
            //    foreach (var i in collapsiblePanels.Where(x => x != p))
            //        if (i.Visible) i.Visible = false;
            //}
        }
        void OpenForm<TForm>() where TForm : Form, new()
        {
            //if there is an open form
            if (currentForm is not null)
            {
                //abort if the incoming form type is the same as of the old one
                if (typeof(TForm) == currentForm.GetType())
                    return;

                currentForm.Close();
            }

            currentForm = new TForm();

            currentForm.FormClosed += (a, b) =>
                currentForm = null;

            currentForm.TopLevel = false;
            currentForm.Size = _contentsPanel.Size;
            currentForm.Dock = DockStyle.Fill;

            _contentsPanel.Controls.Add(currentForm);

            currentForm.BringToFront();
            currentForm.Show();
        }

        //Dictionary<Button, Form> Tabs = new();
        Button currentTabButton;
        void OpenForm(Form next, Button b)
        {
            var buttFound = _tabsButtonsFlowLayoutPanel.Controls.Cast<Button>().FirstOrDefault(x => string.Equals(x.Text.Trim(), b.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if(buttFound is not null)
            {
                buttFound.PerformClick();
                return;
            }

            currentForm = next;

            currentForm.FormClosed += (a, b) =>
                currentForm = null;

            currentForm.TopLevel = false;
            currentForm.Size = _contentsPanel.Size;
            currentForm.Dock = DockStyle.Fill;

            _contentsPanel.Controls.Add(currentForm);

            if (currentTabButton is not null)
                currentTabButton.BackColor = SystemColors.Control;

            var btn = CreateTabButton(b.Text);
            //btn.ForeColor = Color.DarkGreen;

            btn.Click += (sender, e) =>
            {
                currentTabButton.BackColor = SystemColors.Control;
                currentTabButton = sender as Button;
                currentTabButton.BackColor = Color_SelectedTabButton;

                next.BringToFront();
            };

            currentTabButton = btn;
            _tabsButtonsFlowLayoutPanel.Controls.Add(btn);

            currentForm.BringToFront();
            currentForm.Show();

            //Tabs.Add(btn, currentForm);
        }
        Color Color_SelectedTabButton = Color.FromArgb(143, 188, 143);
        //Color Color_SelectedTabButton = Color.White;
        Font Font_SelectedTabButton = new Font("The Bold Font", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

        Button CreateTabButton(string title)
        {
            var btn = new Button();
            btn.Font = Font_SelectedTabButton;
            btn.BackColor = Color_SelectedTabButton;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Padding = new Padding(15,5,15,5);
            btn.Margin = new Padding(0);
            btn.AutoSize = true;
            btn.Text = title.Trim();
            return btn;
        }
        void OpenForm(Form next)
        {
            //if there is an open form
            if (currentForm is not null)
            {
                //abort if the incoming form type is the same as of the old one
                if (next.GetType() == currentForm.GetType())
                    return;

                currentForm.Close();
            }

            currentForm = next;

            currentForm.FormClosed += (a, b) =>
                currentForm = null;

            currentForm.TopLevel = false;
            currentForm.Size = _contentsPanel.Size;
            currentForm.Dock = DockStyle.Fill;

            _contentsPanel.Controls.Add(currentForm);

            currentForm.BringToFront();
            currentForm.Show();
        }

        #region opening form
        private void button9_Click_1(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                ChangeButtonStateUponClick(btn);

                var prodPage = new ProductsPage(
                    new ProductService(),
                    new GenericRepository<Unit>()
                    );

                OpenForm(prodPage, btn);
            }
            //OpenForm<ProductsPage>();
        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                ChangeButtonStateUponClick(btn);

                var ingForm = new IngredientsPage(new IngredientService());
                OpenForm(ingForm, btn);
            }
        }
        #endregion

        #region toggling panels
        private void _filesBtn_Click(object sender, EventArgs e)
        {
            TogglePanel(_filesButtonPanel);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TogglePanel(_transacPanel);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TogglePanel(_inventoryPanel);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TogglePanel(_reportsPanel);
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            using (CreateNewUserForm cc = new CreateNewUserForm())
            {
                if (cc.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                ChangeButtonStateUponClick(b);
                var posService = new CartService();
                var saleService = new SaleService();
                var posForm = new FPOS(posService, saleService);
                OpenForm(posForm, b);
            }
        }

        private void _contentsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                ChangeButtonStateUponClick(b);

                var sm = new PriceManagementPage(new ProductVariantService());

                OpenForm(sm, b);
            }
            //ChangeButtonStateUponClick(sender as Button);
            //PriceManagementPage priceManagement = new(new ProductVariantService());
            //OpenForm(priceManagement);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                ChangeButtonStateUponClick(b);
                UnitManagementPage unitmagmnt = new(new GenericRepository<Unit>());
                OpenForm(unitmagmnt, b);
            }
        }

        private void _btnSupplierManagement_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                ChangeButtonStateUponClick(b);

                var sm = new SupplierManagementPage(new SupplierService());

                OpenForm(sm, b);
            }
        }

        private void _btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                ChangeButtonStateUponClick(b);
                var po = new PurchaseOrderPage(new PurchaseOrderService());
                OpenForm(po, b);
            }
        }

        private void _btnVat_Click(object sender, EventArgs e)
        {
            _Vat vat = new _Vat();
            vat.ShowDialog();
        }

        private void _btnSaleSummary_Click(object sender, EventArgs e)
        {
            ChangeButtonStateUponClick(sender as Button);
            OpenForm<_salesReport>();
        }

        private void _btnExpiration_Click(object sender, EventArgs e)
        {
            ChangeButtonStateUponClick(sender as Button);
            OpenForm<_expiry>();
        }

        private void _btnStock_Click(object sender, EventArgs e)
        {
            ChangeButtonStateUponClick(sender as Button);
            OpenForm<_stockReport>();
        }

        public void Logout()
        {
            IsLoggedout = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button b)
            {
                ChangeButtonStateUponClick(b);

                var saleService = new SaleService();
                var saleForm = new SalePage(saleService);

                OpenForm(saleForm, b);
            }
        }
    }
}
