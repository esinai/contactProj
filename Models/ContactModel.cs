using contactProj.IFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contactProj.Models
{
    public class ContactModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime creationDate { get; set; }
        public string fullName { get; set; }
        public List<emailTBL> emailList { get; set; }
        public List<phoneTBL> phoneList { get; set; }
        public ContactModel(contactTBL c1)
        {
            this.firstName = c1.firstName;
            this.lastName = c1.lastName;
            this.creationDate = c1.creationDate;
            this.fullName = c1.fullName;
            this.emailList = DBHelper.getEmailListByCID(c1.Id);
            this.phoneList = DBHelper.getPhoneListByCID(c1.Id);
        }
    }
}
