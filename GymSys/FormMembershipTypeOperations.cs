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
        private MembershipType _membershipType;
        LocalDBEntities db = new LocalDBEntities();
        public FormMembershipTypeOperations(MembershipType membershipType, Actions.Operations operation)
        {
            _operation = operation;
            InitializeComponent();
            CheckOperation(_operation, membershipType);
        }

        private void CheckOperation(Actions.Operations operation, MembershipType membershipType)
        {
            switch (operation)
            {
                case Actions.Operations.EditMembershipType:
                    this.Text = "Editare tip abonament";
                    btnSave.Text = "Salveaza";
                    _membershipType = membershipType;
                    SetUpEditMembershipType(membershipType);
                    break;
            }
        }

        private void SetUpEditMembershipType(MembershipType membershipType)
        {
            txtType.Text = membershipType.Type;
            txtDescription.Text = membershipType.Description;
            txtPrice.Text = membershipType.Price.ToString();
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
                    ucAdministration.Instance.LoadMembershipTypes(Actions.Operations.AddMembershipType);
                }
            }
            else if (_operation == Actions.Operations.EditMembershipType)
            {
                if (ValidateMembershipType())
                {
                    double.TryParse(txtPrice.Text, out price);
                    var membershuptypeToEdit = db.MembershipType.FirstOrDefault(m => m.Id == _membershipType.Id);
                   
                    if (membershuptypeToEdit != null)
                    {
                        membershuptypeToEdit.Description = txtDescription?.Text;
                        membershuptypeToEdit.Price = price;
                        membershuptypeToEdit.Type = txtType.Text;
                    }
                    db.SaveChanges();
                    Close();
                    ucAdministration.Instance.LoadMembershipTypes(Actions.Operations.EditMembershipType);
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
