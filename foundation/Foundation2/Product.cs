using System.Data.Common;

public class Product
{
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;


    public Product(string name, int productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal ComputeProductCost()
    {
        decimal total = _price * _quantity;
        return total;
    }

    /*
        public string SetProductName () {
            return _name;
        }
        public string SetProductId () {
            return _productId;
        }
    */


    public string GetPackingLabel()
    {
        return $"[{_productId}] - {_name}(x{_quantity})";
    }


}