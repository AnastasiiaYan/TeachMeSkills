/* Задание 3
Напишите программу русско-английский переводчик.
Программа знает 10 слов о погоде.
Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова на английском языке.
Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, что такого слова нет.
*/
namespace TypesAndOperators
{
    class HomeWork_3
    {
        static void Main()
        {
            Translation();
        }
        private static void Translation()
        {
            Console.WriteLine("Данная программа представляет собой небольшой переводчик с русского на английский.\n" +
           "Пожалуйста, введите русское слово с заглавной буквы на тему \"Погода\", которое требуется перевести");
            String input = Console.ReadLine();

            switch (input)
            {
                case "Погода":
                    {
                        Console.WriteLine($"{input} на английском будет \"Weather\"");
                        break;
                    }
                case "Пасмурно":
                    {
                        Console.WriteLine($"{input} на английском будет \"Сloudy\"");
                        break;
                    }
                case "Солнечно":
                    {
                        Console.WriteLine($"{input} на английском будет \"Sunny\"");
                        break;
                    }
                case "Снежно":
                    {
                        Console.WriteLine($"{input} на английском будет \"Snowy\"");
                        break;
                    }
                case "Дождливо":
                    {
                        Console.WriteLine($"{input} на английском будет \"Rainy\"");
                        break;
                    }
                case "Ветрено":
                    {
                        Console.WriteLine($"{input} на английском будет \"Windy\"");
                        break;
                    }
                case "Прохладно":
                    {
                        Console.WriteLine($"{input} на английском будет \"Chilly\"");
                        break;
                    }
                case "Тепло":
                    {
                        Console.WriteLine($"{input} на английском будет \"Warm\"");
                        break;
                    }
                case "Ясно":
                    {
                        Console.WriteLine($"{input} на английском будет \"Clear\"");
                        break;
                    }
                case "Жарко":
                    {
                        Console.WriteLine($"{input} на английском будет \"Hot\"");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("К сожалению, в данном словаре пока нет такого слова :( \nПопробуйте перевести что-то другое. ");
                        break;
                    }
            }
        }
    }
}          