using ConsoleApp1.Models;

public class Program
{
    private static void Main(string[] args)
    {
NorthwindContext context = new NorthwindContext();
        // string city = Console.ReadLine();
        //IEnumerable<Customer> customer = (from c in context.Customers
        //                     where c.City == city
        //                     select c);
        IEnumerable<Product> products = (from p in context.Products
                                         where p.Category.CategoryName == "Beverages"
                                         select p);

        foreach (Product product in products)
        {
            Console.WriteLine("{0}", product);
            //foreach (Category cat in product.Category)
            //{
            //    Console.WriteLine("{0}", cat);
            //}
        }
    }

    

}