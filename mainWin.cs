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
    public partial class mainWin : Form
    {
        public mainWin()
        {
            InitializeComponent();
        }
        private void mainWin_Load(object sender, EventArgs e)
        {
            DBHelper.init();
            loadCBX();
        }

        private void loadCBX()
        {
            List<contactTBL> lst = DBHelper.allContacts;
            cbxContacts.DataSource = lst;
            cbxContacts.DisplayMember = "fullName";
            cbxContacts.ValueMember = "Id";
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            string fn = txbAddFirstName.Text.Trim();
            string ln = txbAddLastName.Text.Trim();
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
                selected.firstName = txbFNUpdate.Text.Trim();
                selected.lastName = txbLNUpdate.Text.Trim();
                DBHelper.updateContact(selected);
                loadCBX();
            }
        }
    }
}
