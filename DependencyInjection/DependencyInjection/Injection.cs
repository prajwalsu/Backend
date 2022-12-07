using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
class Runner{
   private ILogger _logger;
   public Runner(ILogger logger){
      _logger = logger;
   }
   public void Run(){
      // Do some work
      _logger.Log("Message to be logged");
   }
}
interface ILogger{
   void Log(string message);
}
class Logger : ILogger{
   public void Log(string message){
      Console.WriteLine(message);
   }
}
}
