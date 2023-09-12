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
    public partial class emailWin : Form
    {
        List<contactTBL> conatctList;
        List<emailTBL> currEmailList;
        public emailWin()
        {
            InitializeComponent();
        }

        private void emailWin_Load(object sender, EventArgs e)
        {
            currEmailList = new List<emailTBL>();
            conatctList = DBHelper.allContacts;
            dgvContacts.DataSource = cbxContactsHidden.DataSource = conatctList;
        }

        private void cbxContactsHidden_SelectedIndexChanged(object sender, EventArgs e)
        {
            contactTBL contact = (contactTBL)cbxContactsHidden.SelectedItem;
            if (contact == null)
            {
                updateButtons();
                return;
            }
            currEmailList = DBHelper.allEmails.Where(x => x.cID == contact.Id).ToList();
            dgvEmails.DataSource = cbxEmailHidden.DataSource = currEmailList;
            updateButtons();
            cbxEmailHidden_SelectedIndexChanged(null, null);
        }
        private bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        private void updateButtons()
        {
            btnDeleteEmail.Enabled = btnUpdateEmail.Enabled = currEmailList.Count > 0;
            if (currEmailList.Count == 0)
                txbEmailUpdate.Text = "";
        }

        private void cbxEmailHidden_SelectedIndexChanged(object sender, EventArgs e)
        {
            emailTBL e1 = (emailTBL)cbxEmailHidden.SelectedItem;
            if (e1 == null)
            {
                updateButtons();
                return;
            }
            txbEmailUpdate.Text = e1.email;

        }

        private void btnAddEmail_Click(object sender, EventArgs e)
        {
            string emailStr = txbEmailAdd.Text.Trim();
            if (!IsValidEmail(emailStr))
            {
                errorProvider1.SetError(txbEmailAdd, "Email not valid");
                return;
            }
            errorProvider1.SetError(txbEmailAdd, "");
            emailTBL e1 = new emailTBL();
            contactTBL contact = (contactTBL)cbxContactsHidden.SelectedItem;
            if (contact == null)
            {
                updateButtons();
                return;
            }
            txbEmailUpdate.Text = e1.email;
            e1.cID = contact.Id;
            e1.email = emailStr;
            DBHelper.addEmail(e1);
            cbxContactsHidden_SelectedIndexChanged(null, null);
            txbEmailAdd.Text = "";

        }

        private void btnUpdateEmail_Click(object sender, EventArgs e)
        {
            emailTBL e1 = (emailTBL)cbxEmailHidden.SelectedItem;
            if (e1 == null)
            {
                updateButtons();
                return;
            }
            string emailStr = txbEmailUpdate.Text.Trim();
            if (!IsValidEmail(emailStr))
            {
                errorProvider1.SetError(txbEmailUpdate, "Email not valid");
                return;
            }
            e1.email = emailStr;
            DBHelper.updateEmail(e1);
            cbxContactsHidden_SelectedIndexChanged(null, null);
        }

        private void btnDeleteEmail_Click(object sender, EventArgs e)
        {
            emailTBL e1 = (emailTBL)cbxEmailHidden.SelectedItem;
            if (e1 == null)
            {
                updateButtons();
                return;
            }
            DBHelper.deleteEmail(e1);
            cbxContactsHidden_SelectedIndexChanged(null, null);
        }
    }
}
