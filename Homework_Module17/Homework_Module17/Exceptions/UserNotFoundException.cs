namespace Homework_Module17.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string? message) : base(message)
        {
        }

        public UserNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
