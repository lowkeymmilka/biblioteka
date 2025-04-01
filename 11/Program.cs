// See https://aka.ms/new-console-template for more information
Console.WriteLine("welcome to the library");
Console.WriteLine("-----menu----");
Console.WriteLine("database");
Console.WriteLine("Viewing data about all sources");
Console.WriteLine("delete all sources");
Console.WriteLine("source record to the database");
Console.WriteLine("Search");
Console.WriteLine("Selection");
Console.WriteLine("list");


List<book> booksList = new();

while (true)
{
    Console.Write("Select menu option: ");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            foreach (var com in booksList)
            {
                Console.WriteLine("-------------- library -------------");
                Console.WriteLine($"Name: {com.Name}");
                Console.WriteLine($"price: {com.Author}m");
            }
            break;
        case 2:
            var newbook = new book();

            Console.Write("Enter book Name: ");
            newbook.Name = Console.ReadLine();
            Console.Write("Enter book author: ");
            newbook.Author = Console.ReadLine();

            booksList.Add(newbook);
            break;
    }

    Console.WriteLine("Натисніть щось для продовження...");
    Console.ReadKey();
    Console.Clear();
}

/*Створити програму для обліку книг, довідок про про наявність книг, журналів, газет. Реалізувати наступні сервіси:
 Заповнення бази даних 
 Перегляд даних про всі джерела
 Доповнення бази даних записом джерела
 Видалення джерела із бази даних
 Упорядкування по полях: тип інформаційного джерела (книга, журнал, газета) і назва
 Пошук: наявність заданої книги (відомі автор і назва), наявність заданого журналу
 Вибірка: книги автора ХХ; книги певної категорії (фантастика, детектив тощо), журнали за певний рік (відомі рік і назва журналу)
 Обчислення: кількість книг деякої категорії
 Корекція: видалення зведень про газети за певний рік
 Табличний звіт: список боржників книг певного автора*/


public class book
{
    public string Name { get; set; }
    public string Year { get; set; }
    public string Author { get; set; }
    public int Collection { get; set; }
}

public class admin
{
    public string Genre { get; set; }
    public double Amount { get; set; }
}