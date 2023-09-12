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
        public static List<phoneTBL> allPhones;
        public static List<emailTBL> allEmails;
        #endregion
        #region load func
        public static void init()
        {
            getAllContacts();
            getAllPhones();
            getAllEmails();
        }
       
        #endregion 
        #region get func
        public static contactTBL getContactByName(string fn, string ln)
        {
            contactTBL result = allContacts.Where(x => x.firstName == fn
                                                    && x.lastName == ln)
                                                    .FirstOrDefault();
            return result;
        }
        public static List<contactTBL> getAllContacts()
        {
            allContacts = (from s in db.contactTBL orderby s.firstName select s).ToList();
            return allContacts;
        }
        public static List<emailTBL> getAllEmails()
        {
            allEmails = (from s in db.emailTBL select s).ToList();
            return allEmails;
        }
        public static List<emailTBL> getEmailListByCID(int cID)
        {
            return allEmails.Where(x => x.cID == cID).ToList();
        }
        public static List<phoneTBL> getAllPhones()
        {
            allPhones = (from s in db.phoneTBL select s).ToList();
            return allPhones;
        }
        public static List<phoneTBL> getPhoneListByCID(int cID)
        {
            return allPhones.Where(x => x.cID == cID).ToList();
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
       
        public static phoneTBL addPhone(phoneTBL p1)
        {
            try
            {
                db.phoneTBL.Add(p1);
                db.SaveChanges();
                getAllPhones();
                return p1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error add phone " + ex.Message.ToString());
                return null;
            }
        }
        public static emailTBL addEmail(emailTBL e1) 
        {
            try
            {
                db.emailTBL.Add(e1);
                db.SaveChanges();
                getAllEmails();
                return e1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error add email " + ex.Message.ToString());
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
       
        public static bool updatePhone(phoneTBL p1)
        {
            phoneTBL toUpdate = (from s in db.phoneTBL where s.Id == p1.Id select s).FirstOrDefault();
            if (toUpdate != null)
            {
                toUpdate.cID = p1.cID;
                toUpdate.phone = p1.phone;
                db.SaveChanges();
                getAllPhones();
                return true;
            }
            return false;
        }
       
        public static bool updateEmail(emailTBL e1)
        {
            emailTBL toUpdate = (from s in db.emailTBL where s.Id == e1.Id select s).FirstOrDefault();
            if (toUpdate != null)
            {
                toUpdate.cID = e1.cID;
                toUpdate.email = e1.email;
                db.SaveChanges();
                getAllEmails();
                return true;
            }
            return false;
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
        
        public static bool deletePhone(phoneTBL p1)
        {
            try
            {
                phoneTBL toDelete = (from s in db.phoneTBL where s.Id == p1.Id select s).FirstOrDefault();
                if (toDelete == null)
                    return false;
                db.phoneTBL.Remove(toDelete);
                db.SaveChanges();
                getAllPhones();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error delete: " + ex.Message.ToString());
                return false;
            }
        }
        public static bool deleteEmail(emailTBL e1)
        {
            try
            {
                emailTBL toDelete = (from s in db.emailTBL where s.Id == e1.Id select s).FirstOrDefault();
                if (toDelete == null)
                    return false;
                db.emailTBL.Remove(toDelete);
                db.SaveChanges();
                getAllEmails();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error delete email: " + ex.Message.ToString());
                return false;
            }
        }
        #endregion

       
    }
}
