public class RandomGenerator
{
    private List<Product> _productList;
    private List<Address> _addressList;

    private List<string> _customerList;

    public Product GetRandomProduct()
    {
        _productList = new List<Product>
        {
            new Product("Laptop", 1001, 1200.50m, 5),
            new Product("Smartphone", 1002, 899.99m, 10),
            new Product("Tablet", 1003, 450.00m, 7),
            new Product("Monitor", 1004, 299.99m, 8),
            new Product("Keyboard", 1005, 49.99m, 15),
            new Product("Mouse", 1006, 25.99m, 20),
            new Product("Headphones", 1007, 75.00m, 12),
            new Product("Webcam", 1008, 60.50m, 9),
            new Product("Printer", 1009, 150.00m, 4),
            new Product("Router", 1010, 80.00m, 6),
            new Product("External Hard Drive", 1011, 100.00m, 5),
            new Product("USB Flash Drive", 1012, 15.99m, 25),
            new Product("Smartwatch", 1013, 199.99m, 7),
            new Product("Bluetooth Speaker", 1014, 89.99m, 10),
            new Product("Projector", 1015, 350.00m, 3),
            new Product("Gaming Console", 1016, 499.99m, 2),
            new Product("Camera", 1017, 650.00m, 4),
            new Product("Fitness Tracker", 1018, 99.99m, 6),
            new Product("Drone", 1019, 799.99m, 1),
            new Product("Smart Light", 1020, 25.00m, 15)
        };

        Random random = new Random();

        int index = random.Next(_productList.Count);

        Product randomProduct = _productList[index];

        return randomProduct;
    }

    public Address GetRandomAddress()
    {

        _addressList = new List<Address> {
            new Address("123 Main St", "New York", "New York", "USA"),
            new Address("456 Maple Ave", "Los Angeles", "California", "USA"),
            new Address("789 Oak St", "Chicago", "Illinois", "USA"),
            new Address("101 Pine St", "Houston", "Texas", "USA"),
            new Address("202 Cedar St", "Phoenix", "Arizona", "USA"),
            new Address("303 Birch St", "Miami", "Florida", "USA"),
            new Address("404 Elm St", "Dallas", "Texas", "USA"),
            new Address("505 Walnut St", "Denver", "Colorado", "USA"),
            new Address("606 Cherry St", "San Francisco", "California", "USA"),
            new Address("707 Ash St", "Boston", "Massachusetts", "USA"),
            new Address("808 Palm St", "Toronto", "Ontario", "Canada"),
            new Address("909 Willow St", "Vancouver", "British Columbia", "Canada"),
            new Address("123 King St", "London", "", "United Kingdom"),
            new Address("456 Queen St", "Sydney", "New South Wales", "Australia"),
            new Address("789 Victoria St", "Melbourne", "Victoria", "Australia"),
            new Address("101 High St", "Auckland", "Auckland", "New Zealand"),
            new Address("202 River Rd", "Dublin", "Dublin", "Ireland"),
            new Address("303 Mountain St", "Zurich", "New South Wales", "Switzerland"),
            new Address("404 Sea View Ave", "Cape Town", "Cape Town", "South Africa"),
            new Address("Av. 9 de Julio 1234", "Buenos Aires", "Ciudad Autónoma de Buenos Aires", "Argentina")
            };

        Random random = new Random();

        int index = random.Next(_addressList.Count);

        Address randomAddress = _addressList[index];

        return randomAddress;
    }

    public string GetRandomCustomer()
    {
        _customerList = new List<string> {
               "Aiden",
               "Sakura",
               "Diego",
               "Fatima",
               "Giovanni",
               "Leila",
               "Anwar",
               "Yasmine",
               "Rohan",
               "Sofia",
               "Alejandro",
               "Ingrid",
               "Zhen",
               "Lars",
               "Mia",
               "Ibrahim",
               "Pavel",
               "Amina",
               "Lucas",
               "Elena"
            };

        Random random = new Random();

        int index = random.Next(_customerList.Count);

        string randomCustomerName = _customerList[index];

        return randomCustomerName;
    }
}