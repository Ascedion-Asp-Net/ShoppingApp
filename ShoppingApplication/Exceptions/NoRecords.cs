namespace ShoppingApplication.Exceptions
{
    public class NoRecords:Exception
    {
        string message;
        public NoRecords(string name)
        {

            message = $"No Entries {name} is available";

        }
        public override string Message => message;
    }
}
