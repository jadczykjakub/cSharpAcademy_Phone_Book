using cSharpAcademy_Phone_Book.Controllers;
using cSharpAcademy_Phone_Book.Models;
using Spectre.Console;

namespace cSharpAcademy_Phone_Book
{
    internal class ContactService
    {
        internal static void SendMail()
        {
            Contact contact = GetContactFromInput();
            Console.WriteLine("Please type email subject");
            string subject = Console.ReadLine();
            Console.WriteLine("Please type email body");
            string body = Console.ReadLine();
            Mail.SendMail(contact.Email, subject, body);
        }

        internal static void AddContact()
        {
            Contact contact = GetCorrectContactDataFromInput();
            ContactController.AddContact(contact);
        }

        internal static void DeleteContact()
        {
            Contact contact = GetCorrectContactDataFromInput();
            ContactController.DeleteContact(contact);
        }

        internal static void UpdateContact()
        {
            Contact contact = GetContactFromInput();
            Contact newContact = GetCorrectContactDataFromInput();

            contact.Name = newContact.Name;
            contact.PhoneNumber = newContact.PhoneNumber;
            contact.Email = newContact.Email;

            ContactController.UpdateContact(contact);
        }

        internal static void GetContact()
        {
            Contact contact = GetCorrectContactDataFromInput();
        }

        private static Contact GetCorrectContactDataFromInput()
        {
            Console.WriteLine("Plase give Contact Name");
            string Name = Console.ReadLine();

            while (!Validator.IsStringValid(Name))
            {
                Console.WriteLine("\nInvalid Name");
                Name = Console.ReadLine();
            }

            Console.WriteLine("Plase give Phone Number");
            string PhoneNumber = Console.ReadLine();

            while (!Validator.IsNumberValid(PhoneNumber))
            {
                Console.WriteLine("\nInvalid PhoneNumber");
                PhoneNumber = Console.ReadLine();
            }

            Console.WriteLine("Please give email address");
            string Email = Console.ReadLine();

            while (!Validator.IsEmailValid(Email))
            {
                Console.WriteLine("\nInvalid email address");
                Email = Console.ReadLine();
            }

            Contact contact = new Contact
            {
                Name = Name,
                PhoneNumber = PhoneNumber,
                Email = Email
            };

            return contact;
        }

        static public Contact GetContactFromInput()
        {
            var contacts = ContactController.GetAllContacts();
            var contactsArray = contacts.Select(x => x.Name).ToArray();
            var option = AnsiConsole.Prompt(new SelectionPrompt<string>
                ()
                .Title("Choose Contact")
                .AddChoices(contactsArray));

            var id = contacts.Single(x => x.Name == option).ContactId;
            var contact = ContactController.GetContactById(id);

            return contact;
        }
    }
}
