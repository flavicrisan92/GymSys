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
    public partial class FormMembershipTypeOperations : Form
    {
        private Actions.Operations _operation;
        LocalDBEntities db = new LocalDBEntities();
        public FormMembershipTypeOperations(Actions.Operations operation)
        {
            _operation = operation;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double price;
            if (_operation == Actions.Operations.AddMembershipType)
            {
                if (ValidateMembershipType())
                {
                    double.TryParse(txtPrice.Text, out price);
                    MembershipType membershipType = new MembershipType
                    {
                        Type = txtType.Text,
                        Price = price,
                        IsActive = true,
                        Created = DateTime.Now,
                        Description = txtDescription.Text
                    };
                    db.MembershipType.Add(membershipType);
                    db.SaveChanges();
                    this.Close();
                    ucAdministration.Instance.LoadMembershipTypes();
                }
            }
        }

        private bool ValidateMembershipType()
        {

            if (string.IsNullOrEmpty(txtType.Text))
            {
                ShowMessageRequired();
                return false;
            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                ShowMessageRequired();
                return false;
            }
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                ShowMessageRequired();
                return false;
            }
            if (_operation == Actions.Operations.AddMembershipType)
            {
                if (db.MembershipType.Any(u => u.Type == txtType.Text))
                {
                    ShowMessageDuplicate();
                    return false;
                }
            }
            return true;
        }

        private void ShowMessageRequired()
        {
            MessageBox.Show("Toate campurile sunt obigatorii!");
        }
        private void ShowMessageDuplicate()
        {
            MessageBox.Show("Denumirea abonamentului exista deja in baza de date!");
        }
    }
}
