using System;

namespace SimpleCalculator{
    class Program{
        
        static void Main(String[] args) {
            
            double operande1 = 0.0, operande2 = 0.0, result = 0.0;
            int state;

            state = 0;
            do{
                Console.WriteLine("-------------- SimpleCalculator --------------");
                switch (state) {
                    case 0:
                        Console.WriteLine("Initialising Simple Calculator!");
                        operande1 = 0.0; // Variable that will contain first operand value.
                        operande2 = 0.0; // Variable that will contain second operand value.
                        result = 0.0; // Variable that will contain the result of the operation.
                        state = 1;
                        break;
                    case 1: // Getting inputs
                        Console.WriteLine("Getting user inputs!");
                        
                        Console.WriteLine("Enter first operand: ");
                        string str1 = Console.ReadLine();
                        if (!Double.TryParse(str1, out operande1)) {
                            Console.WriteLine("Error: Enter a numerical value!");
                            state = 4; // We stop the application.
                        }
                        Console.WriteLine("Enter second operand: ");
                        string str2 = Console.ReadLine();
                        if (!Double.TryParse(str2, out operande2)) {
                            Console.WriteLine("Error: Enter a numerical value!");
                            state = 4; // We stop the program.
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
                        Console.WriteLine("You choose: " + s.ToLower());
                        s = s.ToLower();
                        switch (s)
                        {
                            case "add": case "+":
                                result = operande1 + operande2;
                                Console.WriteLine("Result : " + operande1 + " + " + operande2 + " = " + result);
                                break;

                            case "sub": case "-":
                                result = operande1 - operande2;
                                Console.WriteLine("Result : " + operande1 + " - " + operande2 + " = " + result);
                                break;

                            case "mul": case "*":
                                result = operande1 * operande2;
                                Console.WriteLine("Result : " + operande1 + " * " + operande2 + " = " + result);
                                break;

                            case "div": case "/":
                                if (operande2 == 0) {
                                    Console.WriteLine("Math Error! Division by Zero not permitted!");
                                    state = 4; // We stop the application if second operator (denominator) equals zero
                                    break;
                                } else {
                                    result = operande1 / operande2;
                                    Console.WriteLine("Result : " + operande1 + " / " + operande2 + " = " + result);
                                    break;
                                }
                                
                            default:
                                Console.WriteLine("Error! No such operator! Please Typed an operator from the given list.");
                                break;
                        }
                        state = 3;
                        break;
                    case 3: // Setting all variable to a null value;.
                        Console.WriteLine("Seeting every thing to null!");
                        operande1 = 0.0;
                        operande2 = 0.0;
                        result = 0.0;
                        
                        Console.WriteLine("Will you wish to continue? # y > YES # n > NO");
                        char c = Convert.ToChar(Console.ReadLine());
                        if ( c == 'y' ) {
                            Console.WriteLine("You will continue!");
                            state = 0;
                        } 
                        if ( c == 'n' ) {
                            Console.WriteLine("You will stop the program!");
                            state = 4;
                        }
                        if ( c != 'n' && c != 'y') {
                            Console.WriteLine("Unknow choice!");
                            state = 4;
                        }
                        
                        break;
                    
                    default:
                        Console.WriteLine("No such state!");
                        break;
                }
            } while(state != 4);

            Console.WriteLine("Bye Bye!!!");
        }
    }
}

