using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        DateTime localDate = DateTime.Now;

        //FIRST CUSTOMER

        Address address1 = new Address("2345 florence St", "aurora", "Co", "80010", "USA");

        Customer customer1 = new Customer("Alberto Gomez", address1);

        List<Product> product1 = new List<Product>()
        {
            new Product("Cheese", "CHE323", 2.99, 2),
            new Product("Hamburgers", "HAM123", 10.99, 1),
            new Product("Sausage", "SAU549", 3.29, 3)

        };

        Order order1 = new Order(customer1, product1);//Create new order

        Console.WriteLine(order1.GetPackingLabel());//Create the packing list

        Console.WriteLine(order1.DisplayOrderReceipt());//Create a recipt

        Console.WriteLine(customer1.GetShippingLabel());//Create a Shipping Label


        //SECOND CUSTOMER

        Address address2 = new Address("2319 Jasmine St", "Denver", "CO", "80247", "US");

        Customer customer2 = new Customer("Jesse James", address2);

        List<Product> product2 = new List<Product>()
        {
            new Product("Office Chair", "123987456", 59.99, 1),
            new Product("Pillow", "548721686", 13.99, 2)
        };

        Order order2 = new Order(customer2, product2);//Create new order.

        Console.WriteLine(order2.GetPackingLabel());//Create the packing list

        Console.WriteLine(order2.DisplayOrderReceipt());//Create a recipt

        Console.WriteLine(customer2.GetShippingLabel());//Create a Shipping Label


        //THIRD CUSTOMER

        Address address3 = new Address("Independencia 952", "Jalisco", "GDL", "44200", "MX");

        Customer customer3 = new Customer("Pancho Villa", address3);

        List<Product> product3 = new List<Product>()
        {
            new Product("Taladro", "TAL468", 75.99, 1),
            new Product("Pinsas", "PIN936", 15.99, 1),
            new Product("Desarmador", "DES763", 21.99, 2)
        };

        Order order3 = new Order(customer3, product3);//Create new order.

        Console.WriteLine(order3.GetPackingLabel());//Create the packing list

        Console.WriteLine(order3.DisplayOrderReceipt());//Create a recipt

        Console.WriteLine(customer3.GetShippingLabel());//Create a Shipping Label

    }

}