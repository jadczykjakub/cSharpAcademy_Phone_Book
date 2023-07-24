using System.Net.Mail;

namespace cSharpAcademy_Phone_Book
{
    internal class Validator
    {
        internal static bool IsStringValid(string stringInput)
        {
            if (String.IsNullOrEmpty(stringInput))
            {
                return false;
            }

            foreach (char c in stringInput)
            {
                if (!Char.IsLetter(c) && c != '/' && c != ' ')
                    return false;
            }

            return true;
        }

        public static bool IsNumberValid(string stringInput)
        {

            if (String.IsNullOrEmpty(stringInput))
            {
                return false;
            }

            foreach (char c in stringInput)
            {
                if (!Char.IsDigit(c))
                    return false;
            }

            return true;
        }

        public static bool IsEmailValid(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
