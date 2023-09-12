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
            foreach (contactTBL c in allContactsList)
            {
                ContactModel cModel = new ContactModel(c);
                modelList.Add(cModel);
            }
        }
    }
}
