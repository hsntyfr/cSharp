using System;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        Console.WriteLine("This program accepts only english letters");
        Console.WriteLine("-------------------------------");
        
        Console.Write("Enter a string: ");
        string text = Console.ReadLine();

        //This while loop checks if the text is empty or null
        while (text == "" || text == null)
        {
            Console.WriteLine("Invalid text");
            Console.Write("Enter a string: ");
            text = Console.ReadLine();
        }
        
        bool newOperation = false;
        bool findStatus = false;
        
        //This while loop checks if the user wants to continue
        while(newOperation != true)
        {
            Console.WriteLine("Choose an operation: ");
            Console.WriteLine("1 --> Search words in text");
            Console.WriteLine("2 --> Search words in text with substring");
            Console.WriteLine("3 --> Draw letter count graphic");
            Console.WriteLine("4 --> Exit");
            int choice = int.Parse(Console.ReadLine());
            string searchText = "";
            
            switch (choice)
            {
                case 1:
                    searchText = TakeSearchText();
                    WriteInfo(text, searchText);
                    Console.WriteLine("-------------------------------");

                    int index = -1;
                    
                    //This while loop finds the index of the search text in the text
                    while ((index = text.IndexOf(searchText, index + 1)) != -1)
                    {
                        Console.WriteLine($"'{searchText}' in {index}. index");
                        findStatus = true;
                    }

                    //This if statement checks if the search text is not found
                    if (findStatus != true)
                    {
                        Console.WriteLine($"'{searchText}' not found");
                    } 
                    
                    Console.WriteLine();

                    break;

                case 2:
                    searchText = TakeSearchText();
                    WriteInfo(text, searchText);
                    Console.WriteLine("-------------------------------");
                    
                    int searchTextLength = searchText.Length;
                    
                    //This for loop finds the index of the search text in the text
                    for (int i = 0; i < text.Length - searchTextLength + 1; i++)
                    {
                        if (text.Substring(i,searchTextLength ) == searchText)
                        {
                            Console.WriteLine($"'{searchText}' in {i}. index");
                            findStatus = true;

                        }
                    }

                    //This if statement checks if the search text is not found
                    if (findStatus != true)
                    {
                        Console.WriteLine($"'{searchText}' not found");

                    }
                    
                    Console.WriteLine();
                    
                    break;

                case 3:
                    WriteInfo(text, searchText);
                    
                    Console.WriteLine();
                    Console.WriteLine("Letter Count Graphic");
                    Console.WriteLine("-------------------------------");
                    
                    Dictionary<char, int> letterCount = new Dictionary<char, int>();

                    //This for loop adds the letters to the dictionary
                    for (char letter = 'a'; letter <= 'z'; letter++)
                    {
                        letterCount[letter] = 0;
                    }
                    
                    //This foreach loop counts the letters in the text
                    foreach (char letter in text.ToLower())
                    {
                        if (char.IsLetter(letter))
                        {
                            letterCount[letter]++;
                        }
                    }
                    
                    //This foreach loop prints the letters and their count
                    foreach (KeyValuePair<char, int> letterSelected in letterCount)
                    {
                        char letter = letterSelected.Key;
                        int count = letterSelected.Value;
                        char asterisks = '*';
                        Console.WriteLine($"{letter} letter: {count} --> {new string(asterisks, count)}");
                    }
                    Console.WriteLine();
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
        
        //This while loop checks if the search text is empty or null
        while (searchText == "" || searchText == null)
        {
            Console.WriteLine("Invalid text");
            Console.Write("Enter a string that you want to search: ");
            searchText = Console.ReadLine();
        }

        return searchText;
    }
    static void WriteInfo(string text, string searchText)
    {
        Console.WriteLine($"Text is : {text}");
        Console.WriteLine($"Search text is : {searchText}");
    }
}