﻿using System;

namespace ShowPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ax, Ay, Bx, By, Cx, Cy;

            Random rand = new Random();
            Bx = rand.Next(-10, 10);
            By = rand.Next(-10, 10);
            Cx = rand.Next(-10, 10);
            Cy = rand.Next(-10, 10);

            Console.Write("Ax:");
            Ax = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ay:");
            Ay = Convert.ToInt32(Console.ReadLine());

            if ((Ax > 10 || Ay > 10) || (Ax < -10 || Ax < -10))
            {
                Console.WriteLine("You wrote wrong numbers please when you open the game write right numbers (-10 to 10)!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (Ax == Bx || Ay == By || Bx==Cx || Cy==By)
            {
                Bx = rand.Next(-10, 10);
                By = rand.Next(-10, 10);
            }
           if(Ax == Cx || Ay == Cy || Bx == Cx || Cy == By)
            {
                Bx = rand.Next(-10, 10);
                By = rand.Next(-10, 10);
            }

            Console.WriteLine(
                "   +----------^----------+\r\n " +
                "10|..........|..........|\r\n  " +
                "9|..........|..........|\r\n  " +
                "8|..........|..........|\r\n  " +
                "7|..........|..........|\r\n  " +
                "6|..........|..........|\r\n  " +
                "5|..........|..........|\r\n  " +
                "4|..........|..........|\r\n  " +
                "3|..........|..........|\r\n  " +
                "2|..........|..........|\r\n  " +
                "1|..........|..........|\r\n  " +
                "0|----------+---------->\r\n " +
                "-1|..........|..........|\r\n " +
                "-2|..........|..........|\r\n " +
                "-3|..........|..........|\r\n " +
                "-4|..........|..........|\r\n " +
                "-5|..........|..........|\r\n " +
                "-6|..........|..........|\r\n " +
                "-7|..........|..........|\r\n " +
                "-8|..........|..........|\r\n " +
                "-9|..........|..........|\r\n" +
                "-10|..........|..........|\r\n" +
                "   +---------------------+\r\n " +
                "   098765432101234567890\r\n");

            Console.SetCursorPosition(Ax=Ax+14, Ay=13-Ay);
            Console.WriteLine("A");
            Console.SetCursorPosition(Bx=Bx + 14, By = 13 - By);
            Console.WriteLine("B");
            Console.SetCursorPosition(Cx= Cx + 14, Cy = 13 - Cy);
            Console.WriteLine("C");
            Console.SetCursorPosition(0, 27);
            Console.ReadKey();

        }
    }
}