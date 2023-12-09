/*Задание 1
        Напишите программу - консольный калькулятор.

        UseCase:
        1.Пользователь запускает программу
        2. 	В терминале предлагается ввести число номер 1 – пользователь вводит число номер 1
        3. 	В терминале предлагается ввести допустимую операцию (+, -, *, /) – пользователь вводит операцию
        4. 	В терминале предлагается ввести число номер 2 – пользователь вводит число номер 2
        5. 	В терминал выводится результат выбранной операции

        Примечание:
        ·  	Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch.
        ·  	В случае использования операции деления, организуйте проверку попытки деления на ноль с выводом соответствующего сообщения
*/

namespace TypesAndOperators
{
    class HomeWork_1
    {
        static void Main()
        {
            Calculator();
        }

        
        public static void Calculator()
        {
            Console.WriteLine("Данная программа является калькулятором.\n" +
           "Вы сможете совершить операцию сложения, вычетания, умножения или деления с двумя числами.");
            Console.WriteLine("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите операцию из списка: +, -, *, / ");
            string operand = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());
            switch (operand)
            {
                case "+":
                    {
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;
                    }
                case "-":
                    {
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    }
                case "*":
                    {
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    }
                case "/":
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("Упс, на ноль делить нельзя.");
                            break;
                        }
                        Console.WriteLine($"{a} / {b} = {a / b}");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Неизвестный математический оператор. Убедитесь, что ввели вариант из списка: +, -, *, / ");
                        break;
                    }
            }
        }

    }
}
 