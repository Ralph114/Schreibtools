﻿using Schreibtools;
using System;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Collections;
using System.Collections.Generic;

namespace Schreibtools
{
    class Program
    {
        static void Main(string[] args)
        {
            string testtext = "Dies ist ein test Text"; 
            List<Stift> testlist = new List<Stift>();
            testlist.Add(new Kugelschreiber(3,ConsoleColor.Blue));
            testlist.Add(new Kugelschreiber(2, ConsoleColor.Red));
            testlist.Add(new Buntstift(3, ConsoleColor.Blue));
            testlist.Add(new Buntstift(2, ConsoleColor.White));
            foreach(Stift i in testlist)
            {
                i.SchreibeText(testtext);
            }
            Console.ReadKey();
        }
    }
}