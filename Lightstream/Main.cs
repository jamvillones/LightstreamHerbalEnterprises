using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.Forms;
using Lightstream.Pages;
using Lightstream.Services;
using Lightstream.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private INotifier notificationHandler;
        public Main(INotifier source = null)
        {
            InitializeComponent();

            notificationHandler = source;
            collapsiblePanels = new Panel[] {
                _filesButtonPanel,
                _transacPanel,
                _inventoryPanel,
                _reportsPanel,
            };
        }
        private void Main_Load(object sender, EventArgs e)
        {
            notificationHandler.ShowNotification("Welcome!", $"Please make sure that the time and date is correct.\nCurrent Date and Time: {DateTime.Now.ToString("MMM d, yyyy h:mm tt")}", ToolTipIcon.Info);
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
                ChangeButtonStateUponClick(btn);

            var prodPage = new ProductsPage(
                new ProductService(),
                new GenericRepository<Unit>()
                );

            OpenForm(prodPage);
            //OpenForm<ProductsPage>();
        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            if (sender is Button btn)
                ChangeButtonStateUponClick(btn);

            var ingForm = new IngredientsPage(new IngredientService());
            OpenForm(ingForm);
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
            ChangeButtonStateUponClick(sender! as Button);

            var posService = new CartService();
            var saleService = new SaleService();
            var posForm = new FPOS(posService, saleService);
            OpenForm(posForm);
        }

        private void _contentsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            ChangeButtonStateUponClick(sender as Button);
            PriceManagementPage priceManagement = new(new ProductVariantService());
            OpenForm(priceManagement);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ChangeButtonStateUponClick(sender as Button);
            UnitManagementPage unitmagmnt = new(new GenericRepository<Unit>());
            OpenForm(unitmagmnt);
        }

        private void _btnSupplierManagement_Click(object sender, EventArgs e)
        {
            ChangeButtonStateUponClick(sender as Button);
            SupplierManagement sm = new(new SupplierService());
            OpenForm(sm);
        }

        private void _btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            ChangeButtonStateUponClick(sender as Button);
            var po = new PurchaseOrderPage(new PurchaseOrderService());
            OpenForm(po);
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
            if(sender is Button b)
            {
                ChangeButtonStateUponClick(b);

                var saleService = new SaleService();
                var saleForm = new SalePage(saleService);

                OpenForm(saleForm);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ChangeButtonStateUponClick(sender as Button);
           // OpenForm<AuditTrail>();
        }

        private void _btnSales_Click(object sender, EventArgs e)
        {
            ChangeButtonStateUponClick(sender as Button);
            SalePage sp = new(new SaleService());
            OpenForm(sp);
        }
    }
}
