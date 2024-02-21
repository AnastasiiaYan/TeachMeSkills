/*
Задание 1:
Напишите программу, используя ArrayList, чтобы хранить информацию о книгах в библиотеке. Ваша программа должна предоставлять следующие функциональности:
Добавление книги: Пользователь может вводить информацию о новой книге, включая название, автора и год издания. Эта информация должна быть добавлена в ArrayList.
Отображение списка книг: Пользователь может просматривать список всех книг в библиотеке, включая название, автора и год издания.
Поиск книги по автору: Пользователь может ввести имя автора, и программа должна отобразить список книг этого автора.
Удаление книги: Пользователь может выбрать книгу из списка и удалить ее из библиотеки.
Выход из программы: Пользователь может завершить программу.
*/
using static System.Reflection.Metadata.BlobBuilder;

namespace Collections_Task1;

internal class TaskExecution
{
    static void Main()
    {
        try
        {
            Library lib = new Library();
            Console.Write("Введите название книги: ");
            string title = Console.ReadLine();
            Console.Write("Введите автора книги: ");
            string author = Console.ReadLine();
            Console.Write("Введите год публикации книги: ");
            int publicationYear = Convert.ToInt32(Console.ReadLine());

            lib.AddBook(title, author, publicationYear);
            lib.ShowBooks();
            lib.FindByAuthor(author);
            lib.RemoveBook(title);
            lib.ShowBooks();
            lib.Exit();
        }

        catch (Exception ex)
        {
            Console.WriteLine($"\nОшибка: {ex.Message}");
        }
    }
}