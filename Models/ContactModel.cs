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
    }
}
