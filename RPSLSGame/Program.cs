﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Platform platform = new Platform();

            platform.RunGame();

            Console.ReadLine();
        }
    }
}