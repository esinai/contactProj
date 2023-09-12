using contactProj.IFS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contactProj
{
    public partial class contactWin : Form
    {
        public contactWin()
        {
            InitializeComponent();
        }
        private void mainWin_Load(object sender, EventArgs e)
        {
           
            loadCBX();
        }

        private void loadCBX()
        {
            List<contactTBL> lst = DBHelper.allContacts;
            cbxContacts.DataSource = dgvContacts.DataSource = lst;
            cbxContacts.DisplayMember = "fullName";
            cbxContacts.ValueMember = "Id";
            btnDelete.Enabled = btnUpdateContact.Enabled = lst.Count > 0;
            if (lst.Count == 0)
            {
                txbFNUpdate.Text = "";
                txbLNUpdate.Text = "";
            }
        }
        public void moveToPage(int idx)
        {
            tabControl1.SelectedIndex = idx;
        }
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            if (!validAddForm())
                return;
                      
            string fn = txbAddFirstName.Text.Trim();
            string ln = txbAddLastName.Text.Trim();
            if (checkIfInDB(fn,ln))
            {
                MessageBox.Show("Contact Exist");
                return;
            }
            contactTBL cToAdd = new contactTBL();
            cToAdd.firstName = fn;
            cToAdd.lastName = ln;
            cToAdd.creationDate = DateTime.Now;

            cToAdd = DBHelper.addContact(cToAdd);
            if (cToAdd != null)
            {
                MessageBox.Show("OK");
                txbAddFirstName.Text = "";
                txbAddLastName.Text = "";
                loadCBX();
            }
        }

        private bool validAddForm()
        {
            bool a1 = checkAddFN();
            bool a2 = checkAddLN();
           
            return a1 && a2;
        }

        private bool checkIfInDB(string fn, string ln)
        {
            contactTBL c1 = DBHelper.getContactByName(fn, ln);
            return c1 != null;
        }

        private bool checkAddLN()
        {
            string ln = txbAddLastName.Text.Trim();
            if (ln.Length == 1)
            {
                errorProvider1.SetError(txbAddLastName, "Last name at least 2 letters");
                return false;
            }
            if (!ln.All(Char.IsLetter))
            {
                errorProvider1.SetError(txbAddLastName, "only letters allows");
                return false;
            }
            errorProvider1.SetError(txbAddLastName, "");
            return true;
        }

        private bool checkAddFN()
        {
            string fn = txbAddFirstName.Text.Trim();
            if (fn.Length < 2)
            {
                errorProvider1.SetError(txbAddFirstName, "First name is must need at least 2 letters");
                return false;
            }
            if (!fn.All(Char.IsLetter))
            {
                errorProvider1.SetError(txbAddFirstName, "only letters allows");
                return false;
            }
            errorProvider1.SetError(txbAddFirstName, "");
            return true;
        }

        private void cbxContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            contactTBL selected = (contactTBL)cbxContacts.SelectedItem;
            if (selected != null)
            {
                txbFNUpdate.Text = selected.firstName;
                txbLNUpdate.Text = selected.lastName;
            }

        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            contactTBL selected = (contactTBL)cbxContacts.SelectedItem;
            if (selected != null)
            {
                int idx = cbxContacts.SelectedIndex;
                selected.firstName = txbFNUpdate.Text.Trim();
                selected.lastName = txbLNUpdate.Text.Trim();
                DBHelper.updateContact(selected);
                loadCBX();
                cbxContacts.SelectedIndex = idx;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {



            contactTBL selected = (contactTBL)cbxContacts.SelectedItem;
            if (selected == null)
            {
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DBHelper.deleteContact(selected);
                loadCBX();
            }
        }
    }
}
