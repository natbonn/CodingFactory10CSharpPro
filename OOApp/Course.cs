namespace OOApp;

internal class Course
{
    private int _id;
    private string? _name;

    // with private setters, the properties can only be set within the class,
    // making them effectively read-only from outside the class. 
    // Usually dont use private getters, but private setters are useful for immutability and encapsulation.
    public int Id { get => _id; init => _id = value; }      // C# 9.0 introduced init-only properties --> Object initializers can set the property during object creation, but it cannot be modified afterward.
    public string? Name { get => _name; private set => _name = value; }  // Can not be user by Object initializer.

}
