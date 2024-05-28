using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RL.Application.Extensions
{
    public static class Extensions
    {
        public static bool IsValidPhoneNumber(this string This)
        {
            var phoneNumber = This.Trim()
                .Replace(" ", "")
                .Replace("-", "")
                .Replace("(", "")
                .Replace(")", "");
            return Regex.Match(phoneNumber, @"^(\+[0-9]{9})$").Success;
        }
    }
}
