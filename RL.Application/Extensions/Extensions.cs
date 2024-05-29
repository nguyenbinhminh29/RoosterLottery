using RL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

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

        public static T DeserializeObject<T>(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return default(T);

            JsonSerializerOptions options = new()
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };

            return JsonSerializer.Deserialize<T>(value, options);
        }

        public static string ToJson<T>(this T data)
        {
            JsonSerializerOptions options = new()
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true
            };
            return JsonSerializer.Serialize(data, options);
        }
    }
}
