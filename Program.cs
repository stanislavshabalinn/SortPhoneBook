using System;
using System.Linq;
using System.Collections.Generic;

namespace SortPhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            // Сортировка c помощью LINK.
            var sortphoneBook = from s in phoneBook orderby s.Name, s.LastName select s;

            foreach (var s in sortphoneBook)
                Console.WriteLine(s.Name + ", " + s.LastName);

            Console.WriteLine();

            // Сортировка c помощью методов расширения.
            var sortphoneBookExt = phoneBook
                                   .OrderBy(s => s.Name)
                                   .ThenBy(s => s.LastName);

            foreach (var s in sortphoneBookExt)
                Console.WriteLine(s.Name + ", " + s.LastName);

        }
    }
}
