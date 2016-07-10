using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSys
{
    public partial class FormUserOperations : Form
    {
        LocalDBEntities db = new LocalDBEntities();
        private Actions.Operations _operation;
        public FormUserOperations(Actions.Operations operation)
        {
            InitializeComponent();
            _operation = operation;
            if (_operation == Actions.Operations.EditUser)
            {
                SetupUser();
            }
        }

        private void SetupUser()
        {
            throw new NotImplementedException();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateUser())
            {
                if (_operation == Actions.Operations.AddUser)
                {
                    Users newUser = new Users
                    {
                        Name = txtName.Text,
                        Username = txtUsername.Text,
                        Surname = txtSurname.Text,
                        Password = txtPassword.Text,
                        Created = DateTime.Now,
                        IsActive = true
                    };
                    db.Users.Add(newUser);
                    db.SaveChanges();
                }
                else if (_operation == Actions.Operations.EditUser)
                {

                }
                this.Close();
                ucAdministration.Instance.LoadUsers();
            }
            else
            {

            }
        }

        private bool ValidateUser()
        {
            if (_operation == Actions.Operations.AddUser)
            {
                if (db.Users.Any(u => u.Username == txtUsername.Text))
                {
                    ShowMessageDuplicate();
                    return false;
                }
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                ShowMessageRequired();
                return false;
            }
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                ShowMessageRequired();
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                ShowMessageRequired();
                return false;
            }
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                ShowMessageRequired();
                return false;
            }
            return true;
        }

        private void ShowMessageRequired()
        {
            MessageBox.Show("Toate campurile sunt obigatorii!");
        }
        private void ShowMessageDuplicate()
        {
            MessageBox.Show("Numele de utilizator exista deja in baza de date!");
        }
    }
}
