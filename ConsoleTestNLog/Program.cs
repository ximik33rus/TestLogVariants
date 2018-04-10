using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace ConsoleTestNLog
{
    class Program
    {
        static void Main(string[] args)
        {
            

                Logger logger = LogManager.GetCurrentClassLogger();

            logger.Trace("trace message");
            logger.Trace("trace message3");

                    logger.Debug("debug message");

                    logger.Info("info message");

                    logger.Warn("warn message");

                    logger.Error("error message");

                    logger.Fatal("fatal message");

            
        }
    }
}
