namespace OOApp;

internal class Student
{
    // read only fields for immutability
    private readonly int _id;
    private readonly string? _firstname;
    private readonly string? _lastname;

    // Immutable class with readonly fields and no setters, only getters
    public int Id { get => _id; }     
    public string? Firstname { get => _firstname; }
    public string? Lastname { get => _lastname; } 
}
