namespace TreesAPI.Models
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }
}

