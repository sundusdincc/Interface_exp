namespace Interface
{
    public class LogManager:ILogger
    {
         public ILogger _logger;//interface'in instance'ı

         public LogManager(ILogger logger)
         {
            _logger=logger;
         }

        public void WriteLog()
        {
           _logger.WriteLog();
        }
    }
}