using System;

namespace archer
{
    internal class Program
    {
        static void Main(string[] args)
        {

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

            //COORDINATES
            int ax = 0, ay = 0;// A(x,y)
            int bx = 0, by = 0;// B(x,y)
            int cx = 0, cy = 0;// C(x,y)

            //COORDINATES OF A
            Console.WriteLine("Enter X:");
            //ax = Convert.ToInt32(Console.ReadLine());
            
            tempx = Console.ReadLine();
            bool checkx = int.TryParse(tempx,out ax);

            
            Console.WriteLine("Enter Y:");
            //ay = Convert.ToInt32(Console.ReadLine());
            
            tempy = Console.ReadLine();
            bool checky = int.TryParse(tempy, out ay);

            if (checkx == true && checky == true)
            {
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("monkey see, monkey do");
                Console.ReadKey();
                return;
            }

            if(ax<-10 || ax > 10)
            {
                Console.WriteLine("X and Y values should be between -10 and 10.");
                return;
            }

            if (ay < -10 || ay > 10)
            {
                Console.WriteLine("X and Y values should be between -10 and 10.");
                return;
            }

            //COORDINATES OF B AND C
            bx = rnd.Next(-10, 10);
            by = rnd.Next(-10, 10);
            cx = rnd.Next(-10, 10);
            cy = rnd.Next(-10, 10);
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
            randHP = rnd.Next(1, 6);// There are 6 posible permutations for HP for the values {60,80,100}

            switch (randHP)// Takes the random value 1 through 6 then assigns values accordingly
            {
                case 1:
                    aHP = 60;
                    bHP = 80;
                    cHP = 100;
                    break;
                case 2:
                    aHP = 60;
                    bHP = 100;
                    cHP = 80;
                    break;
                case 3:
                    aHP = 80;
                    bHP = 60;
                    cHP = 100;
                    break;
                case 4:
                    aHP = 80;
                    bHP = 100;
                    cHP = 60;
                    break;
                case 5:
                    aHP = 100;
                    bHP = 60;
                    cHP = 80;
                    break;
                case 6:
                    aHP = 100;
                    bHP = 80;
                    cHP = 60;
                    break;
            }

            //////////////////////
            //////////////////////

            //SETS

            int aSet = 0, bSet = 0, cSet = 0;// Types of set (Arrow and Shields) A, B and C use


            int randSet = 0;// This is for assigning random values of sets to A, B and C without repetition
            randSet = rnd.Next(1, 6);//Just like HP there are 6 permutations for sets {1,2,3}

            switch (randSet)// Takes the random value 1 through 6 then assigns values accordingly
            {
                case 1:
                    aSet = 1;
                    bSet = 2;
                    cSet = 3;
                    break;
                case 2:
                    aSet = 1;
                    bSet = 3;
                    cSet = 2;
                    break;
                case 3:
                    aSet = 2;
                    bSet = 1;
                    cSet = 3;
                    break;
                case 4:
                    aSet = 2;
                    bSet = 3;
                    cSet = 1;
                    break;
                case 5:
                    aSet = 3;
                    bSet = 1;
                    cSet = 2;
                    break;
                case 6:
                    aSet = 3;
                    bSet = 2;
                    cSet = 1;
                    break;
            }



            //////////////////////
            //////////////////////

            Console.Clear();

            //INFO FOR PLAYERS
            Console.WriteLine("The ARCHER");
            Console.WriteLine("A( " + (ax) + " , " + (ay) + " ) " + "\t HP : " + aHP + "\tSET : " + aSet);
            Console.WriteLine("B( " + bx + " , " + by + " ) " + "\t HP : " + bHP + "\tSET : " + bSet);
            Console.WriteLine("C( " + cx + " , " + cy + " ) " + "\t HP : " + cHP + "\tSET : " + cSet);

            

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

            //PLACE A
            Console.SetCursorPosition(ax + 14, 15 - ay);
            Console.WriteLine("A");
            //PLACE B
            Console.SetCursorPosition(bx + 14, 15 - by);
            Console.WriteLine("B");
            //PLACE C
            Console.SetCursorPosition(cx + 14, 15 - cy);
            Console.WriteLine("C");

            Console.SetCursorPosition(0, 28);

            Console.ReadKey();

            //////////////////////
            //////////////////////

            // GAME STARTS FROM NOW ON

            //DISTANCE COMPARISONS

            //double min = Math.Min(dab, Math.Min(dac, dbc));// Finds the minimum of dab, dac and dbc



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

            switch (versus)// Takes the versus value changes it to string accordingly for display purposes.
            {
                case 1:
                    r1 = "A vs B";
                    break;
                case 2:
                    r1 = "A vs C";
                    break;
                case 3:
                    r1 = "B vs C";
                    break;
            }


            if (min > 15)// Check for reach (distance<15)
            {
                Console.WriteLine("NO FIGHT\nARCHERS TOO DISTANT");
            }
            else
            {
                Console.WriteLine("ROUND 1 :\t" + r1);
                switch (versus)
                {
                    case 1://A VS B
                        switch (randSet)
                        {
                            case 1://A WINS
                                aHP = aHP - 25;
                                bHP = 0;
                                aScore = aScore + (10 * mandab + (100 - aHP));
                                a1State = "SURVIVOR";
                                b1State = "DEFEATED";
                                c1State = "NON-FIGHTER";
                                b2State = "DEFEATED";
                                versus = 2;//A vs C
                                min = dac;
                                break;
                            case 4://A WINS
                                aHP = aHP - 25;
                                bHP = 0;
                                aScore = aScore + (10 * mandab + (100 - aHP));
                                a1State = "SURVIVOR";
                                b1State = "DEFEATED";
                                c1State = "NON-FIGHTER";
                                b2State = "DEFEATED";
                                versus = 2;//A vs C
                                min = dac;
                                break;
                            case 5://A WINS
                                aHP = aHP - 25;
                                bHP = 0;
                                aScore = aScore + (10 * mandab + (100 - aHP));
                                a1State = "SURVIVOR";
                                b1State = "DEFEATED";
                                c1State = "NON-FIGHTER";
                                b2State = "DEFEATED";
                                versus = 2;//A vs C
                                min = dac;
                                break;
                            default://B WINS
                                bHP = bHP - 25;
                                aHP = 0;
                                bScore = bScore + (10 * mandab + (100 - bHP));
                                b1State = "SURVIVOR";
                                a1State = "DEFEATED";
                                c1State = "NON-FIGHTER";
                                a2State = "DEFEATED";
                                versus = 3;//B vs C
                                min = dbc;
                                break;
                        }
                        break;
                    case 2://A VS C
                        switch (randSet)
                        {
                            case 2://A WINS
                                aHP = aHP - 25;
                                cHP = 0;
                                aScore = aScore + (10 * mandac + (100 - aHP));
                                a1State = "SURVIVOR";
                                c1State = "DEFEATED";
                                b1State = "NON-FIGHTER";
                                c2State = "DEFEATED";
                                versus = 1;//A vs B
                                min = dab;
                                break;
                            case 3://A WINS
                                aHP = aHP - 25;
                                cHP = 0;
                                aScore = aScore + (10 * mandac + (100 - aHP));
                                a1State = "SURVIVOR";
                                c1State = "DEFEATED";
                                b1State = "NON-FIGHTER";
                                c2State = "DEFEATED";
                                versus = 1;//A vs B
                                min = dab;
                                break;
                            case 6://A WINS
                                aHP = aHP - 25;
                                cHP = 0;
                                aScore = aScore + (10 * mandac + (100 - aHP));
                                a1State = "SURVIVOR";
                                c1State = "DEFEATED";
                                b1State = "NON-FIGHTER";
                                c2State = "DEFEATED";
                                versus = 1;//A vs B
                                min = dab;
                                break;
                            default://C WINS
                                cHP = cHP - 25;
                                aHP = 0;
                                cScore = cScore + (10 * mandac + (100 - cHP));
                                c1State = "SURVIVOR";
                                a1State = "DEFEATED";
                                b1State = "NON-FIGHTER";
                                a2State = "DEFEATED";
                                versus = 3;//B vs C
                                min = dbc;
                                break;
                        }
                        break;
                    case 3://B VS C
                        switch (randSet)
                        {
                            case 1://B WINS
                                bHP = bHP - 25;
                                cHP = 0;
                                bScore = bScore + (10 * mandbc + (100 - bHP));
                                b1State = "SURVIVOR";
                                c1State = "DEFEATED";
                                a1State = "NON-FIGHTER";
                                c2State = "DEFEATED";
                                versus = 1;//A vs B
                                min = dab;
                                break;
                            case 4://B WINS
                                bHP = bHP - 25;
                                cHP = 0;
                                bScore = bScore + (10 * mandbc + (100 - bHP));
                                b1State = "SURVIVOR";
                                c1State = "DEFEATED";
                                a1State = "NON-FIGHTER";
                                c2State = "DEFEATED";
                                versus = 1;//A vs B
                                min = dab;
                                break;
                            case 5://B WINS
                                bHP = bHP - 25;
                                cHP = 0;
                                bScore = bScore + (10 * mandbc + (100 - bHP));
                                b1State = "SURVIVOR";
                                c1State = "DEFEATED";
                                a1State = "NON-FIGHTER";
                                c2State = "DEFEATED";
                                versus = 1;//A vs B
                                min = dab;
                                break;
                            default://C WINS
                                cHP = cHP - 25;
                                bHP = 0;
                                cScore = cScore + (10 * mandbc + (100 - cHP));
                                c1State = "SURVIVOR";
                                b1State = "DEFEATED";
                                a1State = "NON-FIGHTER";
                                b2State = "DEFEATED";
                                versus = 2;//A vs C
                                min = dac;
                                break;
                        }

                        break;

                }

                
                Console.WriteLine("A |\t Score : " + aScore + "\t HP : " + aHP + " \t | " + a1State);
                Console.WriteLine("B |\t Score : " + bScore + "\t HP : " + bHP + " \t | " + b1State);
                Console.WriteLine("C |\t Score : " + cScore + "\t HP : " + cHP + " \t | " + c1State);

                switch (versus)// Takes the versus value changes it to string accordingly for display purposes.
                {
                    case 1:
                        r2 = "A vs B";
                        break;
                    case 2:
                        r2 = "A vs C";
                        break;
                    case 3:
                        r2 = "B vs C";
                        break;
                }

                if (min > 15)// Check for reach (distance<15)
                {
                    Console.WriteLine("NO FIGHT\nARCHERS TOO DISTANT");
                }
                else
                {
                    Console.WriteLine("ROUND 2 :\t" + r2);
                    switch (versus)//ROUND 2
                    {
                        case 1://A VS B
                            switch (randSet)
                            {
                                case 1://A WINS
                                    aHP = aHP - 25;
                                    bHP = 0;
                                    aScore = aScore + (10 * mandab + (100 - aHP));
                                    a2State = "SURVIVOR";
                                    b2State = "DEFEATED";
                                    c2State = "NON-FIGHTER";
                                    versus = 2;//A vs C
                                    break;
                                case 4://A WINS
                                    aHP = aHP - 25;
                                    bHP = 0;
                                    aScore = aScore + (10 * mandab + (100 - aHP));
                                    a2State = "SURVIVOR";
                                    b2State = "DEFEATED";
                                    c2State = "NON-FIGHTER";
                                    versus = 2;//A vs C
                                    break;
                                case 5://A WINS
                                    aHP = aHP - 25;
                                    bHP = 0;
                                    aScore = aScore + (10 * mandab + (100 - aHP));
                                    a2State = "SURVIVOR";
                                    b2State = "DEFEATED";
                                    c2State = "NON-FIGHTER";
                                    versus = 2;//A vs C
                                    break;
                                default://B WINS
                                    bHP = bHP - 25;
                                    aHP = 0;
                                    bScore = bScore + (10 * mandab + (100 - bHP));
                                    b2State = "SURVIVOR";
                                    a2State = "DEFEATED";
                                    c2State = "NON-FIGHTER";
                                    versus = 3;//B vs C
                                    break;
                            }
                            break;
                        case 2://A VS C
                            switch (randSet)
                            {
                                case 2://A WINS
                                    aHP = aHP - 25;
                                    cHP = 0;
                                    aScore = aScore + (10 * mandac + (100 - aHP));
                                    a2State = "SURVIVOR";
                                    c2State = "DEFEATED";
                                    b2State = "NON-FIGHTER";
                                    versus = 1;//A vs B
                                    break;
                                case 3://A WINS
                                    aHP = aHP - 25;
                                    cHP = 0;
                                    aScore = aScore + (10 * mandac + (100 - aHP));
                                    a2State = "SURVIVOR";
                                    c2State = "DEFEATED";
                                    b2State = "NON-FIGHTER";
                                    versus = 1;//A vs B
                                    break;
                                case 6://A WINS
                                    aHP = aHP - 25;
                                    cHP = 0;
                                    aScore = aScore + (10 * mandac + (100 - aHP));
                                    a2State = "SURVIVOR";
                                    b2State = "NON-FIGHTER";
                                    c2State = "DEFEATED";
                                    versus = 1;//A vs B
                                    break;
                                default://C WINS
                                    cHP = cHP - 25;
                                    aHP = 0;
                                    cScore = cScore + (10 * mandac + (100 - cHP));
                                    c2State = "SURVIVOR";
                                    a2State = "DEFEATED";
                                    b2State = "NON-FIGHTER";
                                    versus = 3;//B vs C
                                    break;
                            }
                            break;
                        case 3://B VS C
                            switch (randSet)
                            {
                                case 1://B WINS
                                    bHP = bHP - 25;
                                    cHP = 0;
                                    bScore = bScore + (10 * mandbc + (100 - bHP));
                                    b2State = "SURVIVOR";
                                    c2State = "DEFEATED";
                                    a2State = "NON-FIGHTER";                                    
                                    versus = 1;//A vs B
                                    break;
                                case 4://B WINS
                                    bHP = bHP - 25;
                                    cHP = 0;
                                    bScore = bScore + (10 * mandbc + (100 - bHP));
                                    b2State = "SURVIVOR";
                                    c2State = "DEFEATED";
                                    a2State = "NON-FIGHTER";
                                    versus = 1;//A vs B
                                    break;
                                case 5://B WINS
                                    bHP = bHP - 25;
                                    cHP = 0;
                                    bScore = bScore + (10 * mandbc + (100 - bHP));
                                    b2State = "SURVIVOR";
                                    c2State = "DEFEATED";
                                    a2State = "NON-FIGHTER";
                                    versus = 1;//A vs B
                                    break;
                                default://C WINS
                                    cHP = cHP - 25;
                                    bHP = 0;
                                    cScore = cScore + (10 * mandbc + (100 - cHP));
                                    c2State = "SURVIVOR";
                                    b2State = "DEFEATED";
                                    a2State = "NON-FIGHTER;";
                                    versus = 2;//A vs C
                                    break;
                            }

                            break;

                    }

                    switch (versus)// Takes the versus value changes it to string accordingly for display purposes.
                    {
                        case 1:
                            r2 = "A vs B";
                            break;
                        case 2:
                            r2 = "A vs C";
                            break;
                        case 3:
                            r2 = "B vs C";
                            break;
                    }




                }


            }
            
            Console.WriteLine("A |\t Score : " + aScore + "\t HP : " + aHP + "\t | " + a2State);
            Console.WriteLine("B |\t Score : " + bScore + "\t HP : " + bHP + "\t | " + b2State);
            Console.WriteLine("C |\t Score : " + cScore + "\t HP : " + cHP + "\t | " + c2State);
        }
    }
}
