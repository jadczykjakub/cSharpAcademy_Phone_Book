using cSharpAcademy_Phone_Book.Models;

namespace cSharpAcademy_Phone_Book.Controllers
{
    internal static class ContactController
    {
        internal static void AddContact(Contact contact)
        {
            using var db = new MyDbContext();
            db.Add(contact);
            db.SaveChanges();
        }

        internal static void DeleteContact(Contact contact)
        {
            using var db = new MyDbContext();
            db.Contacts.Remove(contact);
            db.SaveChanges();
        }

        internal static void UpdateContact(Contact contact)
        {
            using var db = new MyDbContext();
            db.Contacts.Update(contact);
            db.SaveChanges();
        }

        internal static List<Contact> GetAllContacts()
        {
            using var db = new MyDbContext();
            List<Contact> allContacts = db.Contacts.ToList();
            return allContacts;
        }

        internal static Contact GetContactById(int id)
        {
            using var db = new MyDbContext();
            Contact contact = db.Contacts.Find(id);
            return contact;
        }
    }
}
