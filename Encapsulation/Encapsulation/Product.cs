namespace Encapsulation
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        

        public Product(string name, int price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        
        public string Detail()
        {
            return $"Product Name: {Name}, Price: {Price}, Count: {Count}";
        }

        public int Discount(int discountPercentage)
        {
            return Price - (Price * discountPercentage / 100);
        }
    }
}
