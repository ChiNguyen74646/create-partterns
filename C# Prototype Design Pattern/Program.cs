﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

using System.Collections.Generic;

namespace C__Prototype_Design_Pattern
{
    internal class Program
    {
        /// <summary>
        /// Prototype Design Pattern
        /// </summary>

      
            public static void Main(string[] args)
            {
                ColorManager colormanager = new ColorManager();

                // Initialize with standard colors

                colormanager["red"] = new Color(255, 0, 0);
                colormanager["green"] = new Color(0, 255, 0);
                colormanager["blue"] = new Color(0, 0, 255);

                // User adds personalized colors

                colormanager["angry"] = new Color(255, 54, 0);
                colormanager["peace"] = new Color(128, 211, 128);
                colormanager["flame"] = new Color(211, 34, 20);

                // User clones selected colors

                Color color1 = colormanager["red"].Clone() as Color;
                Color color2 = colormanager["peace"].Clone() as Color;
                Color color3 = colormanager["flame"].Clone() as Color;

                // Wait for user

                Console.ReadKey();
            }
        }

        /// <summary>
        /// The 'Prototype' abstract class
        /// </summary>


        /// <summary>
        /// The 'ConcretePrototype' class
        /// </summary>

      

        /// <summary>
        /// Prototype manager
        /// </summary>

    }



