using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using contactProj.IFS;

namespace contactProj
{
    public partial class phoneWin : Form
    {
        List<phoneTBL> currList;
        List<contactTBL> allContacts;
        public phoneWin()
        {
            InitializeComponent();
        }

        private void phoneWin_Load(object sender, EventArgs e)
        {
            loadContacts();

        }

        private void loadContacts()
        {
            allContacts = DBHelper.allContacts;
            dgvContacts.DataSource = cbxContactsHidden.DataSource = allContacts;
        }

        private void cbxContactsHidden_SelectedIndexChanged(object sender, EventArgs e)
        {
            contactTBL selected = (contactTBL)cbxContactsHidden.SelectedItem;
            if (selected != null)
            {
                currList = DBHelper.allPhones.Where(x => x.cID == selected.Id).ToList();
                dgvPhones.DataSource = cbxPhoneHidden.DataSource = currList;
                
            }
            cbxPhoneHidden_SelectedIndexChanged(null, null);
            updateButtons();
            
        }

        private void updateButtons()
        {
            btnDelete.Enabled = btnUpdate.Enabled = currList.Count > 0;
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            contactTBL selected = (contactTBL)cbxContactsHidden.SelectedItem;
            if (selected != null)
            {
                // need to check validation of phone number
                string phoneStr = txbPhoneAdd.Text.Trim();
                phoneTBL p1 = new phoneTBL();
                p1.cID = selected.Id;
                p1.phone = phoneStr;
                DBHelper.addPhone(p1);
                loadContacts();
                cbxContactsHidden_SelectedIndexChanged(null, null);
                txbPhoneAdd.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbxPhoneHidden_SelectedIndexChanged(object sender, EventArgs e)
        {
            phoneTBL p1 = (phoneTBL)cbxPhoneHidden.SelectedItem;
            if (p1 == null)
            {
                txbPhoneUpdate.Text = "";
                return;
            }
            txbPhoneUpdate.Text = p1.phone;
            updateButtons();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            phoneTBL selectedPhone = (phoneTBL)cbxPhoneHidden.SelectedItem;
            if (selectedPhone != null)
            {
                // validation needed
                selectedPhone.phone = txbPhoneUpdate.Text;
                DBHelper.updatePhone(selectedPhone);
                cbxContactsHidden_SelectedIndexChanged(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            phoneTBL selectedPhone = (phoneTBL)cbxPhoneHidden.SelectedItem;
            if (selectedPhone != null)
            {
                // validation needed
                DialogResult result = MessageBox.Show("Are you sure", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DBHelper.deletePhone(selectedPhone);
                    cbxContactsHidden_SelectedIndexChanged(null, null);
                }

                
            }
        }
    }
}
