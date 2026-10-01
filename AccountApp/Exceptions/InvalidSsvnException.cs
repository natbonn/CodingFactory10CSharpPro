namespace AccountApp.Exceptions;

internal class InvalidSsvnException : Exception
{
    public InvalidSsvnException() : base("Invalid SSN provided.")
    {
    }
    public InvalidSsvnException(string message) : base(message)
    {
    }
    public InvalidSsvnException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
