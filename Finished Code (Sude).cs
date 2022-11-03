using System;

namespace finished
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //COORDINATE VARIABLES
            string ax, ay;
            int Ax = 0, Ay = 0, Bx, By, Cx, Cy;

            //DISTENCE VARIABLES
            int man_ab, man_bc, man_ac;
            double euc_ab, euc_bc, euc_ac;

            //HEALTH VARIABLES
            int hp, hpa = 0, hpb = 0, hpc = 0;

            //SET VARIABLES
            int set;
            string c = (" "), b = (" "), a = (" ");

            //STATEMENT VARIABLES
            string cst = (" "), bst = (" "), ast = (" ");
            bool no_fight=false;

            //SCORE STATEMENTS
            int score_a = 0, score_b = 0, score_c = 0, max_score = 0;

            //COORDINATES OF B AND C
            Random rand = new Random();
            Bx = rand.Next(-10, 11);
            By = rand.Next(-10, 11);
            Cx = rand.Next(-10, 11);
            Cy = rand.Next(-10, 11);

            //TAKING COORDINATES FROM PLAYER (A) AND CHECKING
            Console.WriteLine("Please Enter The Location");
            Console.Write("Ax:");
            ax = Console.ReadLine();
            if (ax == "-10" || ax == "-9" || ax == "-8" || ax == "-7" || ax == "-6" || ax == "-5" || ax == "-4" || ax == "-3" || ax == "-2" || ax == "-1" || ax == "0" || ax == "1" || ax == "2" || ax == "3" || ax == "4" || ax == "5" || ax == "6" || ax == "7" || ax == "8" || ax == "9" || ax == "10") 
            { Ax = Convert.ToInt32(ax); }
            else
            {
                Console.WriteLine("You wrote wrong!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            ///////////////////////////////////////////////////
            Console.SetCursorPosition(8,1);
            Console.Write("Ay:");
            ay = Console.ReadLine();
            if (ay == "-10" || ay == "-9" || ay == "-8" || ay == "-7" || ay == "-6" || ay == "-5" || ay == "-4" || ay == "-3" || ay == "-2" || ay == "-1" || ay == "0" || ay == "1" || ay == "2" || ay == "3" || ay == "4" || ay == "5" || ay == "6" || ay == "7" || ay == "8" || ay == "9" || ay == "10")
            { Ay = Convert.ToInt32(ay); }
            else
            {
                Console.WriteLine("You wrote wrong!");
                Console.ReadKey();
                Environment.Exit(0);
            }

            //CHEKING COORDINATES
            if (Ax == Bx || Ay == By || Bx == Cx || Cy == By)
            {
                Bx = rand.Next(-10, 11);
                By = rand.Next(-10, 11);
            }
            if (Ax == Cx || Ay == Cy || Bx == Cx || Cy == By)
            {
                Cx = rand.Next(-10, 11);
                Cy = rand.Next(-10, 11);
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

            if (set == 1) { a = ("Disc"); b = ("Baton"); c = ("Staff"); }
            else if (set == 2) { a = ("Disc"); b = ("Staff"); c = ("Baton"); }
            else if (set == 3) { a = ("Baton"); b = ("Disc"); c = ("Staff"); }
            else if (set == 4) { a = ("Baton"); b = ("Staff"); c = ("Disc"); }
            else if (set == 5) { a = ("Staff"); b = ("Baton"); c = ("Disc"); }
            else if (set == 6) { a = ("Staff"); b = ("Disc"); c = ("Baton"); }
            else { Console.WriteLine("Sorry machine error"); }

            //EUCLIDEAN DISTENCE CALCULATION
            euc_ab = Math.Sqrt(Math.Pow((Ax - Bx), 2) + Math.Pow((Ay - By), 2));
            euc_ac = Math.Sqrt(Math.Pow((Ax - Cx), 2) + Math.Pow((Ay - Cy), 2));
            euc_bc = Math.Sqrt(Math.Pow((Bx - Cx), 2) + Math.Pow((By - Cy), 2));

            //MANHATTAN DISTENCE CALCULATION
            man_ab = Math.Abs(Bx - Ax) + Math.Abs(By - Ay);
            man_ac = Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy);
            man_bc = Math.Abs(Cx - Bx) + Math.Abs(Cy - By);

            //SHOWING STATEMENTS
            /////////////////////////COLOR FOR A////////////////////////////
             if(a=="Disc") Console.ForegroundColor=ConsoleColor.Cyan;
            else if(a=="Baton") Console.ForegroundColor=ConsoleColor.DarkYellow;
            else Console.ForegroundColor=ConsoleColor.Yellow;
             /////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("A:(" + Ax + "," + Ay + ")" + " \tSet:" + a + " \tHealth:" + hpa + " ");

            /////////////////////////COLOR FOR B////////////////////////////
             if(b=="Disc") Console.ForegroundColor=ConsoleColor.Cyan;
            else if(b=="Baton") Console.ForegroundColor=ConsoleColor.DarkYellow;
            else Console.ForegroundColor=ConsoleColor.Yellow;
             /////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("B:(" + Bx + "," + By + ")" + " \tSet:" + b + " \tHealth:" + hpb + " ");

            /////////////////////////COLOR FOR C////////////////////////////
            if(c=="Disc") Console.ForegroundColor=ConsoleColor.Cyan;
            else if(c=="Baton") Console.ForegroundColor=ConsoleColor.DarkYellow;
            else Console.ForegroundColor=ConsoleColor.Yellow;
            /////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("C:(" + Cx + "," + Cy + ")" + " \tSet:" + c + " \tHealth:" + hpc + " ");

            Console.ForegroundColor=ConsoleColor.White;

            //SHOWING COORDINATES IN COORDINATE TABLE
            Console.WriteLine(
               "   + - - - - - - - - - - ^ - - - - - - - - - - +\r\n " +
                "10| . . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "9| . . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "8| . . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "7| . . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "6| . . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "5| . . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "4| . . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "3| . . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "2| . . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "1| . . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "0| - - - - - - - - - - + - - - - - - - - - - >\r\n " +
                "-1| . . . . . . . . . . | . . . . . . . . . . |\r\n " +
                "-2| . . . . . . . . . . | . . . . . . . . . . |\r\n " +
                "-3| . . . . . . . . . . | . . . . . . . . . . |\r\n " +
                "-4| . . . . . . . . . . | . . . . . . . . . . |\r\n " +
                "-5| . . . . . . . . . . | . . . . . . . . . . |\r\n " +
                "-6| . . . . . . . . . . | . . . . . . . . . . |\r\n " +
                "-7| . . . . . . . . . . | . . . . . . . . . . |\r\n " +
                "-8| . . . . . . . . . . | . . . . . . . . . . |\r\n " +
                "-9| . . . . . . . . . . | . . . . . . . . . . |\r\n" +
                "-10| . . . . . . . . . . | . . . . . . . . . . |\r\n" +
                "   + - - - - - - - - - - - - - - - - - - - - - +\r\n " +
                "  -10 9 8 7 6 5 4 3 2 1 0 1 2 3 4 5 6 7 8 9 10\r\n");
            ////////////////////////////COLOR AND POSITION FOR A////////////////////////////
            Console.SetCursorPosition((Ax*2) + 25, 16 - Ay);
            if(a=="Disc") Console.ForegroundColor=ConsoleColor.Cyan;
            else if(a=="Baton") Console.ForegroundColor=ConsoleColor.DarkYellow;
            else Console.ForegroundColor=ConsoleColor.Yellow;
            /////////////////////////////////////////////////////////////////////////
            Console.WriteLine("A");

            ////////////////////////////COLOR AND POSITION FOR B////////////////////////////
            Console.SetCursorPosition((Bx*2) + 25, 16 - By);
            if(b=="Disc") Console.ForegroundColor=ConsoleColor.Cyan;
            else if(b=="Baton") Console.ForegroundColor=ConsoleColor.DarkYellow;
            else Console.ForegroundColor=ConsoleColor.Yellow;
            /////////////////////////////////////////////////////////////////////////
            Console.WriteLine("B");

            ////////////////////////////COLOR AND POSITION FOR C////////////////////////////
            Console.SetCursorPosition((Cx*2) + 25, 16 - Cy);
            if(c=="Disc") Console.ForegroundColor=ConsoleColor.Cyan;
            else if(c=="Baton") Console.ForegroundColor=ConsoleColor.DarkYellow;
            else Console.ForegroundColor=ConsoleColor.Yellow;
            /////////////////////////////////////////////////////////////////////////
            Console.WriteLine("C");

            ////////////////////////////////////////////////////////////////////////
            Console.ForegroundColor=ConsoleColor.White;
            Console.SetCursorPosition(0, 30);
            Console.ReadKey();

            //ROUND 1
            Console.Write("ROUND 1: ");
            double min_euc = Math.Min(Math.Min(euc_ab, euc_ac), euc_bc);
            if (min_euc <= 15){
                if (min_euc == euc_ab)
                {
                    Console.WriteLine("A - B");
                    cst = "NON-FIGHTER";
                    score_c = 0;
                    if (set==1||set==4||set==6)
                    {
                        hpb -= 25; hpa = 0;
                        ast = "DEFEATED";
                        bst = "SURVIVOR";
                        score_a = 0;
                        score_b = 10 * man_ab + (100 - hpb);
                        min_euc = euc_bc;
                    }
                    else
                    {
                        hpa -= 25; hpb = 0;
                        ast = "SURVIVOR";
                        bst = "DEFEATED";
                        score_b = 0;
                        score_a = 10 * man_ab + (100 - hpa);
                        min_euc = euc_ac;
                    }
                }
                else if (min_euc == euc_ac)
                {
                    if (euc_ac == euc_ab)
                    {
                        Console.WriteLine("A - B");
                        cst = "NON-FIGHTER";
                        score_c = 0;
                        if (set==1||set==4||set==6)
                        {
                            hpb -= 25; hpa = 0;
                            ast = "DEFEATED";
                            bst = "SURVIVOR";
                            score_a = 0;
                            score_b = 10 * man_ab + (100 - hpb);
                            min_euc = euc_bc;
                        }
                        else
                        {
                            hpa -= 25; hpb = 0;
                            ast = "SURVIVOR";
                            bst = "DEFEATED";
                            score_b = 0;
                            score_a = 10 * man_ab + (100 - hpa);
                            min_euc = euc_ac;
                        }
                    }
                    else
                    {
                        Console.WriteLine("A - C");
                        bst = "NON-FIGHTER";
                        score_b = 0;
                        if (set==2||set==3||set==5)
                        {
                            hpc -= 25; hpa = 0;
                            ast = "DEFEATED";
                            cst = "SURVIVOR";
                            score_a = 0;
                            score_c = 10 * man_ac + (100 - hpc);
                            min_euc = euc_bc;
                        }
                        else
                        {
                            hpa -= 25; hpc = 0;
                            ast = "SURVIVOR";
                            cst = "DEFEATED";
                            score_c = 0;
                            score_a = 10 * man_ac + (100 - hpa);
                            min_euc = euc_ab;
                        }
                    }
                }
                else if (min_euc == euc_bc)
                {
                    if (euc_bc == euc_ab)
                    {
                        Console.WriteLine("A - B");
                        cst = "NON-FIGHTER";
                        score_c = 0;
                        if (set==1||set==4||set==6)
                        {
                            hpb -= 25; hpa = 0;
                            ast = "DEFEATED";
                            bst = "SURVIVOR";
                            score_a = 0;
                            score_b = 10 * man_ab + (100 - hpb);
                            min_euc = euc_bc;
                        }
                        else
                        {
                            hpa -= 25; hpb = 0;
                            ast = "SURVIVOR";
                            bst = "DEFEATED";
                            score_b = 0;
                            score_a = 10 * man_ab + (100 - hpa);
                            min_euc = euc_ac;
                        }
                    }
                    else
                    {
                        Console.WriteLine("B - C");
                        ast = "NON-FIGHTER";
                        score_a = 0;
                        if (set==1||set==4||set==6)
                        {
                            hpc -= 25; hpb = 0;
                            bst = "DEFEATED";
                            cst = "SURVIVOR";
                            score_b = 0;
                            score_c = 10 * man_bc + (100 - hpc);
                            min_euc = euc_ac;
                        }
                        else
                        {
                            hpb -= 25; hpc = 0;
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
            else { no_fight = true; }

            if (no_fight == false) {
                //////////////////////////////////////////////////////////////////////////////////
                 if(a=="Disc") Console.ForegroundColor=ConsoleColor.Cyan;
                 else if(a=="Baton") Console.ForegroundColor=ConsoleColor.DarkYellow;
                 else Console.ForegroundColor=ConsoleColor.Yellow;
                //////////////////////////////////////////////////////////////////////////////////
                Console.WriteLine("A:" + ast + " \tHealth:" + hpa + " \tScore:" + score_a + " ");
                //////////////////////////////////////////////////////////////////////////////////
                 if(b=="Disc") Console.ForegroundColor=ConsoleColor.Cyan;
                 else if(b=="Baton") Console.ForegroundColor=ConsoleColor.DarkYellow;
                 else Console.ForegroundColor=ConsoleColor.Yellow;
                 //////////////////////////////////////////////////////////////////////////////////
                Console.WriteLine("B:" + bst + " \tHealth:" + hpb + " \tScore:" + score_b + " ");
                 //////////////////////////////////////////////////////////////////////////////////
                 if(c=="Disc") Console.ForegroundColor=ConsoleColor.Cyan;
                 else if(c=="Baton") Console.ForegroundColor=ConsoleColor.DarkYellow;
                 else Console.ForegroundColor=ConsoleColor.Yellow;
                 //////////////////////////////////////////////////////////////////////////////////
                Console.WriteLine("C:" + cst + " \tHealth:" + hpc + " \tScore:" + score_c + " "); }

            else if (no_fight == true) { Console.ForegroundColor=ConsoleColor.White; Console.WriteLine("All players are too distant so, No Fight!"); }
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.ForegroundColor=ConsoleColor.White;

            //ROUND 2
            Console.Write("ROUND 2: ");
            no_fight = false;
            if (min_euc <= 15){
                if (min_euc == euc_ab)
                {
                    Console.WriteLine("A - B");
                    if (set==1||set==4||set==6)
                    {
                        hpb -= 25; hpa = 0;
                        ast = "DEFEATED";
                        bst = "SURVIVOR";
                        score_b = 10 * man_ab + (100 - hpb);
                    }
                    else 
                    {
                        hpa -= 25; hpb = 0;
                        ast = "SURVIVOR";
                        bst = "DEFEATED";
                        score_a = 10 * man_ab + (100 - hpa);
                    }
                }
                else if (min_euc == euc_ac)
                {
                    Console.WriteLine("A - C");
                    if (set==2||set==3||set==5)
                    {
                        hpc += 25; hpa = 0;
                        ast = "DEFEATED";
                        cst = "SURVIVOR";
                        score_c = 10 * man_ac + (100 - hpc);
                    }
                    else
                    {
                        hpa -= 25; hpc = 0;
                        ast = "SURVIVOR";
                        cst = "DEFEATED";
                        score_a = 10 * man_ac + (100 - hpa);
                    }
                }
                else if (min_euc == euc_bc)
                {
                    Console.WriteLine("B - C");
                    if (set==1||set==4||set==6)
                    {
                        hpc -= 25; hpb = 0;
                        bst = "DEFEATED";
                        cst = "SURVIVOR";
                        score_c = 10 * man_bc + (100 - hpc);
                    }
                    else
                    {
                        hpb -= 25; hpc = 0;
                        bst = "SURVIVOR";
                        cst = "DEFEATED";
                        score_b = 10 * man_bc + (100 - hpb);
                    }
                }
            }
            else { no_fight = true; }
            
            if (no_fight==false) {

                 if(a=="Disc") Console.ForegroundColor=ConsoleColor.Cyan;
                 else if(a=="Baton") Console.ForegroundColor=ConsoleColor.DarkYellow;
                 else Console.ForegroundColor=ConsoleColor.Yellow;

                Console.WriteLine("A:" + ast + " \tHealth:" + hpa + " \tScore:" + score_a + " ");

                 if(b=="Disc") Console.ForegroundColor=ConsoleColor.Cyan;
                 else if(b=="Baton") Console.ForegroundColor=ConsoleColor.DarkYellow;
                 else Console.ForegroundColor=ConsoleColor.Yellow;

                Console.WriteLine("B:" + bst + " \tHealth:" + hpb + " \tScore:" + score_b + " ");

                 if(c=="Disc") Console.ForegroundColor=ConsoleColor.Cyan;
                 else if(c=="Baton") Console.ForegroundColor=ConsoleColor.DarkYellow;
                 else Console.ForegroundColor=ConsoleColor.Yellow;

                Console.WriteLine("C:" + cst + " \tHealth:" + hpc + " \tScore:" + score_c + " "); }

            else if(no_fight==true){ Console.ForegroundColor=ConsoleColor.White;Console.WriteLine("All players are too distant so, No Fight!"); }
            Console.WriteLine("\n");
            Console.ForegroundColor=ConsoleColor.Green;
            
            max_score = Math.Max(Math.Max(score_a, score_b), score_c);

            if (max_score == score_a) { Console.WriteLine("The Winner Is: A"+"\tScore:"+score_a); }
            else if (max_score == score_b) { Console.WriteLine("The Winner Is: B" + "\tScore:" + score_b); }
            else if (max_score == score_c) { Console.WriteLine("The Winner Is: C" + "\tScore:" + score_c); }
            else { Console.WriteLine("Sorry machine error"); }

            Console.ReadKey();
        }
    }
}
