using Lightstream.Models;

namespace Lightstream
{
    public partial class FrmLgn : Form
    {
        public FrmLgn()
        {
            InitializeComponent();
        }

        private void btnCnfrm_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text.Equals("a1234", StringComparison.OrdinalIgnoreCase))


            {
                var db = new FDashboard();
               
                db.Show();
                this.Hide();
            }

            else if (txtUser.Text == "cashier" && txtPass.Text.Equals("c1234", StringComparison.OrdinalIgnoreCase))

            {
                var cdb = new FDashboard();
                cdb.Show();
                this.Hide();
            }

        }

        private void FrmLgn_Load(object sender, EventArgs e)
        {
            //using(var context = new LHEContext())
            //{
            //    var logins = context.Logins;
            //    var login = context.Logins.FirstOrDefault(foo) ;

            //    context.Logins.Add(new Login() { });
            //    if(login is not null)
            //    context.Logins.Remove(login);
            //    context.Logins.Update(login);
            //    context.SaveChanges();
                

            //    var loginswith0 = context.Logins.Where(foo);

            //    IEnumerable<string> loginNames = context.Logins.Select(login => login.Name);

            //    foreach(var s in loginNames)
            //    {
            //        Console.WriteLine(s);
            //    }
                
            //}
        }

        //bool foo(Login l)
        //{
        //    return l.Id < 0;
        //}

        //string feef(Login l)
        //{
        //    return l.Name;
        //}

    }
}