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
            if (!db.Users.Any())
            {
                Users newUser = new Users
                {
                    Name = "Crisan",
                    Surname = "Flavius",
                    Username = "flavicrisan",
                    Password = "123",
                    Created = DateTime.Now,
                    IsActive = true,
                    IsAdmin = true
                };
                db.Users.Add(newUser);
                db.SaveChanges();
            }
            var user =
                db.Users
                    .FirstOrDefault(w => w.Username == txt_UserName.Text && w.Password == txt_Password.Text && w.IsActive);
            if (user != null)
            {
                this.Hide();
                MainForm mainForm = new MainForm(user);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Nume de utilizator sau parola incorecte!");
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(sender, e);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txt_UserName.Select();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
