using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArdalisRating.Models
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.Write(message);
        }
    }
}