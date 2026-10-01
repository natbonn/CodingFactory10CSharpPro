namespace OOApp;

/// <summary>
/// Defines a Product POCO class with auto-implemented properties 
/// for Id, Name, and Price. Most likely used for e-commerce applications 
/// or inventory management systems. With prop & tab 
/// </summary>
internal class Product
{
    public  int Id { get; set; }      // auto-implemented property for Id 
    public string? Name { get; set; }
    public decimal Price { get; set; }

    public Product()
    {

    }

    public Product(int id, string? name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    // For debugging purposes, override the ToString() method
    // to provide a string representation of the Product object.
    public override string? ToString()
    {
        return $"Product: {Id} {Name} {Price:C2}";
    }

    // for equality comparison, override the Equals() method to compare Product objects based on their properties.
    public override bool Equals(object? obj)
    {
        return obj is Product product &&
               Id == product.Id &&
               Name == product.Name &&
               Price == product.Price;
    }

    // for hash-based collections, override the GetHashCode() method to provide a hash code based on the Product's properties.
    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name, Price);
    }
}
