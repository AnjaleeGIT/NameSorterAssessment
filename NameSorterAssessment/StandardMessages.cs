﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorterAssessment
{
    /* Standard messages that are written on the console. */
    public class StandardMessages
    {

        public static void WelcomeMessage() {
            Console.WriteLine("Welcome to the Name Sorter");
        }
        public static void ExitMessage() {
            Console.WriteLine("Name sorting completed");
            Console.ReadLine();
        }
      
    }
}
