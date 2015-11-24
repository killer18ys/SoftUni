using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class BookShopMain
    {
        static void Main(string[] args)
        {
            Book book = new Book("Pod Igoto", "Ivan Vazov", 15.90);
            Book goldenEditionBook = new GoldenEditionBook("Tutun", "Dimitar Dimov", 22.90);

            Console.WriteLine(book);
            Console.WriteLine();
            Console.WriteLine(goldenEditionBook);
        }
    }
}
