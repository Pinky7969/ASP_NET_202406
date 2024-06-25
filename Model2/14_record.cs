Product product = new Product(1, "aaa", 1000);
product.ProductName = "bbb";
Product product2 = new Product(1, "aaa", 1000);
Console.WriteLine(product == product2);

//class Product
//{
//    public int ProductId { get; set; }
//    public string ProductName { get; set; }
//    public decimal UnitPrice { get; set; }

//    public Product(int productid, string productname, decimal unitprice)
//    {
//        ProductId = productid;
//        ProductName = productname;
//        UnitPrice = unitprice;
//    }
//}

//record Product
//{
//    public int ProductId { get; set; }
//    public string ProductName { get; set; }
//    public decimal UnitPrice { get; set; }

//    public Product(int productid, string productname, decimal unitprice)
//    {
//        ProductId = productid;
//        ProductName = productname;
//        UnitPrice = unitprice;
//    }
//}

record struct Product(int ProductId, string ProductName, decimal UnitPrice);