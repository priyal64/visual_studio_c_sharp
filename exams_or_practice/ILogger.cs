using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    public interface ILogger
    {
        void Log(string message);
    }

    // FileLogger.cs
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging: {message} to file.");
        }
    }

    // TimestampLogger.cs
    public class TimestampLogger : ILogger
    {
        private ILogger logger;

        public TimestampLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public void Log(string message)
        {
            logger.Log($"{DateTime.Now}: {message}");
        }
    }

    // ErrorCategoryLogger.cs
    public class ErrorCategoryLogger : ILogger
    {
        private ILogger logger;

        public ErrorCategoryLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public void Log(string message)
        {
            logger.Log($"ERROR: {message}");
        }
    }
}
