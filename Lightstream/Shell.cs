﻿using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.Forms;
using Lightstream.Services;
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
    public partial class Shell : Form, INotifier
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

           
        }
        GenericRepository<Ingredient> _ingService;
        private void Login_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (sender is LoginForm l)
                if (l.IsLoginSuccessful)
                {
                    //using (var save_audit = new save_audit(new GenericRepository<Unit>())){}
                        //save_audit sa = new save_audit(new GenericRepository<Unit>());
                    //sa.save_trailAsync("admin", "admin", "login");


                    userButton.Enabled = true;
                    logoutButton.Enabled = true;

                    userButton.Text = l.CurrentLogin!.FullName ?? "Current User";
                    bool isAdmin = l.CurrentLogin!.UserType == (int)UserType.admin;
                    Form form = isAdmin ? new Main(this) : new FPOS(new CartService(), new SaleService(), this);
                    moduleType.Text = isAdmin ? "Main Control" : "Point of Sale";
                    form.FormClosed += Form_FormClosed;
                    label3.Visible = true;
                    AddControl(form);
                }
        }

        private void Form_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (sender is ILogoutForm f)
            {
                if (f.IsLoggedout)
                {
                    userButton.Visible = false;
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
            //this.Close();
            this.Visible = false;
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
               
                logoutButton.Enabled = false;
                moduleType.Text = string.Empty;
                label3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            divider.Panel2Collapsed = !divider.Panel2Collapsed;
        }

        private void notificationIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowShell();
            //ShowWindow();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowShell();
            //ShowWindow();
        }

        void ShowShell()
        {
            this.Visible = true;
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

        protected override void WndProc(ref Message message)
        {
            if (message.Msg == SingleInstance.WM_SHOWFIRSTINSTANCE)
            {
                ShowWindow();
            }
            base.WndProc(ref message);
        }
        public void ShowWindow()
        {
            // Insert code here to make your form show itself.
            //WinApi.ShowToFront(this.Handle);

            ShowShell();
        }

        public void ShowNotification(string title, string body, ToolTipIcon icon)
        {
            notificationIcon.ShowBalloonTip(1, title, body, icon);
        }

        private void userButton_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = nameof(ProductVariant.StockQty); 
        }
    }
}
