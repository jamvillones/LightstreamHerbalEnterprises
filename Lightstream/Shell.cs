using Lightstream.DataAccess.Models;
using Lightstream.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        public bool CanClose { get; private set; } = true;

        private void Shell_Load(object sender, EventArgs e)
        {
            var login = new LoginForm();
            login.FormClosed += Login_FormClosed;
            AddControl(login);
        }

        private void Login_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (sender is LoginForm l)
                if (l.IsLoginSuccessful)
                {
                    userButton.Enabled = true;
                    logoutButton.Enabled = true;
                    userButton.Text = l.CurrentLogin.FullName??"Current User";
                    Form form = l.CurrentLogin!.UserType == (int)UserType.admin ? new Main() : new FPOS();
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
            this.panel1.Controls.Add(currentControl);
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
                LogoutCurrentForm(il);
        }

        void LogoutCurrentForm(ILogoutForm form)
        {
            form.Logout();
            if (form.IsLoggedout)
            {
                userButton.Enabled = false;
                logoutButton.Enabled = false;
            }
        }
    }
}
