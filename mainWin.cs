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
        Form current = null;
        public mainWin()
        {
            InitializeComponent();
        }

        private void mainWin_Load(object sender, EventArgs e)
        {
            DBHelper.init();
        }
        private void btnOpenContactWin_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is contactWin)
                {
                    (current as contactWin).moveToPage(0);
                    return;
                }
                current.Close();
            }
            current = new contactWin()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            mainPanel.Controls.Add(current);
            (current as contactWin).moveToPage(0);
            current.Show();

        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is contactWin)
                {
                    (current as contactWin).moveToPage(1);
                    return;
                }
                current.Close();
            }
            current = new contactWin()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            mainPanel.Controls.Add(current);
            (current as contactWin).moveToPage(1);
            current.Show();

        }

        private void btnListOfContacts_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is contactWin)
                {
                    (current as contactWin).moveToPage(2);
                    return;
                }
                current.Close();
            }
            current = new contactWin()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            mainPanel.Controls.Add(current);
            (current as contactWin).moveToPage(2);
            current.Show();

        }

        private void btnPhoneWin_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is phoneWin)
                {
                    
                    return;
                }
                current.Close();
            }
            current = new phoneWin()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            mainPanel.Controls.Add(current);
          
            current.Show();
        }

        private void btnOpenEmailWin_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is emailWin)
                {

                    return;
                }
                current.Close();
            }
            current = new emailWin()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            mainPanel.Controls.Add(current);

            current.Show();
        }

        private void btnOpenReportWin_Click(object sender, EventArgs e)
        {
            if (current != null)
            {
                if (current is reportWin)
                {

                    return;
                }
                current.Close();
            }
            current = new reportWin()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            mainPanel.Controls.Add(current);

            current.Show();
        }
    }
}
