using System;
namespace Foundation2;

public class Order {


    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products,Customer customer) {
      _customer=customer;
      _products=products;
    }
    public double CalculateTotal(){
      double total = 0;
     foreach (Product item in _products)
     {
        total+=item.TotalPrice();
     }
     return total;
    }
    public List<string> PackingLabel(){
        List<string> label = new List<string>();
     foreach (Product item in _products)
     {
        label.Add($"Id:{item.getProductId()}, name:{item.getName()}");
     }
     return label;
    }
    public string ShippingLabel(){
     return $"Name: {_customer.getName()}, Address: {_customer.getAddress()}";
    }
}