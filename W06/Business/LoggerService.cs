using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W06.Logging.Abstract;
using W06.Logging.Abstract;

namespace W06.Business
{
    public class LoggerService
    {
        ILogger _logger;
        public LoggerService(ILogger logger)
        {
            _logger = logger;
        }

        public void LogInfo(string message)
        {
            Console.WriteLine($"INFO: {message}");
        }

        public void LogWarning(string message)
        {
            Console.WriteLine($"WARNING: {message}");
        }

        public void LogError(string message)
        {
            Console.WriteLine($"ERROR: {message}");
        }

        public void LogWrite(string message)
        {
            throw new NotImplementedException();
        }
    }
}