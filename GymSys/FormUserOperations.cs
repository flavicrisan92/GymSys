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
        private static Users _userToEdit;

        public FormUserOperations(Users user, Actions.Operations operation)
        {
            InitializeComponent();
            _operation = operation;
            if (_operation == Actions.Operations.EditUser)
            {
                _userToEdit = user;
                SetupUser(user);
            }
        }

        private void SetupUser(Users user)
        {
            txtName.Text = user.Name;
            txtSurname.Text = user.Surname;
            txtUsername.Text = user.Username;
            txtUsername.ReadOnly = true;
            this.Text = "Editare utilizator";
            btnSave.Text = "Salveaza";
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
                    Close();
                    ucAdministration.Instance.LoadUsers(Actions.Operations.AddUser);
                }
                else if (_operation == Actions.Operations.EditUser)
                {

                    var userToEdit = db.Users.FirstOrDefault(m => m.Id == _userToEdit.Id);

                    if (userToEdit != null)
                    {
                        userToEdit.Name = txtName.Text;
                        userToEdit.Surname = txtSurname.Text;
                    }
                    db.SaveChanges();
                    Close();
                    ucAdministration.Instance.LoadUsers(Actions.Operations.EditUser);
                    Close();
                    ucAdministration.Instance.LoadUsers(Actions.Operations.AddUser);

                }
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
            //if (string.IsNullOrEmpty(txtPassword.Text))
            //{
            //    ShowMessageRequired();
            //    return false;
            //}
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
