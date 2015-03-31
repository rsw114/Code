using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[,] names = new string[20, 2]; // 2D array for first and last name
            string[] phoneNumbers = new string[20];   // array for phone numbers
            string iBoxNum, firstName, surname;
            char menuChoice, overwrite;
            int box;

            Populate(ref names, ref phoneNumbers);
            Console.WriteLine("Welcome to the 20 number phonebook.");
            Console.WriteLine("Please choose from the following options.\n\n");
            do
            {
                Console.WriteLine("Press 1 to add an entry to the phone book.");
                Console.WriteLine("Press 2 to display names and numbers you have entered.");
                Console.WriteLine("Press 3 to display all 20 records.");
                Console.WriteLine("Press 4 to delete an entry.");
                Console.WriteLine("Press 5 to delete all records.");
                Console.WriteLine("Press 6 to search for a phone number.");
                Console.WriteLine("Press q to quit.");
                var choice = Console.ReadKey();
                menuChoice = Convert.ToChar(choice.KeyChar); //Char converted from read key statement
                Console.Write("\n\n\n");
                switch (menuChoice)
                {
                    case '1': // add entry
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Choose a box number to populate.");
                                Console.WriteLine("Enter a number from 0 to 19.");
                                iBoxNum = Console.ReadLine();
                                NumCheck(ref iBoxNum);
                                BoxCheck(ref iBoxNum);
                                box = Convert.ToInt32(iBoxNum);
                                if ((names[box, 0] != "xx") || (names[box,1] != "yy") || (phoneNumbers[box] != "00")) // check for overwrite
                                {
                                    do
                                    {
                                        Console.WriteLine("This field is already populated, do you really want to overwrite?");
                                        choice = Console.ReadKey();
                                        overwrite = Convert.ToChar(choice.KeyChar);
                                        YesNo(ref overwrite);

                                    }
                                    while ((overwrite != 'y') && (overwrite != 'n'));

                                    if (overwrite == 'y')
                                    {
                                        AddEntry(box, ref names, ref phoneNumbers);
                                    }

                                    if (overwrite == 'n')
                                    {
                                        Console.WriteLine("No selected please choose another box number");
                                                                            }
                                    }

                                if ((names[box, 0] == "xx") && (names[box,1] =="yy") && (phoneNumbers[box] == "00"))
                                {

                                    AddEntry(box, ref names, ref phoneNumbers);
                                }

                                Console.WriteLine("Would you like to add another entry?");
                                choice = Console.ReadKey();
                                menuChoice = Convert.ToChar(choice.KeyChar);
                                YesNo(ref menuChoice);

                            }
                            while (menuChoice == 'y');
                            Console.Clear();
                            break;
                        }
                            
                    case '2': // display populated fields
                        {
                            Console.Clear();
                            for (int i = 0; i < 20; i++)
                            {
                                if ((names[i, 0] != "xx") || (names[i,1] != "yy") || (phoneNumbers[i] != "00"))
                                {
                                    Console.WriteLine("Record " + i + " is\t" + names[i, 0] + "\t" + names[i, 1] + "\t"+phoneNumbers[i]);
                                                                                                           
                                }
                                
                            }
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                    case '3': // display all fields
                        {
                            Console.Clear();
                            for (int i = 0; i < 20; i++)
                            {
                                Console.WriteLine(i + "\t" +names[i,0]+"\t"+names[i,1]+"\t"+phoneNumbers[i]);
                            }
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case '4': // delete field
                        {
                            Console.Clear();
                            do
                            {
                                Console.WriteLine("Please enter the box number you wish to delete");
                                Console.WriteLine("Enter a number from 0 to 19");
                                iBoxNum = Console.ReadLine();
                                NumCheck(ref iBoxNum);
                                BoxCheck(ref iBoxNum);
                                box = Convert.ToInt32(iBoxNum);
                                names[box, 0] = "xx";
                                names[box, 1] = "yy";
                                phoneNumbers[box] = "00";
                                Console.WriteLine("The name in box number " + box + " has now been changed to " + names[box, 0] + " " + names[box, 1]);
                                Console.WriteLine("The phone number has been changed to " + phoneNumbers[box]);
                                Console.WriteLine("Do you want to delete another field?");
                                Console.WriteLine("Press 'y' for yes or 'n' for no");
                                choice = Console.ReadKey();
                                menuChoice = Convert.ToChar(choice.KeyChar);
                                YesNo(ref menuChoice);
                                if (menuChoice == 'n')
                                {
                                    Console.WriteLine("\nNo selected, press enter to return to the main menu.");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            while (menuChoice == 'y');
                            break;
                        }
                    case '5': // Delete all records
                        {
                            Console.Clear();
                            do
                            {
                                Console.WriteLine("Are you really sure you want to delete all the records?");
                                Console.WriteLine("If yes press 'y' if not then press 'n'");
                                choice = Console.ReadKey();
                                menuChoice = Convert.ToChar(choice.KeyChar);
                                YesNo(ref menuChoice);
                                if (menuChoice == 'y')
                                {
                                    Console.WriteLine("\nAll records will now show xx yy for the name and 00 for the number");
                                    Populate(ref names, ref phoneNumbers);
                                    Console.WriteLine("Press enter to return to the main menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nNo selected, press enter to return to the main menu");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                            }
                            while ((menuChoice != 'y') && (menuChoice != 'n'));
                            break;
                        }

                    case '6': // search for phone number
                        {
                            Console.Clear();
                            do
                            {
                                Console.WriteLine("Do you want to search by first name, surname or both?");
                                Console.WriteLine("Press 1 for first name, 2 for surname or 3 for both");
                                choice = Console.ReadKey();
                                menuChoice = Convert.ToChar(choice.KeyChar);
                                switch (menuChoice)
                                {
                                    case '1': // search by first name only.
                                        {
                                            Console.WriteLine("\nPlease enter the first name");
                                            firstName = Console.ReadLine();
                                            Console.WriteLine("The phone numbers found for " + firstName + " are");
                                            for (int i = 0; i < 20; i++)
                                            {
                                                if (names[i, 0] == firstName)
                                                {
                                                   Console.WriteLine(names[i, 0] + " " + names[i, 1] + " " + phoneNumbers[i] +"\n");
                                                }
                                            }
                                            break;
                                        }
                                    case '2': // search by surname only
                                        {
                                            Console.WriteLine("\nPlease enter the surname");
                                            surname = Console.ReadLine();
                                            Console.WriteLine("The phone numbers found for " + surname + " are");
                                            for (int i = 0; i < 20; i++)
                                            {
                                                if (names[i, 1] == surname)
                                                {
                                                    Console.WriteLine(names[i, 0] + " " + names[i, 1] + " " + phoneNumbers[i]+"\n");
                                                }
                                            }
                                            break;
                                        }
                                    case '3': // serach by both first name and surname.
                                        {
                                            Console.WriteLine("\nPlease enter the first name");
                                            firstName = Console.ReadLine();
                                            Console.WriteLine("Please enter the surname");
                                            surname = Console.ReadLine();
                                            Console.WriteLine("The phone numbers found for " + firstName + " " + surname + " are");
                                            for (int i = 0; i < 20; i++)
                                            {
                                                if ((names[i, 0] == firstName) && (names[i, 1] == surname))
                                                {
                                                    Console.WriteLine(names[i, 0] + " " + names[i, 1] + " " + phoneNumbers[i]+"\n");
                                                }
                                            }
                                            break;
                                        }
                                    default: // invalid selection
                                        {
                                            Console.WriteLine("\nPress 1 to search by first name, 2 to serach by surname or 3 to search by both");
                                            break;
                                        }
                                }                                                  
                                
                                Console.WriteLine("\nDo you want to search for another name?");
                                Console.WriteLine("Press 'y' for yes or 'n' for no");
                                choice = Console.ReadKey();
                                menuChoice = Convert.ToChar(choice.KeyChar);
                                YesNo(ref menuChoice);
                            }
                            while (menuChoice == 'y');
                            Console.WriteLine("\nNo selected, press enter to return to the main menu.");
                            Console.ReadLine();
                            Console.Clear();
                            break;


                        }
                    case 'q': // quit program
                        {
                            Console.Clear();
                            do
                            {
                                Console.WriteLine("Are you sure you want to quit? Press 'y' for yes or 'n' for no");
                                choice = Console.ReadKey();
                                menuChoice = Convert.ToChar(choice.KeyChar);
                                if (menuChoice == 'y')
                                {
                                    Console.WriteLine("\nThankyou and goodbye");
                                    Thread.Sleep(2000); // hang for 2 seconds then closes program.
                                    menuChoice = 'q';
                                    break;
                                    
                                }

                                else
                                {
                                    if (menuChoice == 'n')
                                    {
                                        Console.WriteLine("\nNo selected press enter to return to the main menu");
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;

                                    }
                                    else
                                    {
                                        Console.WriteLine("\nInvalid selection, please press y or n");
                                    }
                            
                                }
                            }
                            while ((menuChoice != 'q') || (menuChoice != 'n'));
                            break;
                        }
                    default: // invalid selection
                        {
                            Console.WriteLine("\nInvalid selection, press 1,2,3,4 or Q");
                            break;
                        }
                }
            }
            while (menuChoice != 'q');
            
                                    
        }

        private static void Populate(ref string[,] names, ref string[] numbers) // add xx yy 00 to all records
        {
            for (int i = 0; i < 20; i++)
            {
                names[i, 0] = "xx";
                names[i, 1] = "yy";
                numbers[i] = "00";
                
            }
        }

        private static void AddEntry(int box, ref string[,] names, ref string[] numbers) // add entry to given record
        {
                string Pnumber;
                Console.WriteLine("\nPlease enter the first name");
                names[box, 0] = Console.ReadLine(); // store first name in box chosen by user.
                Console.WriteLine("Please enter the surname");
                names[box, 1] = Console.ReadLine(); // store surname in box chosen by user.
                Console.WriteLine("Please enter the number");
                Pnumber = Console.ReadLine();
                NumCheck(ref Pnumber);
                numbers[box] = Pnumber; // stores number in box chosen by user.
                Console.WriteLine(names[box, 0] + " " + names[box, 1] +" "+numbers[box] +"\n");
        }

        private static void NumCheck(ref string Pnumber) // check if a number was entered
        {
            long num;
            bool isnum;
            do
            {
                Pnumber = Pnumber.Replace(" ", string.Empty); // removes any spaces 1 2 3 becomes 123
                isnum = long.TryParse(Pnumber, out num); // Checks if entered string can be used as a long integer.
                if (isnum == false)
                {
                    Console.WriteLine("Invalid entry, please enter a number."); // entry is not a number, asks for another.
                    Pnumber = Console.ReadLine();
                    isnum = false;

                }

            }
            while (isnum == false);
        }

        private static void BoxCheck(ref string box) //check if box number entered is 0 to 19
        {
            int boxNum;
            do
            {
                boxNum = Convert.ToInt32(box);
                if ((boxNum < 0) || (boxNum > 19))
                {
                    Console.WriteLine("Invalid entry, please enter a number from 0 to 19");
                    box = Console.ReadLine();
                    NumCheck(ref box);

                }
            }
            while ((boxNum < 0) || (boxNum > 19));
        }

        private static void YesNo(ref char decision)
        {
            do
            {
                switch (decision)
                {
                    case 'y':
                        break;
                    case 'n':
                        break;
                    default:
                        Console.WriteLine("\nInvalid selection, press 'y' for yes or 'n' for no only.");
                        var decide = Console.ReadKey();
                        decision = Convert.ToChar(decide.KeyChar);
                        break;
                }
            }
            while ((decision != 'y') && (decision != 'n'));
            return;
        }

    }
}
