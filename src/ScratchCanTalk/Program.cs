using Microsoft.Owin.Hosting;
using System;

namespace ScratchCanTalk
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");


            Console.WriteLine(@"   _____                _       _      _____         _______    _ _    ");
            Console.WriteLine(@"  / ____|              | |     | |    / ____|       |__   __|  | | |   ");
            Console.WriteLine(@" | (___   ___ _ __ __ _| |_ ___| |__ | |     __ _ _ __ | | __ _| | | __");
            Console.WriteLine(@"  \___ \ / __| '__/ _` | __/ __| '_ \| |    / _` | '_ \| |/ _` | | |/ /");
            Console.WriteLine(@"  ____) | (__| | | (_| | || (__| | | | |___| (_| | | | | | (_| | |   <");
            Console.WriteLine(@" |_____/ \___|_|  \__,_|\__\___|_| |_|\_____\__,_|_| |_|_|\__,_|_|_|\_\");

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
