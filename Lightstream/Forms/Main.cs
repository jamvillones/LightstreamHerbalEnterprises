using Lightstream.Forms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Lightstream
{

    public partial class Main : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        Panel[] collapsiblePanels;
        Button? currentButton = null;
        Form? currentForm = null;
        Color selectedButtonColor = Color.FromArgb(66, 120, 37);
        Color normalButtonColor = Color.FromArgb(45,45,45);
        public bool IsLoggedOut { get; private set; } = false;
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
            if (MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            IsLoggedOut = true;
            this.Close();
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

            if (p.Visible)
            {
                foreach (var i in collapsiblePanels.Where(x => x != p))
                    if (i.Visible) i.Visible = false;
            }
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

        #region windowchrome functions
        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// handles the drag and maximize of custom status bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2)
            {
                this.WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region opening form
        private void button9_Click_1(object sender, EventArgs e)
        {
            if (sender is Button btn)
                ChangeButtonStateUponClick(btn);

            OpenForm<ProductsPage>();
        }
        private void button10_Click_1(object sender, EventArgs e)
        {
            if (sender is Button btn)
                ChangeButtonStateUponClick(btn);

            OpenForm<IngredientsPage>();
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
            CreateNewUserForm cc = new CreateNewUserForm();
            cc.Show();
        }
    }
}
