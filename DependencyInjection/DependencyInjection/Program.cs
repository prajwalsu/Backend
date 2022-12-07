using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args) {
            var logger = new Logger();
            var runner = new Runner(logger);
            runner.Run();
        }
    }
}
