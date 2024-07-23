using System;
namespace Foundation2;

public class Product{

    private string _name;
    private string _productId;
    private double _price;
    private  int _quantity;

    public Product( string name , string id, double price, int quantity){

        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }
    public string getName() {
        return _name;
    }
    public string getProductId() {
        return _productId;
    }
    public double TotalPrice(){
        
        return _quantity*_price;
    }

 }
    
