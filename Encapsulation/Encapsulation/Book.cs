namespace Encapsulation
{
    public class Book : Product
    {
        public string Genre { get; set; }
        public Book(string name, int price, int count, string genre) : base(name, price, count)
        {
            this.Genre = genre;
        }

        public new string Detail()
        {
            return $"Book Name: {Name}, Price: {Price}, Count: {Count}, Genre: {Genre}";
        }
    }
    
}
