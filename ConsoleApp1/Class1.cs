using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Class1));
        public void Foo()
        {
            log.Debug($"Foo.{Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(10);
        }
    }
}
