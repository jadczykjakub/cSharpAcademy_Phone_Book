using cSharpAcademy_Phone_Book.Controllers;
using cSharpAcademy_Phone_Book.Models;
using Spectre.Console;

namespace cSharpAcademy_Phone_Book
{
    internal class UserInterface
    {
        static internal void ShowContactTable()
        {
            List<Contact> contacts = ContactController.GetAllContacts();

            var table = new Table();
            table.AddColumn("Id");
            table.AddColumn("Name");
            table.AddColumn("Phone Number");
            table.AddColumn("Email");

            foreach (Contact contact in contacts)
            {
                table.AddRow(
                    contact.ContactId.ToString(),
                    contact.Name,
                    contact.PhoneNumber,
                    contact.Email);
            }
            AnsiConsole.Write(table);
        }
    }
}
