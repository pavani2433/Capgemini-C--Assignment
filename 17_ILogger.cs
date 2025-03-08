using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public interface ILogger
    {
        void Log(string message);
    }
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging to file: " + message);
        }
    }

    public class TimestampLogger : ILogger
    {
        private readonly ILogger _logger;

        public TimestampLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            _logger.Log($"[{timestamp}] {message}");
        }
    }

    public class ErrorLogger : ILogger
    {
        private readonly ILogger _logger;

        public ErrorLogger(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            _logger.Log("[ERROR] " + message);
        }
    }

    class Program
    {
        static void Main()
        {
            ILogger logger = new FileLogger();
            logger = new TimestampLogger(logger);
            logger = new ErrorLogger(logger);

            logger.Log("This is an error log with a timestamp.");
        }
    }

}
