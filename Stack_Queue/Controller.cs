using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

namespace Lantz_assignment_4
{
    class Controller
    {
        public void RunProgram()
        {
            int choice, input;
            string typeOfArray = " "; //Queue or stack
            string stackMenu = "1. Add to the stack\n " +
                            "2. Pop from the stack\n " +
                            "3. Peek at the top element\n" +
                            "4. Display entire stack\n" +
                            "5. Number of elements in the stack\n";

            Stack stack = new();
            View view = new();
            Queue q = new();
            
            
            
                try
            {       //First we ask the user what type of array to create: stack/queue
                    choice = view.GetArrayType();

                while (true)
                    {
                        

                  

                    if (choice == 1) 
                        {
                            typeOfArray = "stack";
                        
                        }
                        if (choice == 2)
                        {
                            typeOfArray = "queue";
                        
                        }

                        
                    if (choice == 6)
                        {
                            WriteLine("Goodbye...");
                            break;
                        }
                    Console.WriteLine(choice);

                        switch (view.SelectMenu(choice))
                        {
                            case 1:
                            WriteLine("What would you like to put on the {0}?\n", typeOfArray);
                            input = Convert.ToInt32(ReadLine());
                            
                            switch (choice)
                            {
                                case 1:
                                    WriteLine("got to nested switch!");
                                    //stack.Push(input);
                                    break;

                                                   
                            }
                            break;

                            case 2:
                                choice = stack.Pop();
                                WriteLine("You popped " + choice + " off the stack\n");
                                break;

                            case 3:
                                WriteLine("You peeked at the top element which is: " + stack.Peek() + "\n");
                                break;

                            case 4:
                                stack.Display();
                                WriteLine();
                                break;

                            case 5:
                                WriteLine("Your stack has " + stack.Size() + " elements\n");
                                break;

                            default:
                                WriteLine("Goodbye");
                                break;

                        }
                    }//End of while
                }
                catch (Exception ex)
                {
                    WriteLine("An error has occured.\n" + ex.Message + "\n" + ex.StackTrace);
                WriteLine("Broke it");
                Read();
                }


            WriteLine("Broke out the while");
            Read();
        }//End of RunProgram
    }//End of class
}
