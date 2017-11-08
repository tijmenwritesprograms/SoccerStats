﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoccerStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "data.txt");
            var file = new FileInfo(fileName);

            if (file.Exists)
            {
                using (var reader = new StreamReader(fileName))
                {
                    Console.SetIn(reader);
                    Console.WriteLine(Console.ReadLine());
                }

             }
            
        }
    }
}
