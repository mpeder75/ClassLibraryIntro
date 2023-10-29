
using Models;

namespace DataAccess
{
    public class ContactDA
    {
        List<Contact> contacts;

        public ContactDA()
        {
            contacts = new List<Contact>();
            AddData();
        }


        //todo CRUD - GetAllContacts
        public List<Contact> GetAllContacts()
        {
            return contacts;
        }

        //todo CRUD - GetOneContact
        public Contact GetOneContact(int id)
        {
            foreach (var contact in contacts)
            {
                if (contact.Id == id)
                {
                    return contact;
                }
            }
            return new Contact();
        }

        //todo CRUD - Create contact
        public bool CreateContact(Contact contact)
        {
            contact.Id = FindNextId();
            contacts.Add(contact);
            return true;
        }


        // Find netId Method
        int FindNextId()
        {
            int nextId = 0;
            foreach (var item in contacts)
            {
                if (item.Id > nextId)
                {
                    nextId = item.Id;
                }
            }
            return nextId + 1;
        }

        //todo CRUD - Update a Contact
        public bool UpdateContact(Contact contact)
        {
            foreach (var con in contacts)
            {
                if (con.Id == contact.Id)
                {
                    con.FirstName = contact.FirstName;
                    con.LastName = contact.LastName;
                    return true;
                }
            }
            return false;
        }


        //todo CRUD - Delete contact
        public bool DeleteContact(int id)
        {
            bool isDeleted = false;
            Contact temp = new Contact();
            foreach (var contact in contacts)
            {
                if (contact.Id == id)
                {
                    temp = contact;
                }
            }
            return contacts.Remove(temp);
        }


        void AddData()
        {
            contacts.Add(new Contact
            {
                Id = 1,
                FirstName = "Homer",
                LastName = "Simpson",
                Address = "741 Terrance Avenue",
                PostalCode = 8771,
                City = "Springfield",
                PhoneNumber = 12345687,
                Email = "duuh@gfmail.com"
            });

            contacts.Add(new Contact
            {
                Id = 2,
                FirstName = "Marge",
                LastName = "Simpson",
                Address = "741 Terrance Avenue",
                PostalCode = 8771,
                City = "Springfield",
                PhoneNumber = 123456778,
                Email = "hotMomma@hotmail.com"
            });

            contacts.Add(new Contact
            {
                Id = 3,
                FirstName = "Maggie",
                LastName = "Simpson",
                Address = "741 Terrance Avenue",
                PostalCode = 8771,
                City = "Springfield",
                PhoneNumber = 123456778,
                Email = "baby@hotmail.com"
            });

            contacts.Add(new Contact
            {
                Id = 4,
                FirstName = "Bart",
                LastName = "Simpson",
                Address = "741 Terrance Avenue",
                PostalCode = 8771,
                City = "Springfield",
                PhoneNumber = 123456778,
                Email = "dude@hotmail.com"
            });

            contacts.Add(new Contact
            {
                Id = 5,
                FirstName = "Lisa",
                LastName = "Simpson",
                Address = "741 Terrance Avenue",
                PostalCode = 8771,
                City = "Springfield",
                PhoneNumber = 123456778,
                Email = "nerd@hotmail.com"
            });
        }
    }
}

