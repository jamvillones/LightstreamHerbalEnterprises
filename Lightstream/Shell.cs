using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream
{
    public partial class Shell : Form
    {
        public Shell()
        {
            InitializeComponent();
            divider.SplitterDistance = 1085;
            divider.Panel2Collapsed = true;
        }

        #region topbar functionality
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void dragCallback_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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

        public bool CanClose { get; private set; } = true;

        private void Shell_Load(object sender, EventArgs e)
        {
            var login = new LoginForm();
            login.FormClosed += Login_FormClosed;
            AddControl(login);

            //notifyIcon1.ShowBalloonTip(1, "notif", "test notification", ToolTipIcon.Info);
        }

        private void Login_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (sender is LoginForm l)
                if (l.IsLoginSuccessful)
                {
                    userButton.Enabled = true;
                    logoutButton.Enabled = true;

                    userButton.Text = l.CurrentLogin!.FullName ?? "Current User";
                    bool isAdmin = l.CurrentLogin!.UserType == (int)UserType.admin;
                    Form form = isAdmin ? new Main() : new FPOS(new CartService(), new SaleService());
                    moduleType.Text = isAdmin ? "Main Control" : "Point of Sale";
                    form.FormClosed += Form_FormClosed;

                    AddControl(form);
                }
        }

        private void Form_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (sender is ILogoutForm f)
            {
                if (f.IsLoggedout)
                {
                    var login = new LoginForm();
                    login.FormClosed += Login_FormClosed;
                    AddControl(login);
                }
            }
        }

        private void Shell_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !CanClose;
        }

        Form? currentControl = null;
        void AddControl(Form next)
        {
            currentControl = next;
            currentControl.TopLevel = false;
            this.contentsPanel.Controls.Add(currentControl);
            currentControl.Dock = DockStyle.Fill;
            currentControl.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (currentControl is ILogoutForm il)
            {
                if (MessageBox.Show("Are you sure you want to log off?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    LogoutCurrentForm(il);
            }
        }

        void LogoutCurrentForm(ILogoutForm form)
        {
            form.Logout();
            if (form.IsLoggedout)
            {
                userButton.Enabled = false;
                logoutButton.Enabled = false;
                moduleType.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            divider.Panel2Collapsed = !divider.Panel2Collapsed;
        }
    }
}
