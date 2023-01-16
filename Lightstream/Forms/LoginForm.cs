

using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using Lightstream.Forms;
using Microsoft.EntityFrameworkCore;

namespace Lightstream
{
    public partial class LoginForm : Form
    {
        private DbContextFactory dbFactory = new DbContextFactory();
        #region private fields
        int lockinPeriod = 10;
        int loginErrorTimeIncrement = 10;
        string username => textBox2.Text.Trim();
        string password => textBox3.Text.Trim();
        bool isInCountdown => timeCounter > 0;
        bool shouldValidateExit = true;
        bool canLogin => !string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password) && !isLoading;
        int timeCounter = 0;
        int _attempts = 3;
        public int Attempts
        {
            get => _attempts;
            set
            {
                _attempts = value;
                loginBtn.Text = "Login unsuccessful; (" + Attempts + ") left...";
                if (_attempts <= 0)
                {
                    LockLogin();
                }
            }
        }
        public bool IsLoginSuccessful { get; private set; } = false;
        #endregion

        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// handles the locking mechanism of login
        /// </summary>
        private void LockLogin()
        {
            ///disable the button
            ///set the timer for lockinperiod
            timeCounter = lockinPeriod;
            //lockinPeriod += loginErrorTimeIncrement;
            lockinPeriod *= 2;
            ///change the text to its prompt
            if (timeCounter > 0)
            {
                loginBtn.Enabled = false;
                loginBtn.Text = "Login locked for " + timeCounter + (timeCounter > 1 ? " seconds" : " second");
                ///start the timer
                countdownTimer.Start();
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (shouldValidateExit)
                if (MessageBox.Show("Are you sure you want to quit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
        }
        private void textFields_TextChanged(object sender, EventArgs e)
        {
            loginBtn.Enabled = canLogin && !isInCountdown;
        }
        /// <summary>
        /// the method that handles login validation
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        bool TryLogin(string username, string pass)
        {
            ///create the dbcontext
            using (var context = dbFactory.CreateDbContext())
            {
                ///get/find the login with the supplied username and password
                var login = context.Logins.FirstOrDefault(x => x.Username == username && x.Password == pass);

                ///if found, assign the login to the CurrentLogin Variable and then return true
                if (login is not null)
                {
                    CurrentLogin = login;
                    return true;
                }
            }
            ///no login detected, invalid log in
            return false;
        }

        async Task<Login?> TryLoginAsync(string username, string pass)
        {
            return await Task.Run(async () =>
            {
                using (var context = dbFactory.CreateDbContext())
                    return await context.Logins.FirstOrDefaultAsync(x => x.Username == username && x.Password == pass);
            });
        }

        public Login? CurrentLogin { get; private set; }

        bool isLoading = false;
        private async void loginBtn_Click(object sender, EventArgs e)
        {
            isLoading = true;
            loginBtn.Text = "Logging in...";
            loginBtn.Enabled = canLogin;

            CurrentLogin = await TryLoginAsync(username, password);
            IsLoginSuccessful = CurrentLogin is not null;

            if (!IsLoginSuccessful)
            {
                isLoading = false;
                loginBtn.Enabled = true;
                Attempts--;
                return;
            }

            shouldValidateExit = false;
            isLoading = false;
            this.Close();
        }
        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            timeCounter--;
            loginBtn.Text = "Login locked for " + timeCounter + (timeCounter > 1 ? " seconds" : " second");
            if (timeCounter <= 0)
            {
                Attempts = 3;

                loginBtn.Enabled = canLogin;

                loginBtn.Text = "Login";
                countdownTimer.Stop();
            }
        }

        private void createNewBtn_Click(object sender, EventArgs e)
        {
            using (var createLogin = new CreateNewUserForm())
            {
                if (createLogin.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Main frm = new Main();
            this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void userNameLine_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void passwordLine_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}