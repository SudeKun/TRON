
namespace deneme3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int Hs;
            string Health1;
            string Health2;
            string Health3;
            Hs = rand.Next(1, 7);
            Health1 = (" "); Health2 = (" ");Health3 = (" ");
           if (Hs == 1)
            { Health1 = ("60"); Health2 = ("80");Health3 = ("100");}
            else if (Hs == 2)
            { Health1 = ("60");Health2 = ("100");Health3 = ("80");}
            else if (Hs == 3)
            {Health1 = ("80");Health2 = ("60");Health3 = ("100");}
            else if (Hs == 4)
            {Health1 = ("80");Health2 = ("100");Health3 = ("60");}
            else if (Hs == 5)
            {   Health1 = ("100");Health2 = ("60");Health3 = ("80");}
            else if (Hs == 6)
            {Health1 = ("100");Health2 = ("80");Health3 = ("60");}
            int set;
            set = rand.Next(1, 7);
            string a; string b;string c;
            c = (" ");b = (" ");a = (" ");
            if (set == 1)
            {a = ("set 1"); b = ("set 2");c = ("set 3");}
            else if (set == 2)
            {a = ("set 1");b = ("set 3"); c = ("set 2");}
            else if (set == 3)
            {a = ("set 2");b = ("set 1");c = ("set 3"); }
            else if (set == 4)
            {a = ("set 2");b = ("set 3");c = ("set 1");}
            else if (set == 5)
            { a = ("set 3"); b = ("set 2"); c = ("set 1");}
            else if (set == 6)
            {a = ("set 3");b = ("set 1"); c = ("set 2");}
             Console.WriteLine("A: " + a + " Health:" + Health1 + " ");
             Console.WriteLine("B: " + b + " Health:" + Health2 + " ");
             Console.WriteLine("C: " + c + " Health:" + Health3 + " ");
        }
    }
}


