namespace specialCalculator
{
    internal class SpecialCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for normal and 2 for opposite calculator");
            int CalculatorChoice = Convert.ToInt32(Console.ReadLine());
            if(CalculatorChoice == 1 ) 
            {
                Console.WriteLine("You want to calculate for 2 or 3 numbers");
                int NumbersToCalc = Convert.ToInt32(Console.ReadLine());
                if (NumbersToCalc == 2)
                {
                    Console.WriteLine("Enter the numbers to calculate");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Choose 1 for Normal ADDITIOM of 2 numbers");
                    Console.WriteLine("Choose 2 for Normal SUBTRACTION of 2 numbers");


                    int AddOrSub = Convert.ToInt32(Console.ReadLine());
                    if (AddOrSub == 1)
                    {
                        NormalCalc.twoNumNormalAddition(num1, num2);
                    }
                    else if (AddOrSub == 2)
                    {
                        NormalCalc.twoNumNormalSubtraction(num1, num2);
                    }

                }
                else if (NumbersToCalc == 3)
                {
                    Console.WriteLine("Enter the three numbers to calculate");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int num3 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Choose 1 for Normal addition of 3 numbers");
                    Console.WriteLine("Choose 2 for Normal subtraction of 3 numbers");

                    int AddOrSub = Convert.ToInt32(Console.ReadLine());

                    if (AddOrSub == 1)
                    {
                        NormalCalc.threeNumNormalAddition(num1, num2, num3);
                    }
                    else if (AddOrSub == 2)
                    {
                        NormalCalc.threeNumNormalSubtraction(num1, num2, num3);
                    }

                }
            }
            else if(CalculatorChoice == 2) 
            {
                Console.WriteLine("You want to calculate for 2 or 3 numbers");
                int NumbersToCalc = Convert.ToInt32(Console.ReadLine());
                if (NumbersToCalc == 2)
                {
                    Console.WriteLine("Enter the numbers to calculate");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Choose 1 for Opp ADDITIOM of 2 numbers");
                    Console.WriteLine("Choose 2 for Opp SUBTRACTION of 2 numbers");


                    int AddOrSub = Convert.ToInt32(Console.ReadLine());
                    if (AddOrSub == 1)
                    {
                        OppositeCalc.twoNumOppAddition(num1, num2);
                    }
                    else if (AddOrSub == 2)
                    {
                        OppositeCalc.twoNumOppSubtraction(num1, num2);
                    }

                }
                else if (NumbersToCalc == 3)
                {
                    Console.WriteLine("Enter the three numbers to calculate");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int num3 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Choose 1 for Normal addition of 3 numbers");
                    Console.WriteLine("Choose 2 for Normal subtraction of 3 numbers");

                    int AddOrSub = Convert.ToInt32(Console.ReadLine());

                    if (AddOrSub == 1)
                    {
                        OppositeCalc.threeNumOppAddition(num1, num2, num3);
                    }
                    else if (AddOrSub == 2)
                    {
                        OppositeCalc.threeNumOppSubtraction(num1, num2, num3);
                    }

                }
            }
            



        }
        public class NormalCalc
        {
            public static void twoNumNormalAddition(int a, int b)
            {
                Console.WriteLine($"Result of {a} + {b} is {a + b}");
            }

            public static void threeNumNormalAddition(int a, int b, int c)
            {
                Console.WriteLine($"Result of {a} + {b}+ {c} is {a + b + c}");
            }
            public static void twoNumNormalSubtraction(int a, int b)
            {
                Console.WriteLine($"Result of {a} - {b} is {a - b}");
            }
            public static void threeNumNormalSubtraction(int a, int b, int c)
            {
                Console.WriteLine($"Result of {a} - {b} - {c} is {a - b - c}");
            }
        }

        public class OppositeCalc
        {
            public static void twoNumOppAddition(int a, int b)
            {
                Console.WriteLine($"Opposite Result of {a} + {b} is {a - b}");
            }

            public static void threeNumOppAddition(int a, int b, int c)
            {
                Console.WriteLine($"Opposite Result of {a} + {b}+ {c} is {a - b - c}");
            }
            public static void twoNumOppSubtraction(int a, int b)
            {
                Console.WriteLine($"Opposite Result of {a} - {b} is {a + b}");
            }
            public static void threeNumOppSubtraction(int a, int b, int c)
            {
                Console.WriteLine($"Opposite Result of {a} - {b} - {c} is {a + b + c}");
            }
        }

        



    }
}