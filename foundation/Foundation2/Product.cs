using System.Data.Common;

public class Product {
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;


    public Product (string name, string productId, int price, int quantity) {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal ComputeProductCost() {
        decimal total = _price * _quantity;
        return total;
    }

    public string SetProductName () {
        return _name;
    }
    public string SetProductId () {
        return _productId;
    }


 

    /*
    public string SetPackingLabel () {
        return $"{_name} - {_productId}";
    }
    
    */


}