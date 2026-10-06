namespace FileManagementApp;

internal class ListNode<T>
{
    public required T Value { get; init; }   // required: compile time safety - error
    public int Count { get; set; }
}
