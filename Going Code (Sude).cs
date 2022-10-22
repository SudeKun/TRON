using System;

namespace finished
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //COORDINATE VARIABLES
            int Ax, Ay, Bx, By, Cx, Cy;

            //DISTENCE VARIABLES
            int man_ab, man_bc, man_ac;
            double euc_ab,euc_bc,euc_ac;

            //HEALTH VARIABLES
            int hp, hpa = 0, hpb = 0, hpc = 0;

            //SET VARIABLES
            int set;
            string c = (" "), b = (" "), a = (" ") ;

            //STATEMENT VARIABLES
            string cst= (" "), bst= (" "), ast= (" ");

            //SCORE STATEMENTS
            int score_a = 0, score_b = 0,score_c = 0;

            //COORDINATES OF B AND C
            Random rand = new Random();
            Bx = rand.Next(-10, 11);
            By = rand.Next(-10, 11);
            Cx = rand.Next(-10, 11);
            Cy = rand.Next(-10, 11);

            //TAKING COORDINATES FROM PLAYER (A)
            Console.Write("Ax:");
            Ax = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ay:");
            Ay = Convert.ToInt32(Console.ReadLine());

            //CHEKING COORDINATES
            if ((Ax > 10 || Ay > 10) || (Ax < -10 || Ax < -10))
            {
                Console.WriteLine("You wrote wrong numbers please when you open the game write right numbers (-10 to 10)!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (Ax == Bx || Ay == By || Bx == Cx || Cy == By)
            {
                Bx = rand.Next(-10, 10);
                By = rand.Next(-10, 10);
            }
            if (Ax == Cx || Ay == Cy || Bx == Cx || Cy == By)
            {
                Cx = rand.Next(-10, 10);
                Cy = rand.Next(-10, 10);
            }

            //SETS HEALTH STATEMENTS
            hp = rand.Next(1, 7);

            if (hp == 1) { hpa = 60; hpb = 80; hpc = 100; }
            else if (hp == 2) { hpa = 60; hpb = 100; hpc = 80; }
            else if (hp == 3) { hpa = 80; hpb = 60; hpc = 100; }
            else if (hp == 4) { hpa = 80; hpb = 100; hpc = 60; }
            else if (hp == 5) { hpa = 100; hpb = 60; hpc = 80; }
            else if (hp == 6) { hpa = 100; hpb = 80; hpc = 60; }
            else { Console.WriteLine("Sorry machine error"); }

            //SETS SET STATEMENTS
            set = rand.Next(1, 7);

            if (set == 1) { a = ("set 1"); b = ("set 2"); c = ("set 3"); }
            else if (set == 2) { a = ("set 1"); b = ("set 3"); c = ("set 2"); }
            else if (set == 3) { a = ("set 2"); b = ("set 1"); c = ("set 3"); }
            else if (set == 4) { a = ("set 2"); b = ("set 3"); c = ("set 1"); }
            else if (set == 5) { a = ("set 3"); b = ("set 2"); c = ("set 1"); }
            else if (set == 6) { a = ("set 3"); b = ("set 1"); c = ("set 2"); }
            else { Console.WriteLine("Sorry machine error"); }

            //EUCLIDEAN DISTENCE CALCULATION
            euc_ab = Math.Sqrt(Math.Pow((Ax - Bx), 2) + Math.Pow((Ay - By), 2));
            euc_ac = Math.Sqrt(Math.Pow((Ax - Cx), 2) + Math.Pow((Ay - Cy), 2));
            euc_bc = Math.Sqrt(Math.Pow((Bx - Cx), 2) + Math.Pow((By - Cy), 2));

            //MANHATTAN DISTENCE CALCULATION
            man_ab = Math.Abs(Bx - Ax)+Math.Abs(By - Ay);
            man_ac = Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy);
            man_bc = Math.Abs(Cx - Bx) + Math.Abs(Cy - By);

            //SHOWING STATEMENTS
            Console.WriteLine("A:(" + Ax + "," + Ay + ")" + " \tSet:" + a + " \tHealth:" + hpa + " ");
            Console.WriteLine("B:(" + Bx + "," + By + ")" + " \tSet:" + b + " \tHealth:" + hpb + " ");
            Console.WriteLine("C:(" + Cx + "," + Cy + ")" + " \tSet:" + c + " \tHealth:" + hpc + " ");

            //SHOWING COORDINATES IN COORDINATE TABLE
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
                "  -098765432101234567890\r\n");

            Console.SetCursorPosition(Ax + 14, 16 - Ay);
            Console.WriteLine("A");
            Console.SetCursorPosition(Bx + 14, 16 - By);
            Console.WriteLine("B");
            Console.SetCursorPosition(Cx + 14, 16 - Cy);
            Console.WriteLine("C");

            Console.SetCursorPosition(0, 30);
            Console.ReadKey();

            //ROUND 1
            Console.Write("ROUND 1: ");
            double min_euc = Math.Min(Math.Min(euc_ab, euc_ac),euc_bc);
            if (min_euc <= 15)
            {
                if (min_euc == euc_ab) { 
                    Console.WriteLine("A - B");
                    cst = "NON-FIGHTER";
                    score_c = 0;
                    if (a=="set 1"&&b=="set 2" || a == "set 2" && b == "set 3" || a == "set 3" && b == "set 1")
                    {
                        hpb += 25; hpa = 0;
                        ast = "DEFEATED";
                        bst = "SURVIVOR";
                        score_a = 0;
                        score_b = 10*man_ab + (100-hpb);
                        min_euc = euc_bc;
                    }
                    else if(a == "set 2" && b == "set 1" || a == "set 3" && b == "set 2" || a == "set 1" && b == "set 3")
                    {
                        hpa += 25; hpb = 0;
                        ast = "SURVIVOR";
                        bst = "DEFEATED";
                        score_b = 0;
                        score_a = 10 * man_ab + (100 - hpa);
                        min_euc = euc_ac;
                    }
                }
                else if (min_euc == euc_ac) { 
                    if (euc_ac == euc_ab) { 
                        Console.WriteLine("A - B");
                        cst = "NON-FIGHTER";
                        score_c = 0;
                        if (a == "set 1" && b == "set 2" || a == "set 2" && b == "set 3" || a == "set 3" && b == "set 1")
                        {
                            hpb += 25; hpa = 0;
                            ast = "DEFEATED";
                            bst = "SURVIVOR";
                            score_a = 0;
                            score_b = 10 * man_ab + (100 - hpb);
                            min_euc = euc_bc;
                        }
                        else if (a == "set 2" && b == "set 1" || a == "set 3" && b == "set 2" || a == "set 1" && b == "set 3")
                        {
                            hpa += 25; hpb = 0;
                            ast = "SURVIVOR";
                            bst = "DEFEATED";
                            score_b = 0;
                            score_a = 10 * man_ab + (100 - hpa);
                            min_euc = euc_ac;
                        }
                    } 
                    else { 
                        Console.WriteLine("A - C");
                        bst = "NON-FIGHTER";
                        score_b = 0;
                        if (a == "set 1" && c == "set 2" || a == "set 2" && c == "set 3" || a == "set 3" && c == "set 1")
                        {
                            hpc += 25; hpa = 0;
                            ast = "DEFEATED";
                            cst = "SURVIVOR";
                            score_a=0;
                            score_c= 10 * man_ac + (100 - hpc);
                            min_euc = euc_bc;
                        }
                        else if (a == "set 2" && c == "set 1" || a == "set 3" && c == "set 2" || a == "set 1" && c == "set 3")
                        {
                            hpa += 25; hpc = 0;
                            ast = "SURVIVOR";
                            cst = "DEFEATED";
                            score_c = 0;
                            score_a = 10 * man_ac + (100 - hpa);
                            min_euc = euc_ab;
                        }
                    } 
                }
                else if (min_euc == euc_bc) { 
                    if (euc_bc == euc_ab) { 
                        Console.WriteLine("A - B");
                        cst = "NON-FIGHTER";
                        score_c = 0;
                        if (a == "set 1" && b == "set 2" || a == "set 2" && b == "set 3" || a == "set 3" && b == "set 1")
                        {
                            hpb += 25; hpa = 0;
                            ast = "DEFEATED";
                            bst = "SURVIVOR";
                            score_a = 0;
                            score_b = 10 * man_ab + (100 - hpb);
                            min_euc = euc_bc;
                        }
                        else if (a == "set 2" && b == "set 1" || a == "set 3" && b == "set 2" || a == "set 1" && b == "set 3")
                        {
                            hpa += 25; hpb = 0;
                            ast = "SURVIVOR";
                            bst = "DEFEATED";
                            score_b = 0;
                            score_a = 10 * man_ab + (100 - hpa);
                            min_euc = euc_ac;
                        }
                    } 
                    else { 
                        Console.WriteLine("B - C");
                        ast = "NON-FIGHTER";
                        score_a = 0;
                        if (b == "set 1" && c == "set 2" || b == "set 2" && c == "set 3" || b == "set 3" && c == "set 1")
                        {
                            hpc += 25; hpb = 0;
                            bst = "DEFEATED";
                            cst = "SURVIVOR";
                            score_b = 0;
                            score_c = 10 * man_bc + (100 - hpc);
                            min_euc = euc_ac;
                        }
                        else if (b == "set 2" && c == "set 1" || b == "set 3" && c == "set 2" || b == "set 1" && c == "set 3")
                        {
                            hpb += 25; hpc = 0;
                            bst = "SURVIVOR";
                            cst = "DEFEATED";
                            score_c = 0;
                            score_b = 10 * man_bc + (100 - hpb);
                            min_euc = euc_ab;
                        }
                    } 
                }
                else { Console.WriteLine("Sorry machine error"); }
            }
            else { Console.WriteLine("All players are too distant so, No Fight!"); }

            Console.WriteLine("A:"+ ast + " \tHealth:" + hpa + " \tScore:" + score_a + " "); 
            Console.WriteLine("B:" + bst + " \tHealth:" + hpb + " \tScore:" + score_b + " ");
            Console.WriteLine("C:" + cst + " \tHealth:" + hpc + " \tScore:" + score_c + " ");
            Console.ReadKey();

            //ROUND 2
            if (min_euc <= 15){
                if (min_euc == euc_ab)
                {
                    Console.WriteLine("A - B");
                    score_c = 0;
                    if (a == "set 1" && b == "set 2" || a == "set 2" && b == "set 3" || a == "set 3" && b == "set 1")
                    {
                        hpb += 25; hpa = 0;
                        ast = "DEFEATED";
                        bst = "SURVIVOR";
                        score_a = 0;
                        score_b = 10 * man_ab + (100 - hpb);
                    }
                    else if (a == "set 2" && b == "set 1" || a == "set 3" && b == "set 2" || a == "set 1" && b == "set 3")
                    {
                        hpa += 25; hpb = 0;
                        ast = "SURVIVOR";
                        bst = "DEFEATED";
                        score_b = 0;
                        score_a = 10 * man_ab + (100 - hpa);
                    }
                }
            }
                else if(min_euc == euc_ac)
                {

                }
                else if(min_euc == euc_bc)
                {

                }


            }

    }
}
