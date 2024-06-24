namespace EF_FirstDatabase;

internal class Program
{
    static void Main(string[] args)
    {
        var _context = new TqlprsdbContext();
        //var newUser = new User
        //{
        //    Id = 0, Username = "dw", Password = "dw",
        //    Firstname = "Demetri", Lastname = "Warren",
        //    IsReviewer = true, IsAdmin = true
        //};

        ////_context.Users.Add(newUser);
        ////_context.SaveChanges();

        //var deleteUser = _context.Users.Find(4);
        //_context.Users.Remove(deleteUser!);
        //_context.SaveChanges();

        //var newVendor = new Vendor
        //{
        //    Code = "AAPL", Name = "Apple", Address = "123 Apple Lane", 
        //    City = "Los Angeles", State = "CA", Zip = "12345"
        //};

        //_context.Vendors.Add(newVendor);
        //_context.SaveChanges();

        //1 product 1 request, 2 request lines. 

        //var newProduct = new Product
        //{
        //    Id = 0,
        //    PartNbr = "IPad",
        //    Name = "IPad 9",
        //    Price = 1200,
        //    Unit = "Each",
        //    VendorId = 4

        //};
        //_context.Products.Add(newProduct);
        //_context.SaveChanges();


        //var newRequest = new Request
        //{
        //    Id = 0, 
        //    Description = "First Request",
        //    Justification = "None Needed",
        //    DeliveryMode = "Pickup",
        //    Status = "NEW",
        //    Total = 2400,
        //    UserId = 1
        //};
        //_context.Requests.Add(newRequest);
        //_context.SaveChanges();

        //var newRequestLine = new Requestline
        //{
        //    Id = 0,
        //    Quantity = 1,
        //    RequestId = 2,
        //    ProductId = 12,

        //};

        //_context.Requestlines.Add(newRequestLine);
        //_context.SaveChanges();

        var newRequestLine = new Requestline
        {
            Id = 0,
            Quantity = 5,
            RequestId = 2,
            ProductId = 12,
        };
        _context.Requestlines.Add(newRequestLine);
        _context.SaveChanges(); 
    }
}
