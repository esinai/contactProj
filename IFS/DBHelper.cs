using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contactProj.IFS
{
    public class DBHelper
    {
        private static dbEntities db = new dbEntities();

        #region Definitions
        public static List<contactTBL> allContacts;
        #endregion

        public static void init()
        {
            getAllContacts();
        }
        #region load func
        public static List<contactTBL> getAllContacts()
        {
            allContacts = (from s in db.contactTBL orderby s.firstName select s).ToList();
            return allContacts;
        }
        #endregion
        #region add func
        public static contactTBL addContact(contactTBL c1)
        {
            try
            {
                db.contactTBL.Add(c1);
                db.SaveChanges();
                getAllContacts();
                return c1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error add contcat " + ex.Message.ToString());
                return null;
            }
        }
        #endregion
        #region update func
        public static bool updateContact(contactTBL c1)
        {
            contactTBL toUpdate = (from s in db.contactTBL where s.Id == c1.Id select s).FirstOrDefault();
            if (toUpdate != null)
            {
                toUpdate.firstName = c1.firstName;
                toUpdate.lastName = c1.lastName;
                db.SaveChanges();
                getAllContacts();
                return true;
            }
            return false;
        }
        public static void jadekFunc()
        {

        }

        public static contactTBL getContactByName(string fn, string ln)
        {
            contactTBL result = allContacts.Where(x => x.firstName == fn 
                                                    && x.lastName == ln)
                                                    .FirstOrDefault();
            return result;
        }
        #endregion


        #region delete func
        public static bool deleteContact(contactTBL c1)
        {
            try
            {
                contactTBL toDelete = (from s in db.contactTBL where s.Id == c1.Id select s).FirstOrDefault();
                if (toDelete == null)
                    return false;
                db.contactTBL.Remove(toDelete);
                db.SaveChanges();
                getAllContacts();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error delete: " + ex.Message.ToString());
                return false;
            }
        }
        #endregion
    }
}
