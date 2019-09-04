namespace PalTracker
{
    public class WelcomeMessage
    {
        public string Message { get; }
        public int Count { get; set; }

        public WelcomeMessage(string message)
        {
            Message = message;
        }
    }
}