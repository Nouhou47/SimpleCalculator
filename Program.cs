using System;

namespace SimpleCalculator{
    class Program{
        static void Main(String[] args) {
            
            int state = 0;
            do{
                switch (state) {
                    case 0:
                        Console.WriteLine("Initialising Simple Calculator!");
                        double operande1 = 0.0, operande2 = 0.0, result = 0.0;
                        string operateur = "";
                        state = 1;
                        break;
                    case 1: // Getting inputs
                        Console.WriteLine("Getting user inputs!");
                        
                        Console.WriteLine("Enter first operand: ");
                        string str1 = Console.ReadLine();
                        if (!Double.TryParse(str1, out operande1)) {
                            Console.WriteLine("Error: Enter a numerical value!");
                            state = 5; // We stop the application.
                        }
                        Console.WriteLine("Enter second operand: ");
                        string str2 = Console.ReadLine();
                        if (!Double.TryParse(str2, out operande2)) {
                            Console.WriteLine("Error: Enter a numerical value!");
                            state = 5; // We stop the application.
                        }
                        state = 2;
                        break;
                    case 2: // Choose the operator to apply: + or - or * or /
                        Console.WriteLine("case 2!");
                        state = 3;
                        break;
                    case 3:
                        Console.WriteLine("case 3!");
                        state = 4;
                        break;
                    case 4:
                        Console.WriteLine("case 4!");
                        state = 5;
                        break;
                    default:
                        Console.WriteLine("default case");
                        break;
                }
            } while(state != 5);

            Console.WriteLine("Hello C#");
        }
    }
}

