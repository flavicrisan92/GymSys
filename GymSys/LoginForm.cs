using System;
using System.Linq;
using System.Windows.Forms;

namespace GymSys
{
    public partial class LoginForm : Form
    {
        LocalDBEntities db = new LocalDBEntities();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                if (!db.Users.Any())
                {
                    Users user = new Users();
                    user.Name = "Crisan";
                    user.Surname = "Flavius";
                    user.Username = "flavicrisan";
                    user.Password = "123";
                    user.Created = DateTime.Now;
                    user.IsActive = true;
                    db.Users.Add(user);
                    db.SaveChanges();
                }
                var worker =
                    db.Users
                        .FirstOrDefault(w => w.Username == txt_UserName.Text && w.Password == txt_Password.Text && w.IsActive);
                if (worker != null)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(sender, e);
            }
        }
    }
}
