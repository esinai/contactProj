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
using contactProj.Models;

namespace contactProj
{
    public partial class reportWin : Form
    {
        List<ContactModel> modelList;
        List<contactTBL> allContactsList;
        public reportWin()
        {
            InitializeComponent();
        }

        private void reportWin_Load(object sender, EventArgs e)
        {
            modelList = new List<ContactModel>();
            allContactsList = DBHelper.allContacts;
            flowPanel.ScrollControlIntoView(this);
            foreach (contactTBL c in allContactsList)
            {
                ContactModel cModel = new ContactModel(c);
                modelList.Add(cModel);
                ContactControl control = new ContactControl();
                control.FullName = cModel.fullName;
                control.setEmailList(cModel.emailList);
                control.setPhoneList(cModel.phoneList);
                control.Width = flowPanel.Width;

                flowPanel.Controls.Add(control);
            }
            lblNumOfContacts.Text = "Total contacts : " + modelList.Count;
            double avgPhone = DBHelper.allPhones.Count / (double)modelList.Count;
            double avgEmail = DBHelper.allEmails.Count / (double)modelList.Count;
            avgEmail = Math.Round(avgEmail, 1);
            avgPhone = Math.Round(avgPhone, 1);
            lblAvgEmail.Text = "Avg Email : " + avgEmail;
            lblAvgPhone.Text = "Avg Phone : " + avgPhone;

        }
    }
}
