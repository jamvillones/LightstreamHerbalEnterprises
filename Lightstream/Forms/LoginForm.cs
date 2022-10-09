using Lightstream.Models;

namespace Lightstream
{
    public partial class LoginForm : Form
    {
        private Models.DbContextFactory dbFactory = new Models.DbContextFactory();
        #region private fields
        int lockinPeriod = 30;
        string username => textBox2.Text.Trim();
        string password => textBox3.Text.Trim();
        bool isInCountdown => timeCounter > 0;
        bool shouldValidateExit = true;
        bool isLoginEnabled => !(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password));
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
            loginBtn.Enabled = false;
            ///set the timer for lockinperiod
            timeCounter = lockinPeriod;
            ///change the text to its prompt
            loginBtn.Text = "Login locked for " + timeCounter;
            ///start the timer
            countdownTimer.Start();
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
            loginBtn.Enabled = isLoginEnabled && !isInCountdown;
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

        public Login CurrentLogin { get; private set; }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            IsLoginSuccessful = TryLogin(username, password);

            if (!IsLoginSuccessful)
            {
                Attempts--;
                return;
            }

            shouldValidateExit = false;
            this.Close();
        }
        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            timeCounter--;
            loginBtn.Text = "Login locked for " + timeCounter;
            if (timeCounter <= 0)
            {
                Attempts = 3;

                loginBtn.Enabled = isLoginEnabled;

                loginBtn.Text = "Login";
                countdownTimer.Stop();
            }
        }
    }
}