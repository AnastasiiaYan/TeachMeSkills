using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Task1
{
    internal class Authorization
    {       
        public static bool isCorrectInput(string login, string password, string confirmPassword)
        {
            if (login.Length > 20 || login.Contains(" "))
            {
                throw new WrongLoginException("Длина должна быть меньше 20 символов и не должен содержать пробелы!");
            }
            else if (password.Length > 20 || password.Contains(" ") || password.All(p => !char.IsDigit(p))) //Лямбда, если все символы не являются цифрами, метод All() возвращает trueЕсли все символы не являются цифрами, метод All() возвращает true
            {
                throw new WrongPasswordException("Длина должна быть меньше 20 символов, не должен содержать пробелов и должен содержать хотя бы одну цифру!");
            }
            else if (confirmPassword != password)
            {
                throw new WrongPasswordException("Пароли не совпадают!");
            }
            else
                return true;
        }
    }
}
