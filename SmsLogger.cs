namespace Interface
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
              Console.WriteLine("Sms olarak yazar.");
        }
    }
}