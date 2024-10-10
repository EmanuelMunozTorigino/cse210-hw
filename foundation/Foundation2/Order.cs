using System.Collections;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    private decimal _shippingCost;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
        _shippingCost = _customer.LivingInUSA() ? 5m : 35m;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }


    public decimal ComputetotalCost()
    {
        decimal allProductCost = 0m;
        foreach (Product product in _products)
        {
            allProductCost += product.ComputeProductCost();
        }


            /*  A way to add the cost of shipping
        if (_customer.LivingInUSA())
        {
            allProductCost += 5m;
        }
        else
        {
            allProductCost += 35m;
        }
        
        */

        return allProductCost + _shippingCost;
    }

    public List<List<string>> PackingLabelMessage()
    {

        
        List<List<string>> message = new List<List<string>>();

        foreach (Product product in _products)
        {
            string productName = product.SetProductName();
            string productId = product.SetProductId();

            List<string> productList = new List<string>() {productName, productId};
 
            message.Add(productList);
        }

        return message;
    }

}