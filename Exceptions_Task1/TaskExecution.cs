/*
Создать класс, в котором будет статический метод. Этот метод принимает на вход три параметра:
login,
password,
confirmPassword.

Все поля имеют тип данных String.
Длина login должна быть меньше 20 символов и не должен содержать пробелы.
Если login не соответствует этим требованиям, необходимо выбросить WrongLoginException.
Длина password должна быть меньше 20 символов, не должен содержать пробелом и должен содержать хотя бы одну цифру.
Также password и confirmPassword должны быть равны.
Если password не соответствует этим требованиям, необходимо выбросить WrongPasswordException.
WrongPasswordException и WrongLoginException - пользовательские классы исключения с двумя конструкторами – один по умолчанию, второй принимает сообщение исключения и передает его в конструктор класса Exception.
Метод возвращает true, если все значения верны или false в другом случае.

*/
using System.Drawing;
using System.Net;
using System.Text;

namespace Exception_Task1;

internal class TaskExecution
{
    static void Main()
    {
        Authorization authorization = new Authorization();
        Console.Write("Введите логин: ");
        string login = Console.ReadLine();
        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();
        Console.Write("Введите пароль повторно: ");
        string confirmPassword = Console.ReadLine();

        try
        {
            Console.WriteLine(Authorization.isCorrectInput(login, password, confirmPassword) ? "Регистрация прошла успешно!");
        }

        catch (WrongLoginException excLogin)
        {
            Console.WriteLine($"\nОшибка при вводе логина: {excLogin.Message}");
        }

        catch (WrongPasswordException excPasswotd)
        {
            Console.WriteLine($"\nОшибка при вводе пароля: {excPasswotd.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"\nОшибка: {e.Message}");
        }
    }
}