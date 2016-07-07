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
                if (!db.Workers.Any())
                {
                    Workers newWorker = new Workers
                    {
                        Id = Guid.NewGuid(),
                        Name = "Crisan",
                        Surname = "Flavius",
                        Username = "flavicrisan",
                        Password = "password",
                        Created = DateTime.Now,
                        IsActive = true
                    };
                    db.Workers.Add(newWorker);
                    db.SaveChanges();
                }
                var worker =
                    db.Workers
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
    }
}
