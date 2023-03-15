using System.Net.Mail;

namespace Zeytinbey.Validation
{
    public static class Validation
    {
        public static bool IsValidEmail(string? email)
        {
            if (email == null) return false;

            try
            {
                _ = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
