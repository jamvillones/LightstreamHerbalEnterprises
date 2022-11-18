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
using static System.Net.Mime.MediaTypeNames;

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

            Brush brush = new SolidBrush(Color.Red);

            //// Create a bitmap and draw text on it
            //Bitmap bitmap = new Bitmap(16, 16);
            //Graphics graphics = Graphics.FromImage(bitmap);
            //graphics.DrawString("9", this.Font, brush, 0, 0);

            //// Convert the bitmap with text to an Icon
            //Icon icon = Icon.FromHandle(bitmap.GetHicon());

            //notificationIcon.Icon = icon;

            //notificationIcon.ShowBalloonTip(1, "notif", "test notification", ToolTipIcon.Info);
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
            //this.Visible = false;
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
            TryLogout();
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

        private void notificationIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowShell();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowShell();
        }

        void ShowShell()
        {
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;

            //this.Visible = true;
            Activate();
            this.BringToFront();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TryLogout();
        }

        bool TryLogout()
        {
            if (currentControl is null) return false;

            this.Visible = true;
            if (currentControl is ILogoutForm il)
            {
                if (MessageBox.Show("Are you sure you want to log off?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    LogoutCurrentForm(il);
                    return true;
                }
            }

            return false;
        }
    }
}
