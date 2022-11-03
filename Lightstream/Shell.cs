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
            this.Controls.Add(currentControl);
            currentControl.Dock = DockStyle.Fill;
            currentControl.Show();
        }
    }
}
