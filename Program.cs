using System;

namespace SimpleCalculator{
    class Program{
        
        static void Main(String[] args) {
            
            double operande1 = 0.0, operande2 = 0.0, result = 0.0;
            string operateur;
            int state;

            state = 0;
            do{
                switch (state) {
                    case 0:
                        Console.WriteLine("Initialising Simple Calculator!");
                        operande1 = 0.0; // Variable that will contain first operand value.
                        operande2 = 0.0; // Variable that will contain second operand value.
                        result = 0.0; // Variable that will contain the result of the operation.
                        operateur = ""; // Variable that will be used to swith between operators.
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
                    case 2: 
                    /** The most complex state!
                     *  Choose the operator to apply: + or - or * or /.
                     *  Processing operation.
                     *  Displaying result to standard output.
                     */
                        Console.WriteLine("Case 2: Choose an operator to apply to operands!");

                        Console.WriteLine("# For Addition >> ADD or +\n# For Substraction >> SUB or -\n# For Multiplication >> MUL or *\n# For Division >> DIV or /");
                        
                        string s = Console.ReadLine();
                        Console.WriteLine("You wrote: " + s.ToLower());
                        s = s.ToLower();
                        switch (s)
                        {
                            case "add": case "+":
                                result = operande1 + operande2;
                                break;

                            case "sub": case "-":
                                result = operande1 - operande2;
                                break;

                            case "mul": case "*":
                                result = operande1 * operande2;
                                break;

                            case "div": case "/":
                                if (operande2 == 0) {
                                    Console.WriteLine("Math Error! Division by Zero not permitted!");
                                    state = 5; // We stop the application if second operator (denominator) equals zero
                                    break;
                                } else {
                                    result = operande1 / operande2;
                                    break;
                                }
                                break;
                            default:
                                Console.WriteLine("Error! No such operator! Please Typed an operator from the given list.");
                                break;
                        }
                        state = 3;
                        break;
                    case 3: // Displaying result of th operation to stabdard output.
                        Console.WriteLine("case 3!");
                        state = 4;
                        break;
                    
                    default:
                        Console.WriteLine("No such state!");
                        break;
                }
            } while(state != 5);

            Console.WriteLine("Hello C#");
        }
    }
}

