using ConsoleApp1.Models;

Book[] Books = new Book[10];

for (int i = 0; i < Books.Length; i++)
{
    Console.WriteLine("Book name : ");
    string name = Console.ReadLine();

    Console.WriteLine("Number of pages  : ");
    int page = int.Parse(Console.ReadLine());

    while (!CheckName(name))
    {
        Console.WriteLine("Please, enter your name correctly.");
        name = Console.ReadLine();
    }

    while (!CheckCount(page))
    {
        Console.WriteLine("Please, enter the number of pages correctly");
        page = int.Parse(Console.ReadLine());   
    }
    

    Book book = new Book(name, page);
    Books[i] = book;
}

bool CheckName(string name)
{
    if (!string.IsNullOrWhiteSpace(name) && name.Length > 2)
    {
        return true;
    }
    return false;
}

bool CheckCount(int pageCount)
{
    if (pageCount > 10)
    {
        return true;
    }
    return false;
}

foreach (Book book in Books)
{
    Console.WriteLine($"Name : {book.Name}   pageCount : {book.PageCount}");
}
