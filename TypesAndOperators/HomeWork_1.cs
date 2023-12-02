
namespace HomeWork_1
{
    class HomeWork_1
    {
        static void Main()
        {
            Calculator();
            //PredictNumber();
            //Translator();
            //EvenNumber();
        }

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

        /* Задание 2
        Напишите программу определения, попадает ли введенное пользователем число (от -50 до 50) в один из числовых промежутков [-40, -10][-9, 0][1, 10][11, 40].
        Если да, то укажите, в какой именно промежуток.
        Если пользователь указывает число, не входящее ни в один из имеющихся числовых промежутков, то выводится соответствующее сообщение.
        */
        private static void PredictNumber()
        {
            Console.Write($"Enter your number from 0 to 100: ");
            int number = Int32.Parse(Console.ReadLine());
            if (number >= 0 && number <= 14)
            {
                Console.WriteLine($"Your number {number} exists in [0-14]");
            }
            else if (number >= 15 && number <= 35)
            {
                Console.WriteLine($"Your number {number} exists in [15-35]");
            }
            else if (number >= 36 && number <= 50)
            {
                Console.WriteLine($"Your number {number} exists in [36-50]");
            }
            else if (number >= 51 && number <= 100)
            {
                Console.WriteLine($"Your number {number} exists in [51-100]");
            }
            else
            {
                Console.WriteLine($"Your number {number} does not exists in any of periods");
            }
        }
    }
}
        

/* Задание 3
Напишите программу русско-английский переводчик.
Программа знает 10 слов о погоде.
Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке.
Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.
*/

          