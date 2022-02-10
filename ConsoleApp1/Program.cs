// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using log4net.Config;

XmlConfigurator.Configure(new FileInfo("log4net.xml"));
log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

for (int i = 0; i < 20; i++)
{
    new Thread(() => new Class1().Foo()).Start();
}
log.Logger.Repository.Shutdown();
Console.WriteLine("end!");
Console.ReadKey();
