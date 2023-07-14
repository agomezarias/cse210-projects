using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        DateTime localDate = DateTime.Now;

        Address address = new Address("2345 Florence St", "Aurora", "CO", "80010", "us");
  

        Customer customer1 = new Customer("Alberto Gomez", address);
        // Console.WriteLine(customer1.GetCustomerInfo());

        List<Product> product = new List<Product>()
        {
            new Product("Cheese", "CH3323", 2.99, 2),
            new Product("Hamburgers", "Ham123", 10.99, 1)
        
        };

        Order order1 = new Order(customer1, product);
        

        // order1.AddProduct(product1);

        double _totalWithShipping = order1.TotalPlusSHipping();
        order1.GetPackingLabel();

        Console.WriteLine(_totalWithShipping);
        // Console.WriteLine(_packingLabel);

        //RECEIPT
        // foreach ()
        
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"Order For: {customer1.GetCustomerName()}");
        Console.WriteLine($"           {localDate}");
        Console.WriteLine();
        Console.WriteLine($"QTY     ITEM                    PRICE");
        Console.WriteLine("------------------------------------------"); 
        // Console.WriteLine($"{product.g}       {product1.GetProductName()}                  {product1.GetPrice()}");
    }


    
}
