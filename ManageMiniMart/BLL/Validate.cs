using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManageMiniMart.BLL
{
    internal class Validate
    {
        public static bool ValidateEmail(string email)
        {
            // Define a regular expression pattern for email validation
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);

            // Use the Match method to check if the email matches the pattern
            Match match = regex.Match(email);

            // Return true if the email matches the pattern, false otherwise
            return match.Success;
        }
        public static bool ValidateVietnameseName(string name)
        {
            // Định nghĩa mẫu biểu thức chính quy cho việc kiểm tra tên tiếng Việt
            string pattern = @"^[\p{L} ]+$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(name);
            return match.Success;
        }
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            // Define a regular expression pattern for phone number validation
            string pattern = @"^(?:\+?)(?:[0-9] ?){6,14}[0-9]$";
            // Create a Regex object with the pattern
            Regex regex = new Regex(pattern);
            Match match = regex.Match(phoneNumber);
            return match.Success;
        }
    }
}
