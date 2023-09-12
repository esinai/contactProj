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
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }

        private string _fullName;
        [Category("Custom")]
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value;
                lblFullName.Text = value;
            }
        }
        [Category("Custom")]
        public Color FullNameForeColor
        {
            get { return lblFullName.ForeColor; }
            set { lblFullName.ForeColor = value; }
        }

        public void setPhoneList(List<phoneTBL> lst)
        {
            PhoneListView.Items.Clear();
            foreach (phoneTBL p in lst)
            {
                PhoneListView.Items.Add(new ListViewItem(p.phone));
            }
        }
        public void setEmailList(List<emailTBL> lst)
        {
            EmailListView.Items.Clear();
            foreach (emailTBL p in lst)
            {
                EmailListView.Items.Add(new ListViewItem(p.email));
            }
        }
    }
}
