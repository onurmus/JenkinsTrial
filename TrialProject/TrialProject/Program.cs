﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrialProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello trial!");
            Console.WriteLine("Commit trial!");
			Console.WriteLine("Hello new trial!");
			Console.WriteLine("5");

            string json = JsonConvert.SerializeObject("here is a library trial");
            Console.WriteLine(json);
            Console.ReadLine();
        }
    }
}
