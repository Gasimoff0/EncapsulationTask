namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book book1 = new Book("Sefiller",30,3, "Drama / Tragedy");
            // Console.WriteLine(book1.Detail());
            // Console.WriteLine($"Endirimden sonraki qiymet: {book1.Discount(10)}");
            Console.WriteLine("Daxil edeceyiniz kitablarin sayini qeyd edin: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Book[] books = new Book[count];
            
            for (int i= 0; i < count; i++)
            {
                Console.WriteLine();
                Console.WriteLine((i+1) + "ci kitabin melumatlarini daxil edin");
                Console.WriteLine("Ad: ");
                string name = Console.ReadLine();

                Console.WriteLine("Qiymet: ");
                int price = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Sayi ");
                int bookcount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Janr: ");
                string genre = Console.ReadLine();
                books[i] = new Book(name, price, bookcount , genre);
            }
            Console.WriteLine("Daxil edilmish kitablar: ");
            //foreach (var book in books)
            //{
            //    Console.WriteLine(book.Detail());
            //}
            Console.WriteLine("Menyu:");
            Console.WriteLine("1. Kitablari price a gore filtrle");
            Console.WriteLine("2. Butun kitablari goster");
            Console.WriteLine("0. Programi bagla");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    for (int i = 0; i < books.Length - 1; i++)
                    {
                        for (int j = 0; j < books.Length - 1 - i; j++)
                        {
                            if (books[j].Price > books[j + 1].Price)
                            {
                                Book temp = books[j];
                                books[j] = books[j + 1];
                                books[j + 1] = temp;
                            }
                        }
                    }
                    Console.WriteLine("Price göre artan sira ile siralanmish kitablar:");
                    for (int i = 0; i < books.Length; i++)
                    {
                        Console.WriteLine(books[i].Detail());
                    }
                    break;

                case "2":
                    Console.WriteLine("Butun kitablar");
                    foreach (var book in books)
                    {
                        Console.WriteLine(book.Detail());
                    }
                    break;

                    case "0":
                    Console.WriteLine("programi baglandi");  
                    return;

                    default:
                    Console.WriteLine("dogru secim edin");
                    break;

            }


        }
    }
}
