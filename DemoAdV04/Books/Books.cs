using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdV04.Books
{
    public delegate bool Bookfunc(string A);
    public delegate bool BookfuncV2(decimal A);
    public  class Book
    {
        public Book(string isBn, string title, string[] author , DateTime publicationDate, decimal price)
        {
            IsBn = isBn;
            Title = title;
            
            Author = new string[ author.Length];
            

            PublicationDate = publicationDate;
            Price = price;
        }
        public Book()
        {
            
        }

        public string IsBn {  get; set; }
        public string Title { get; set; }
        public string?[]Author { get; set; }
        public DateTime PublicationDate {  get; set; }
        public decimal Price {  get; set; }
        public override string ToString()
        {
            return $"{IsBn} , {Title}  , {Author} , {PublicationDate} , {Price}";
        }
    }
    public class BookFunction
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetAuthor(Book B) { return B.Author[0]; }
        public static decimal GetPrice(Book B) { return B.Price ; }

    }
    public class LibraryEngine
    {
        public static void processBook(List<Book> blits)
        {
            foreach (Book item in blits)
            {
                Console.WriteLine((item));
            }
        }
    }

}
