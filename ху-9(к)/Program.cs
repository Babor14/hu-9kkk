// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
//Book kniga = new Book();
//Book kniga2 = new Book();
//Book kniga3= new Book();
//kniga.Name = Console.ReadLine();
//kniga2.Name = Console.ReadLine();
//kniga3.Name = Console.ReadLine();


Book[] books = new Book[2];
for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine("имя");
    string Name = Console.ReadLine();
    Console.WriteLine("автор");
    string Author = Console.ReadLine();
    Console.WriteLine("год");
    int Year = int.Parse(Console.ReadLine());
    Console.WriteLine("кол-во страниц");
    int pagesize = int.Parse(Console.ReadLine());
    Console.WriteLine("цена");
    int value = int.Parse(Console.ReadLine());

    books[i] = new Book(Name, Author, Year, pagesize);
}

Console.WriteLine($"Возраст книги:{ books[0].Age()}");
Console.WriteLine($"Кол-во дней, прошедших со дня издания:{ books[0].dayscount()}");



internal class Book
{
    public Book(string? name, string? author, int year, int pagesize)
    {
        Name = name;
        Author = author;
        Year = year;
        this.pagesize = pagesize;
    }
    public int dayscount()
    {
        return Age() * 365 + DateTime.Now.DayOfYear;
    }

    public string Name { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public int pagesize { get; set; }
    public int value { get; set; }
    //public int countfor { get; set; }
    public string programming { get; set; }
    public int value2 { get; set; }

     public int Age() 
    {
        return DateTime.Now.Year - this.Year;
    }
    
    public void bookprice(string Name,int value,string programming,int value2 )
    {
       
        this.Name=Name;
        this.value = value;
        this.value2= value2;
          this.programming= programming;
        programming = "программирование";
        int i=Name.IndexOf(programming);
        if (i >= 0)
        {
            value2 = value * 2;
            Console.WriteLine($"название книги{Name}") ;
            Console.WriteLine($"нынешняя цена книги:{value2}");
        }
     }
}

