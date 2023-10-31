using System;


namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UniqueElements uniqueElements = new UniqueElements();

            while (true)
            {
                Console.WriteLine("Введите элемент (или 'exit' для выхода): ");
                string input = Console.ReadLine();
                input = input.ToLower();
    
                if (input.ToLower() == "exit")
                {
                    break;
                }
                uniqueElements.AddInput(input);
               
            }

            Console.WriteLine(uniqueElements);

            Console.WriteLine("-----------------------");

            Console.WriteLine("\nВведите элемент для удаления ");
            string searchElement = Console.ReadLine();
            searchElement = searchElement.ToLower();

            if (uniqueElements.RemoveElement(searchElement))
            {
                Console.WriteLine($"\"{searchElement}\" удален из коллекции.\n");
            }
            else
            {
                Console.WriteLine($"\"{searchElement}\" не найден для удаления.\n");
            }

            Console.WriteLine(uniqueElements);























            Console.ReadLine();

        }
    }
}