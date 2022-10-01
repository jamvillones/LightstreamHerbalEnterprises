namespace LightstreamHerbalEnterprise
{
    public partial class LoginForm : Form
    {
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
                button2.Text = "Login unsuccessful; (" + Attempts + ") left...";
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
        private void LockLogin()
        {
            button2.Enabled = false;
            timeCounter = lockinPeriod;
            button2.Text = "Login locked for " + timeCounter;
            countdownTimer.Start();
        }
        private void button3_Click(object sender, EventArgs e)
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
            button2.Enabled = isLoginEnabled && !isInCountdown;
        }
        bool TryLogin(string username, string pass)
        {
            if (username == "admin" && pass == "123")
                return true;
            return false;
        }
        private void button2_Click(object sender, EventArgs e)
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
            button2.Text = "Login locked for " + timeCounter;
            if (timeCounter <= 0)
            {
                Attempts = 3;

                button2.Enabled = isLoginEnabled;

                button2.Text = "Login";
                countdownTimer.Stop();
            }
        }
    }
}