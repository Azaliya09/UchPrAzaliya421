using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UchAzaliya.Components
{
    public class PasswordValidator
    {
        public static bool IsValidPassword(string password)
        {
            // Проверка длины
            if (password.Length <= 4 || password.Length >= 16)
            {
                return false;
            }

            // Проверка на наличие запрещенных символов
            char[] forbiddenChars = { '*', '&', '{', '}', '|', '+' };
            if (password.Any(c => forbiddenChars.Contains(c)))
            {
                return false;
            }

            // Проверка на наличие заглавных букв
            if (!password.Any(char.IsUpper))
            {
                return false;
            }

            // Проверка на наличие цифр
            if (!password.Any(char.IsDigit))
            {
                return false;
            }

            return true;
        }
    }
}
