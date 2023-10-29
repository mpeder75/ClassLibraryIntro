
using DataAccess;
using Models;

namespace BuisnessLogic
{
    public class ContactBL
    {

        ContactDA db;

        public ContactBL()
        {
            db = new ContactDA();
        }


        //! Returner alle Contacts fra CRUD 
        public List<Contact> GetAllContacts()
        {
            //Her returneres GetAllContacts()
            return db.GetAllContacts();
        }

        //! Returner en Contact fra CRUD
        public Contact GetOneContact(int id)
        {

            if (id > 0 && id < int.MaxValue)
            {
                return db.GetOneContact(id);
            }
            return new Contact();
        }


        //! Returner CRUD CreateContact
        public bool Create(Contact contact)
        {
            if (ValidateModel(contact))
            {
                return db.CreateContact(contact);
            }
            return false;
        }

        bool ValidateModel(Contact contact)
        {

            if (contact.FirstName != null && contact.LastName != null)
            {
                if (contact.FirstName.Length > 1 && contact.FirstName.Length < 51)
                {
                    if (contact.LastName.Length > 1 && contact.LastName.Length < 51)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}


  