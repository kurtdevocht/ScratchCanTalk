using Microsoft.Owin.Hosting;
using System;

namespace ScratchCanTalk
{
    static class Program
    {
        static void Main(string[] args)
        {
            var port = 15003;

            var options = new StartOptions()
            {
                ServerFactory = "Nowin",
                Port = port
            };

            using (WebApp.Start<Startup>(options))
            {
                Console.WriteLine("All OK!");
                Console.WriteLine("Running a http server on port " + port);
                Console.ReadKey();
            }
        }
    }
}
