namespace Calc
{ 
    class Program
    {
        static void Main(string[] args)
         {
              bool showMenu = true;
                 while (showMenu)
                 {
                   showMenu = MainMenu();

                 }
         }

        private static bool MainMenu()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("1)  Calculator");
          
            Console.Write("\n\n");

            Console.WriteLine("s)  Sluta");
            Console.WriteLine(" ");

            Console.Write("\r\nVälj en funktion: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Calculator();
                    return true;
                
                case "s":
                    return false;
                default:
                    return true;
            }

        }

        private static void Calculator()
        {

            bool endCalc = false;

            Console.Clear();
            Console.Write("\n\n");
            Console.WriteLine("Console Calculator\r");
            Console.WriteLine("------------------------\n");
          

            while (!endCalc)
            {
                string Input1 = "";
                string Input2 = "";

                Console.WriteLine("Skriv ett nummer och tryck Enter");
                Input1 = Console.ReadLine();

                double num1 = 0;
                while (!double.TryParse(Input1, out num1))
                {
                    Console.Write("Detta funkar ej. Skriv ett nummer och tryck Enter: ");
                    Input1 = Console.ReadLine();
                }
                
                Console.WriteLine("Skriv ett nummer och tryck Enter");
                Input2 = Console.ReadLine();

                double num2 = 0;
                while (!double.TryParse(Input2, out num2))
                {
                    Console.Write("Detta funkar ej. Skriv ett nummer och tryck Enter: ");
                    Input2 = Console.ReadLine();
                }
               
                Console.WriteLine("Välj operator:");
                Console.WriteLine("\t+ - Add");
                Console.WriteLine("\t- - Subtract");
                Console.WriteLine("\t* - Multiply");
                Console.WriteLine("\t/ - Divide");
                Console.Write("Your option? ");

              
                static double Addition(double x,double y)
                    {
                        return x + y;
                    }

                static double Subtraction(double x, double y)
                    {
                        return x - y;
                    }
                static double Multiplication(double x, double y)
                    {
                        return x * y;
                    }
                static double Division(double x, double y)
                    {
                        return x / y;
                    }

                
                switch (Console.ReadLine())
                {

                    case "+":
                        Console.WriteLine("Resultatet blir: " + Addition(num1, num2));
                        break;
                    case "-":
                        Console.WriteLine("Resultatet blir: " + Subtraction(num1, num2));
                        break;
                    case "*":
                        Console.WriteLine("Resultatet blir: " + Multiplication(num1, num2));
                        break;
                    case "/":
                        while (num2 == 0)
                        {
                            Console.WriteLine("Försök inte dela med 0, det blir alltid 0!: ");
                            Console.WriteLine("Skriv ett nummer och tryck Enter:  ");
                            Input2 = Console.ReadLine();

                            while (!double.TryParse(Input2, out num2))
                            {
                                Console.Write("Detta funkar ej. Skriv ett nummer och tryck Enter: ");
                                Input2 = Console.ReadLine();
                            }
                        }
                        Console.WriteLine("Resultatet blir: " + Division(num1, num2));
                        break;
                    default:
                        Console.Write("\n\n");
                        Console.WriteLine("Välj operator nästa gång! ");
                        break;
                }

                Console.Write("\n\n");
                Console.Write("Tryck s + Enter för att avsluta, eller Enter för att fortsätta: ");
                Console.Write("\n\n");
                if (Console.ReadLine() == "s") endCalc = true;
                

            }
           
        }

    }
}