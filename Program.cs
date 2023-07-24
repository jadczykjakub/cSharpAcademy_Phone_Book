using cSharpAcademy_Phone_Book;
using Spectre.Console;

bool isAppClosed = false;

while (!isAppClosed)
{
    var option = AnsiConsole.Prompt(
    new SelectionPrompt<MenuOptions>()
        .Title("What would you like to do?")
        .AddChoices(
        MenuOptions.AddContact,
        MenuOptions.DeleteContact,
        MenuOptions.UpdateContact,
        MenuOptions.ViewAllContacts,
        MenuOptions.SendMail,
        MenuOptions.Quit));

    switch (option)
    {
        case MenuOptions.AddContact:
            ContactService.AddContact();
            break;
        case MenuOptions.DeleteContact:
            ContactService.DeleteContact();
            break;
        case MenuOptions.UpdateContact:
            ContactService.UpdateContact();
            break;
        case MenuOptions.ViewAllContacts:
            UserInterface.ShowContactTable();
            break;
        case MenuOptions.SendMail:
            ContactService.SendMail();
            break;
        case MenuOptions.Quit:
            isAppClosed = true;
            Environment.Exit(0);
            break;
        default:
            break;
    }
}

enum MenuOptions
{
    AddContact,
    DeleteContact,
    UpdateContact,
    ViewAllContacts,
    SendMail,
    Quit
}