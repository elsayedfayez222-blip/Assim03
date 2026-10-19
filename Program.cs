using System;

namespace Assim03
{
    internal class Program
    {
        // Method for Q10 outside Main
        static void PrintFirstBook(string[] books)
        {
            if (books.Length == 0)
            {
                return; // exit early if empty
            }
            Console.WriteLine(books[0]);
        }

        static void Main(string[] args)
        {
            #region Q1
            // Given int pages 464 and bool isAvailable true print You can borrow this book only if pages is greater than 300 and isAvailable is true Use the and operator
            int pages = 464;
            bool isAvailable = true;
            if (pages > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion

            #region Q2
            // Given string title Refactoring write a switch statement that prints Great choice if the title is Clean Code Nice pick if its Refactoring and Never heard of it for anything else
            string title = "Refactoring";
            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion

            #region Q3
            // Given int pages 464 use the ternary operator to store Long Book or Short Book into a variable sizeLabel long if pages greater than 300
            int bookPages = 464;
            string sizeLabel = bookPages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);
            #endregion

            #region Q4
            // Given string array books Clean Code The Pragmatic Programmer Refactoring use a for loop to print each book with its position number
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + books[i]);
            }
            #endregion

            #region Q5
            // Using the same books array use a while loop to print every book title
            int index = 0;
            while (index < books.Length)
            {
                Console.WriteLine(books[index]);
                index++;
            }
            #endregion

            #region Q6
            // Write a do while loop that prints Checking book exactly 3 times
            int count = 0;
            do
            {
                Console.WriteLine("Checking book...");
                count++;
            } while (count < 3);
            #endregion

            #region Q7
            // Using the same books array use a foreach loop to print every book title
            foreach (string bookTitle in books)
            {
                Console.WriteLine(bookTitle);
            }
            #endregion

            #region Q8
            // Using the same books array loop through it and print each title but stop completely break once you reach Refactoring
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == "Refactoring")
                {
                    break;
                }
                Console.WriteLine(books[i]);
            }
            #endregion

            #region Q9
            // Using the same books array print every title except The Pragmatic Programmer skip it with continue dont stop the loop
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(books[i]);
            }
            #endregion

            #region Q10
            // Write a method PrintFirstBook that prints the first book in the books array If the array is empty use return to exit the method early instead of printing anything
            PrintFirstBook(books);
            #endregion
        }
    }
}