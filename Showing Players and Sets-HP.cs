using System;

namespace ShowPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ax, Ay, Bx, By, Cx, Cy;
            int Hs, set;
            int Health1=0, Health2 = 0, Health3 = 0;
            string a, b, c;

            Random rand = new Random();
            Bx = rand.Next(-10, 11);
            By = rand.Next(-10, 11);
            Cx = rand.Next(-10, 11);
            Cy = rand.Next(-10, 11);

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
                Cx = rand.Next(-10, 10);
                Cy = rand.Next(-10, 10);
            }
            
            Hs = rand.Next(1, 7);
            if (Hs == 1)
            { Health1 = 60; Health2 = 80; Health3 = 100; }
            else if (Hs == 2)
            { Health1 = 60; Health2 = 100; Health3 = 80; }
            else if (Hs == 3)
            { Health1 = 80; Health2 = 60; Health3 = 100; }
            else if (Hs == 4)
            { Health1 = 80; Health2 = 100; Health3 = 60; }
            else if (Hs == 5)
            { Health1 = 100; Health2 = 60; Health3 = 80; }
            else if (Hs == 6)
            { Health1 = 100; Health2 = 80; Health3 = 60; }
            
            set = rand.Next(1, 7);
            c = (" "); b = (" "); a = (" ");
            if (set == 1)
            { a = ("set 1"); b = ("set 2"); c = ("set 3"); }
            else if (set == 2)
            { a = ("set 1"); b = ("set 3"); c = ("set 2"); }
            else if (set == 3)
            { a = ("set 2"); b = ("set 1"); c = ("set 3"); }
            else if (set == 4)
            { a = ("set 2"); b = ("set 3"); c = ("set 1"); }
            else if (set == 5)
            { a = ("set 3"); b = ("set 2"); c = ("set 1"); }
            else if (set == 6)
            { a = ("set 3"); b = ("set 1"); c = ("set 2"); }

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
            Console.WriteLine("A: " + a + " Health:" + Health1+ " ");
            Console.WriteLine("B: " + b + " Health:" + Health2 + " ");
            Console.WriteLine("C: " + c + " Health:" + Health3 + " ");
            Console.ReadKey();

        }
    }
}
