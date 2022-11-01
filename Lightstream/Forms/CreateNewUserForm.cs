using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream.Forms
{
    public enum UserType { admin, cashier, count }
    public partial class CreateNewUserForm : Form
    {
        public CreateNewUserForm()
        {
            InitializeComponent();
        }

        private void _save_Click(object sender, EventArgs e)
        {
            if (!DoValidation()) return;

            if (SaveNewCitizen())
                DialogResult = DialogResult.OK;
        }

        private bool CanSave => _password.Text.Trim() == _confirmPassword.Text.Trim() &&
            !string.IsNullOrWhiteSpace(_userName.Text);
        private bool SaveNewCitizen()
        {
            try
            {
                using (var context = new LHE_DBContext())
                {
                    var login = new Login()
                    {
                        FirstName = _firstName.Text.Trim(),
                        LastName = _lastName.Text.Trim(),
                        Email = _email.Text.Trim(),
                        UserType = (int)UserType.cashier,
                        Username = _userName.Text.Trim(),
                        Password = _password.Text.Trim(),
                        DateTimeRegistered = DateTime.Now
                    };

                    context.Logins.Add(login);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool DoValidation()
        {
            if (!CanSave)
            {
                MessageBox.Show("Make sure the required fields are filled out and passwords matched", "Saving failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (MessageBox.Show("Are you sure you want to save new Login?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return false;

            return true;
        }

        private void CreateNewUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
