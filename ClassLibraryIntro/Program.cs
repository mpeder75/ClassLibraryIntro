

using BuisnessLogic;
using Models;


//! instans af ContactBl oprettes 
ContactBL bl = new ContactBL();


//! GetAllContacts() henter alle contacts
//List<Contact> contacts = bl.GetAllContacts();


Contact one;

//! Contact abe oprettes
Contact paul = new Contact
{
    Id = 10,
    FirstName = "Paul",
    LastName = "McCartney",
    Address = "unknown",
    City = "London",
    BirthDate = new DateTime(1960, 11, 11),
    Email = "lastBeatle@gmail.com",
    PhoneNumber = 12345678,
    PostalCode = 123
};

Console.WriteLine(paul);

//bool creatSuccess = bl.Create(paul);

