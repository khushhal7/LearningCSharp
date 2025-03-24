
// In this we are creating an custom exception named UserAlreadyLoggedInException, which derived form base Exception class.
//

using System.Runtime.Serialization;


public class _42_CustomException
{
    public static void Main()
    {
        try
        {
            throw new UserAlreadyLoggedInException("User already logged in, Please log out first to login.");
        }
        catch (UserAlreadyLoggedInException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}



public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() : base() { }
    public UserAlreadyLoggedInException(string message) : base(message) { }
    public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException) { }
    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context) { }

}
