using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace ConsoleTestLog
{
    class Program
    {
        public static ILog log = LogManager.GetLogger(string.Empty);
        public static int a = 0;
        public static int b = 1;
        public static int c = 0;
        static void Main(string[] args)
        {
            try
            {
                c = b / a; // тут возникнет исключение, так как у нас в массиве только 4 элемента
                log.Info("Ок");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            finally
            {
                log.Info("Блок finally");
            }

        }
    }
}
