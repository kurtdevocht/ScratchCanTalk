﻿using Microsoft.Owin.Hosting;
using System;

namespace ScratchCanTalk
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
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

            Console.WriteLine();

            try
            {
                using (WebApp.Start<Startup>(options))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Woohoow! The Scratch helper is running!");

                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("The server is running on port " + port);

                    Console.WriteLine();
                    Console.WriteLine(" - Start the Scratch offline editor");
                    Console.WriteLine(" - Click 'File' while holding the SHIFT key");
                    Console.WriteLine(" - Load the 'ScratchCanTalk Extension.s2e'");
                    Console.WriteLine(" - Use the 'Say'-block (in 'More blocks')");
                    Console.WriteLine(" - Have fun ;-)");

                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oops! Something is kaput :-(");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Here's some more info, hope it's helpful...");
                Console.WriteLine();
                Console.WriteLine(e);
                Console.ReadLine();

            }

           
        }
    }
}
