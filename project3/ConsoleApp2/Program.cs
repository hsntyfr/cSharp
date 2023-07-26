using System;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();
        
        while (text == "" || text == null)
        {
            Console.WriteLine("Invalid text");
            Console.Write("Enter a string: ");
            text = Console.ReadLine();
        }
        
        bool newOperation = false;
        while(newOperation != true)
        {
            Console.WriteLine("Choose an operation: ");
            Console.WriteLine("1 --> İşlem 1");
            Console.WriteLine("2 --> İşlem 2");
            Console.WriteLine("3 --> İşlem 3");
            Console.WriteLine("4 --> Exit");
            int choice = int.Parse(Console.ReadLine());
            string searchText = "";
            
            switch (choice)
            {
                case 1:
                    searchText = TakeSearchText();
                    Console.WriteLine("-------------------------------");

                    int index = -1;
                    bool findStatus = false;
                    while ((index = text.IndexOf(searchText, index + 1)) != -1)
                    {
                        Console.WriteLine($"'{searchText}' in {index}. indeks");
                        findStatus = true;
                    }

                    if (findStatus != true)
                    {
                        Console.WriteLine($"'{searchText}' not found");
                    } 
                    break;

                case 2:
                    searchText = TakeSearchText();
                    break;

                case 3:
                    break;

                case 4:
                    newOperation = true; 
                    break;
                
                default:
                Console.WriteLine("Invalid operation");
                break;
            }
        }
    }

    static string TakeSearchText()
    {
        Console.Write("Enter a string that you want to search: ");
        string searchText = Console.ReadLine();
        while (searchText == "" || searchText == null)
        {
            Console.WriteLine("Invalid text");
            Console.Write("Enter a string that you want to search: ");
            searchText = Console.ReadLine();
        }

        return searchText;
    }

    


}