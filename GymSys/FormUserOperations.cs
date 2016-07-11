using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        private static Users _loggedUser;

        public FormUserOperations(Users user, Actions.Operations operation, Users loggedUser)
        {
            InitializeComponent();
            _operation = operation;
            if (_operation == Actions.Operations.EditUser)
            {
                _loggedUser = loggedUser;
                _userToEdit = user;
                SetupUser(user, loggedUser);
            }
        }

        private void SetupUser(Users user, Users loggeduser)
        {
            txtName.Text = user.Name;
            txtSurname.Text = user.Surname;
            txtUsername.Text = user.Username;
            txtUsername.ReadOnly = true;
            if (isOwner(user, loggeduser))
            {
                txtPassword.Text = user.Password;
            }
            else
            {
                txtPassword.Visible = false;
                txtPassword.ReadOnly = true;
            }
            cbAdmin.Checked = user.IsAdmin;
            this.Text = "Editare utilizator";
            btnSave.Text = "Salveaza";
        }

        public bool isOwner(Users user, Users loggedUser)
        {
            if (loggedUser != null && user.Id == loggedUser.Id)
            {
                return true;
            }
            return false;
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
                        IsActive = true,
                        IsAdmin = cbAdmin.Checked
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
                        if (isOwner(userToEdit, _loggedUser))
                        {
                            userToEdit.Password = txtPassword.Text;
                        }
                        userToEdit.IsAdmin = cbAdmin.Checked;

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
            if (isOwner(_userToEdit, _loggedUser) && string.IsNullOrEmpty(txtPassword.Text))
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
