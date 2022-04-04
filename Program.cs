using System;

namespace SimpleCalculator{
    class Program{
        static void Main(String[] args) {
            
            int state = 0;
            do{
                switch (state) {
                    case 0:
                        Console.WriteLine("case 0");
                        double operande1 = 0.0, operande2 = 0.0, result = 0.0;
                        string operateur = "";
                        state = 1;
                        break;
                    case 1:
                        Console.WriteLine("case 1!");
                        state = 2;
                        break;
                    case 2:
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

