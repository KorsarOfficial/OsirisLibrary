using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в директорию Osiris!");
            Console.WriteLine("Пожалуйста, введите количество элементов для добавления в список: ");
            int numberOfItems = int.Parse(Console.ReadLine());

            var items = new List<int>();
            for (int i = 0; i < numberOfItems; i++)
            {
                Console.WriteLine("Пожалуйста, введите номер позиции" + (i + 1)+ ":");
                int itemNumber = int.Parse(Console.ReadLine());
                items.Add(itemNumber);
            }

            Console.WriteLine("Список предметов, которые вы ввели:");
            Console.WriteLine(" ");

            for (int i = 0; i < numberOfItems; i++)
            {
                Console.WriteLine("Номер элемента" + (i + 1) + ":" + items[i]);
                if(i + 1 < numberOfItems)
                    Console.WriteLine(" ");
            }

            Console.WriteLine("Пожалуйста, введите количество элементов, которые нужно удалить из списка:");
            int numberOfItemsToRemove = int.Parse(Console.ReadLine());

            var index = Enumerable.Range(0, numberOfItems)
                    .Where(i => items[i] >= numberOfItemsToRemove)
                    .FirstOrDefault();

            for (int i = index; i < numberOfItems; i++)
            {
                Console.WriteLine("Номер предмета: "+ (i+1)+"был удален из списка:");
            }

            Console.WriteLine("Настройка завершена, спасибо вам за пользование Osiris");
            Console.ReadKey();
        }
    }
}