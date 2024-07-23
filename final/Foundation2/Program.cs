using System;
namespace Foundation2;
class Program
{
    static void Main(string[] args)
    {  List<Order> orders = new List<Order>();
       List<Product> productsOrder1 = new List<Product>();
       List<Product> productsOrder2 = new List<Product>();

       Customer customer1 = new Customer("Nazia Humma", new Address("Rue Point Six","Diego Suarez","Antsiranana","Madagascar"));
       Customer customer2 = new Customer("Brian Dugger", new Address("Rue Durran","Ankorondrano","Antananarive","Madagascar"));
       
       Product product1 = new Product("Parfum Dior","P00034",2004.59,2);
       Product product2 = new Product("Shoes Adidas","P00011",1500.20,1);  
       Product product3 = new Product("Shoes Puma","P00033",520.10,1); 
       Product product4 = new Product("Bag Helmet","P00023",120.15,1); 

       productsOrder1.Add(product1);
       productsOrder1.Add(product2);
       productsOrder2.Add(product3);
       productsOrder2.Add(product4);

       Order order1 = new Order(productsOrder1,customer1);
       Order order2 = new Order(productsOrder2,customer2);

       orders.Add(order1);
       orders.Add(order2);
       int counter = 1;
       foreach(Order order in orders){
        Console.WriteLine($"Order N {counter}: ");
        Console.WriteLine("Packing List:");
         foreach(string item in order.PackingLabel()){

            Console.WriteLine($"{item}");
         }
         Console.WriteLine($"Shipment:{order.ShippingLabel()}");
         Console.WriteLine($"Total:{order.CalculateTotal()} USD");
         counter++;
       }
    }
}