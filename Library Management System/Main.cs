using Library_Management_System;

/* 
 * This application does not include validation to keep it as simple as possible to understand.
 * The goal of this program is to make use of generic lists in C#.
 * We will create an application where we can Add, Remove, and Display books contained in the generic list.
 * https://www.tutorialspoint.com/What-is-a-generic-List-in-Chash
*/

// This is a generic List in C#, where Book is the type of objects it will store
// List already contains methods such as Add, Remove, RemoveAt, and so on. Therefore, we will use it in our application.
List<Book> books = new List<Book>(); 

// Initial Books
// books.Add() expects the object to be passed, which is why we pass "new Book()" and not just the book information.
books.Add(new Book("War Of The Worlds", "H.G. Wells's iconic novel about a Martian invasion of Earth", "H.G. Wells", 12.99M, 75));
books.Add(new Book("Dune", "A science fiction novel by Frank Herbert, about the young Paul Atreides, as he and his family accept control over the desert planet Arrakis", "Frank Herbert", 18.00M, 65));
books.Add(new Book("Snow Crash", "A novel by Neal Stephenson that offers a futuristic vision of a world in the grip of a computer virus", "Neal Stephenson", 14.50M, 70));

bool stopLoop = false;
while (!stopLoop)
{

    Console.WriteLine($"\n1. Display Books\n2. Add Book\n3. Remove Book\n4. Exit\n\nPlease Enter Your Choice: "); // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            DisplayBooks();
            break;
        case 2:
            AddBook();
            break;
        case 3:
            RemoveBook();
            break;
        case 4:
            return;
        default:
            Console.WriteLine("\nInvalid choice, please enter a number between 1 and 4.");
            break;
    }

    // Methods

    void DisplayBooks()
    {
        Console.WriteLine("\n=============================================\n");
        foreach (Book book in books)
        {
            Console.WriteLine(books.IndexOf(book).ToString() + ". " + book + "\n"); // First print the Index of the book and then the book object (book.ToString())
        }
        Console.WriteLine("\n=============================================\n");
    }

    void AddBook()
    {
        Console.WriteLine("\nEnter the book name: ");
        string name = Console.ReadLine();
        Console.WriteLine("\nEnter the book description: ");
        string description = Console.ReadLine();
        Console.WriteLine("\nEnter the book author: ");
        string author = Console.ReadLine();
        Console.WriteLine("\nEnter the book price: ");
        decimal price = decimal.Parse(Console.ReadLine());
        Console.WriteLine("\nEnter the book's quantity on hand: ");
        int qtyOnHand = int.Parse(Console.ReadLine());

        books.Add(new Book(name, description, author, price, qtyOnHand));
    }

    void RemoveBook()
    {
        DisplayBooks();
        Console.WriteLine("\nEnter the index of the book you want to delete: ");
        int index = int.Parse(Console.ReadLine());
        books.RemoveAt(index); // Index starts from 0
    }
}