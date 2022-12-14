namespace Interface
{
    class Program
    {
        private static void Main(string[] args)
        {
            FileLogger fileLogger=new();
            fileLogger.WriteLog();

            DatabaseLogger databaseLogger=new();
            databaseLogger.WriteLog();

            SmsLogger smsLogger=new();
            smsLogger.WriteLog();

            LogManager logManager=new LogManager(new FileLogger());
            logManager.WriteLog();

        }
    }
}
