using System;

namespace archer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(Console.WindowWidth, Console.WindowHeight * 2);

            Console.ForegroundColor = ConsoleColor.Green;//Changes font colour

            Console.Clear();

            Random rnd = new Random();//Initialization for Random.Next()

            //SCORE VARIABLES
            int aScore = 0;
            int bScore = 0;
            int cScore = 0;
            //END STATES - ROUND 1
            string a1State = "NO FIGHT";
            string b1State = "NO FIGHT";
            string c1State = "NO FIGHT";
            //END STATES - ROUND 2
            string a2State = "NO FIGHT";
            string b2State = "NO FIGHT";
            string c2State = "NO FIGHT";

            ////////////////////////
            ///MONKEY-TEST-PROOF?// (not at the moment)
            //////////////////////
            string tempx;
            string tempy;

            bool checkx;
            bool checky;

            //COORDINATES
            int ax = 0, ay = 0;// A(x,y)
            int bx = 0, by = 0;// B(x,y)
            int cx = 0, cy = 0;// C(x,y)

            //COORDINATES OF A
            Console.WriteLine("Enter X:");

            Console.ForegroundColor = ConsoleColor.White;//Changes font colour

            tempx = Console.ReadLine();

            if(tempx == "10" || tempx == "9" || tempx == "8" || tempx == "7" || tempx == "6" || tempx == "5" || tempx == "4" || tempx == "3" || tempx == "2" || tempx == "1" || tempx == "0" || tempx == "-1" || tempx == "-2" || tempx == "-2" || tempx == "-3" || tempx == "-4" || tempx == "-5" || tempx == "-6" || tempx == "-7" || tempx == "-8" || tempx == "-9" || tempx == "-10")
            {
                checkx = true;
                ax = Convert.ToInt32(tempx);
            }
            else
            {
                checkx = false;
            }

            Console.ForegroundColor = ConsoleColor.Green;//Changes font colour
            Console.WriteLine("Enter Y:");


            Console.ForegroundColor = ConsoleColor.White;//Changes font colour

            tempy = Console.ReadLine();

            if (tempy == "10" || tempy == "9" || tempy == "8" || tempy == "7" || tempy == "6" || tempy == "5" || tempy == "4" || tempy == "3" || tempy == "2" || tempy == "1" || tempy == "0" || tempy == "-1" || tempy == "-2" || tempy == "-2" || tempy == "-3" || tempy == "-4" || tempy == "-5" || tempy == "-6" || tempy == "-7" || tempy == "-8" || tempy == "-9" || tempy == "-10")
            {
                checky = true;
                ay = Convert.ToInt32(tempy);
            }
            else
            {
                checky = false;
            }

            Console.ForegroundColor = ConsoleColor.Green;//Changes font colour

            if (ax < -10 || ax > 10)
            {
                checkx = false;
            }

            if (ay < -10 || ay > 10)
            {
                checky = false;
            }


            if (checkx == true && checky == true)
            {
                Console.Clear();
            }
            else
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("#MONKEY TEST#\n");
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("X and Y are integer numbers between -10 and 10.");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n#MONKEY TEST#\n");
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.ReadKey();
                return;
            }


            //COORDINATES OF B AND C
            bx = rnd.Next(-10, 11);
            by = rnd.Next(-10, 11);
            cx = rnd.Next(-10, 11);
            cy = rnd.Next(-10, 11);
            
            /*FOR DEBUG
            bx = 10;
            by = 10;
            cx = 10;
            cy = 10;
            */

            //////////////////////
            //////////////////////

            //HP
            int aHP = 0, bHP = 0, cHP = 0;// Health Points of A, B and C

            int randHP = 0;// This is for assigning random values of HP to A, B and C without repetition
            randHP = rnd.Next(1, 7);// There are 6 posible permutations for HP for the values {60,80,100}

            if (randHP == 1)// Takes the random value 1 through 6 then assigns values accordingly
            {
                aHP = 60;
                bHP = 80;
                cHP = 100;
            }
            else if (randHP == 2)
            {
                aHP = 60;
                bHP = 100;
                cHP = 80;

            }
            else if (randHP == 3)
            {
                aHP = 80;
                bHP = 60;
                cHP = 100;
            }
            else if (randHP == 4)
            {
                aHP = 80;
                bHP = 100;
                cHP = 60;
            }
            else if (randHP == 5)
            {
                aHP = 100;
                bHP = 60;
                cHP = 80;
            }
            else if (randHP == 6)
            {
                aHP = 100;
                bHP = 80;
                cHP = 60;
            }


            //////////////////////
            //////////////////////

            //SETS

            int aSet = 0, bSet = 0, cSet = 0;// Types of set (Arrow and Shields) A, B and C use


            int randSet = 0;// This is for assigning random values of sets to A, B and C without repetition
            randSet = rnd.Next(1, 7);//Just like HP there are 6 permutations for sets {1,2,3}

            if(randSet == 1)// Takes the random value 1 through 6 then assigns values accordingly
            {
                aSet = 1;
                bSet = 2;
                cSet = 3;
            }
            else if(randSet == 2)
            {
                aSet = 1;
                bSet = 3;
                cSet = 2;

            }
            else if(randSet == 3)
            {
                aSet = 2;
                bSet = 1;
                cSet = 3;
            }
            else if(randSet == 4)
            {
                aSet = 2;
                bSet = 3;
                cSet = 1;
            }
            else if(randSet == 5)
            {
                aSet = 3;
                bSet = 1;
                cSet = 2;
            }
            else if(randSet == 6)
            {
                aSet = 3;
                bSet = 2;
                cSet = 1;
            }


            //////////////////////
            //////////////////////

            Console.Clear();

            //INFO FOR PLAYERS

            Console.WriteLine(" [[[MELTDOWN]]]\n");
            Console.ForegroundColor = ConsoleColor.Yellow;//Changes font colour

            //GRAPH
            Console.WriteLine("> A(     ,     )\t | HP :     |\t | SET :   |");
            Console.WriteLine("> B(     ,     )\t | HP :     |\t | SET :   |");
            Console.WriteLine("> C(     ,     )\t | HP :     |\t | SET :   |");


            // A INFO
            Console.SetCursorPosition(5, 2);
            Console.WriteLine(ax);

            Console.SetCursorPosition(11, 2);
            Console.WriteLine(ay);

            Console.SetCursorPosition(32, 2);
            Console.WriteLine(aHP);

            Console.SetCursorPosition(49, 2);
            Console.WriteLine(aSet);

            //B INFO
            Console.SetCursorPosition(5, 3);
            Console.WriteLine(bx);

            Console.SetCursorPosition(11, 3);
            Console.WriteLine(by);

            Console.SetCursorPosition(32, 3);
            Console.WriteLine(bHP);

            Console.SetCursorPosition(49, 3);
            Console.WriteLine(bSet);

            //C INFO
            Console.SetCursorPosition(5, 4);
            Console.WriteLine(cx);

            Console.SetCursorPosition(11, 4);
            Console.WriteLine(cy);

            Console.SetCursorPosition(32, 4);
            Console.WriteLine(cHP);

            Console.SetCursorPosition(49, 4);
            Console.WriteLine(cSet);

            Console.SetCursorPosition(0, 6);//Puts the cursor back where it is supposed to be

            //////////////////////
            //////////////////////

            //DISTANCE CALCULATIONS

            //Euclidean Distance : sqrt((x1-x2)^2+(y1-y2)^2)
            double dab = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by));//Distance between A and B
            double dac = Math.Sqrt((ax - cx) * (ax - cx) + (ay - cy) * (ay - cy));//Distance between A and C
            double dbc = Math.Sqrt((bx - cx) * (bx - cx) + (by - cy) * (by - cy));//Distance between B and C

            //Manhattan Distance : sqrt((x1 - x2)^2) + sqrt((y1 - y2)^2)
            int mandab = Math.Abs(ax - bx) + Math.Abs(ay - by);//Manhattan Distance between A and B
            int mandac = Math.Abs(ax - cx) + Math.Abs(ay - cy);//Manhattan Distance between A and C
            int mandbc = Math.Abs(bx - cx) + Math.Abs(by - cy);//Manhattan Distance between B and C

            //////////////////////
            

            //////////////////////
            //MAP FOR THE ARCHERS
            //////////////////////
            Console.ForegroundColor = ConsoleColor.White;//Changes font colour
            Console.WriteLine(
                "   +--------------------^---------------------+\r\n " +
                "10|. . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "9|. . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "8|. . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "7|. . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "6|. . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "5|. . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "4|. . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "3|. . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "2|. . . . . . . . . . | . . . . . . . . . . |\r\n  " +
                "1|. . . . . . . . . . | . . . . . . . . . . | \r\n  " +
                "0|--------------------+--------------------->\r\n " +
                "-1|. . . . . . . . . . | . . . . . . . . . . |\r\n " +
                "-2|. . . . . . . . . . | . . . . . . . . . . |\r\n " +
                "-3|. . . . . . . . . . | . . . . . . . . . . |\r\n " +
                "-4|. . . . . . . . . . | . . . . . . . . . . |\r\n " +
                "-5|. . . . . . . . . . | . . . . . . . . . . |\r\n " +
                "-6|. . . . . . . . . . | . . . . . . . . . . |\r\n " +
                "-7|. . . . . . . . . . | . . . . . . . . . . |\r\n " +
                "-8|. . . . . . . . . . | . . . . . . . . . . |\r\n " +
                "-9|. . . . . . . . . . | . . . . . . . . . . |\r\n" +
                "-10|. . . . . . . . . . | . . . . . . . . . . |\r\n" +
                "   +------------------------------------------+\r\n " +
                " -10-9-8-7-6-5-4-3-2-1 0 1 2 3 4 5 6 7 8 9 10\r\n");



            //PLACE A
            Console.ForegroundColor = ConsoleColor.Green;//Changes font colour

            Console.SetCursorPosition(((ax + 10) * 2 + 4), ((10 - ay) + 7));
            Console.WriteLine("A");

            //PLACE B
            Console.ForegroundColor = ConsoleColor.Red;

            Console.SetCursorPosition(((bx + 10) * 2 + 4), ((10 - by) + 7));
            Console.WriteLine("B");

            //PLACE C
            Console.SetCursorPosition((cx + 10) * 2 + 4, (10 - cy) + 7);
            Console.WriteLine("C");

            //////////////////////
            Console.SetCursorPosition(0, 31);//Puts the cursor back where it is supposed to be
            Console.ForegroundColor = ConsoleColor.Yellow;//Changes font colour
            Console.ReadKey();
            //////////////////////

            // GAME STARTS FROM NOW ON

            //DISTANCE COMPARISONS

            string r1 = "NO FIGHT";//Tells us which two fighters will fight in round 1
            string r2 = "NO FIGHT";//Tells us which two fighters will fight in round 2

            //For comparison lets start with dab or A vs B
            double min = dab;

            int versus;// Determines the archers who will be figthing in the next round
            versus = 1;// 1 : (A vs B), 2 : (A vs C), 3: (B vs C)


            //Also finds the minimum of three but without Math library
            if (dac <= min)
            {//minimum of dab and dac is the new minimum
                min = dac;
                versus = 2;//A vs C
            }
            if (dbc <= min)
            {//minimum of dbc and the old minimum is the new minimum
                min = dbc;
                versus = 3;//B vs C
            }


            if (versus == 1)// Takes the versus value changes it to string accordingly for scoreboard.
            {
                r1 = "A vs B";
            }
            else if (versus == 2)
            {
                r1 = "A vs C";
            }
            else if (versus == 3)
            {
                r1 = "B vs C";
            }

            if (min > 15)// Check for reach (distance<15)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[NO FIGHT] : ARCHERS TOO DISTANT");
                Console.ForegroundColor = ConsoleColor.Yellow;//Changes font colour
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("[ROUND 1] : ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(r1);
                Console.ForegroundColor = ConsoleColor.Yellow;//Changes font colour
                Console.ReadKey();

                if (versus == 1)
                {
                    if (randSet == 1 || randSet == 4 || randSet == 5)
                    {
                        aHP = aHP - 25;
                        bHP = 0;
                        aScore = aScore + (10 * mandab + (100 - aHP));
                        a1State = "SURVIVOR";
                        b1State = "DEFEATED";
                        c1State = "NON-FIGHTER";
                        b2State = "DEFEATED";
                        versus = 2;//A vs C
                        min = dac;
                    }
                    else
                    {
                        bHP = bHP - 25;
                        aHP = 0;
                        bScore = bScore + (10 * mandab + (100 - bHP));
                        b1State = "SURVIVOR";
                        a1State = "DEFEATED";
                        c1State = "NON-FIGHTER";
                        a2State = "DEFEATED";
                        versus = 3;//B vs C
                        min = dbc;
                    }
                }
                else if (versus == 2)
                {
                    if (randSet == 2 || randSet == 3 || randSet == 6)
                    {
                        aHP = aHP - 25;
                        cHP = 0;
                        aScore = aScore + (10 * mandac + (100 - aHP));
                        a1State = "SURVIVOR";
                        c1State = "DEFEATED";
                        b1State = "NON-FIGHTER";
                        c2State = "DEFEATED";
                        versus = 1;//A vs B
                        min = dab;
                    }
                    else
                    {
                        cHP = cHP - 25;
                        aHP = 0;
                        cScore = cScore + (10 * mandac + (100 - cHP));
                        c1State = "SURVIVOR";
                        a1State = "DEFEATED";
                        b1State = "NON-FIGHTER";
                        a2State = "DEFEATED";
                        versus = 3;//B vs C
                        min = dbc;
                    }
                }
                else if (versus == 3)
                {
                    if (randSet == 1 || randSet == 4 || randSet == 5)
                    {
                        bHP = bHP - 25;
                        cHP = 0;
                        bScore = bScore + (10 * mandbc + (100 - bHP));
                        b1State = "SURVIVOR";
                        c1State = "DEFEATED";
                        a1State = "NON-FIGHTER";
                        c2State = "DEFEATED";
                        versus = 1;//A vs B
                        min = dab;
                    }
                    else
                    {
                        cHP = cHP - 25;
                        bHP = 0;
                        cScore = cScore + (10 * mandbc + (100 - cHP));
                        c1State = "SURVIVOR";
                        b1State = "DEFEATED";
                        a1State = "NON-FIGHTER";
                        b2State = "DEFEATED";
                        versus = 2;//A vs C
                        min = dac;
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }

                

                //////////////////////

                //SCOREBOARD FOR ROUND 1
                Console.WriteLine("\n> A |\t| Score :     |\t| HP :     |\t|               | ");
                Console.WriteLine("> B |\t| Score :     |\t| HP :     |\t|               | ");
                Console.WriteLine("> C |\t| Score :     |\t| HP :     |\t|               | ");

                //A
                Console.SetCursorPosition(18, 33);
                Console.WriteLine(aScore);

                Console.SetCursorPosition(31, 33);
                Console.WriteLine(aHP);

                Console.SetCursorPosition(42, 33);
                Console.WriteLine(a1State);

                //B
                Console.SetCursorPosition(18, 34);
                Console.WriteLine(bScore);

                Console.SetCursorPosition(31, 34);
                Console.WriteLine(bHP);

                Console.SetCursorPosition(42, 34);
                Console.WriteLine(b1State);

                //C
                Console.SetCursorPosition(18, 35);
                Console.WriteLine(cScore);

                Console.SetCursorPosition(31, 35);
                Console.WriteLine(cHP);

                Console.SetCursorPosition(42, 35);
                Console.WriteLine(c1State);

                Console.SetCursorPosition(0, 37);//Puts the cursor back where it is supposed to be

                //////////////////////

                if (versus == 1)// Takes the versus value changes it to string accordingly for scoreboard.
                {
                    r2 = "A vs B";
                }
                else if (versus == 2)
                {
                    r2 = "A vs C";
                }
                else if (versus == 3)
                {
                    r2 = "B vs C";
                }

                if (min > 15)// Check for reach (distance<15)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[NO FIGHT] : ARCHERS TOO DISTANT");
                    Console.ForegroundColor = ConsoleColor.Yellow;//Changes font colour
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("[ROUND 2] : ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(r2);
                    Console.ForegroundColor = ConsoleColor.Yellow;//Changes font colour
                    Console.ReadKey();



                    if(versus == 1)
                    {
                        if(randSet == 1 || randSet == 4 || randSet == 5)
                        {
                            aHP = aHP - 25;
                            bHP = 0;
                            aScore = aScore + (10 * mandab + (100 - aHP));
                            a2State = "SURVIVOR";
                            b2State = "DEFEATED";
                            c2State = "NON-FIGHTER";
                            versus = 2;//A vs C
                        }
                        else
                        {
                            bHP = bHP - 25;
                            aHP = 0;
                            bScore = bScore + (10 * mandab + (100 - bHP));
                            b2State = "SURVIVOR";
                            a2State = "DEFEATED";
                            c2State = "NON-FIGHTER";
                            versus = 3;//B vs C
                        }
                    }
                    else if(versus == 2)
                    {
                        if (randSet == 2 || randSet == 3 || randSet == 6)
                        {
                            aHP = aHP - 25;
                            cHP = 0;
                            aScore = aScore + (10 * mandac + (100 - aHP));
                            a2State = "SURVIVOR";
                            c2State = "DEFEATED";
                            b2State = "NON-FIGHTER";
                            versus = 1;//A vs B
                        }
                        else
                        {
                            cHP = cHP - 25;
                            aHP = 0;
                            cScore = cScore + (10 * mandac + (100 - cHP));
                            c2State = "SURVIVOR";
                            a2State = "DEFEATED";
                            b2State = "NON-FIGHTER";
                            versus = 3;//B vs C
                        }
                    }
                    else if(versus == 3)
                    {
                        if (randSet == 2 || randSet == 3 || randSet == 6)
                        {
                            bHP = bHP - 25;
                            cHP = 0;
                            bScore = bScore + (10 * mandbc + (100 - bHP));
                            b2State = "SURVIVOR";
                            c2State = "DEFEATED";
                            a2State = "NON-FIGHTER";
                            versus = 1;//A vs B
                        }
                        else
                        {
                            cHP = cHP - 25;
                            bHP = 0;
                            cScore = cScore + (10 * mandbc + (100 - cHP));
                            c2State = "SURVIVOR";
                            b2State = "DEFEATED";
                            a2State = "NON-FIGHTER;";
                            versus = 2;//A vs C
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }

            }

            Console.WriteLine("\n> A |\t| Score :     |\t| HP :     |\t|               | ");
            Console.WriteLine("> B |\t| Score :     |\t| HP :     |\t|               | ");
            Console.WriteLine("> C |\t| Score :     |\t| HP :     |\t|               | ");

            Console.SetCursorPosition(18, 39);
            Console.WriteLine(aScore);
            Console.SetCursorPosition(31, 39);
            Console.WriteLine(aHP);
            Console.SetCursorPosition(42, 39);
            Console.WriteLine(a2State);

            Console.SetCursorPosition(18, 40);
            Console.WriteLine(bScore);
            Console.SetCursorPosition(31, 40);
            Console.WriteLine(bHP);
            Console.SetCursorPosition(42, 40);
            Console.WriteLine(b2State);

            Console.SetCursorPosition(18, 41);
            Console.WriteLine(cScore);
            Console.SetCursorPosition(31, 41);
            Console.WriteLine(cHP);
            Console.SetCursorPosition(42, 41);
            Console.WriteLine(c2State);

        
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\tPRESS ANY BUTTON TO END");
            Console.ReadKey();

        }
    }
}
