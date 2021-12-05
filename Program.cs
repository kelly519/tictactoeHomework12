using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoehomework12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool game = true;
            int choose;
            while (game)
            {
                Console.WriteLine("1.New game\n" +
                    "2.About the author\n" +
                    "3.Exit\n");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        string one = "   ";
                        string two = "   ";
                        string three = "   ";
                        string four = "   ";
                        string five = "   ";
                        string six = "   ";
                        string seven = "   ";
                        string eight = "   ";
                        string nine = "   ";
                        bool next = true;
                        int flag = 1;
                        int turn;
                        while (next)
                        {
                            if (one != "   " && two != "   " && three != "   "
                                &&
                                four != "   " && five != "   " && six != "   "
                                &&
                                seven != "   " && eight != "   " && nine != "   ")
                            {
                                Console.WriteLine("Draw!\nGame Over!");
                                next = false;
                                Console.ReadKey();
                                break;

                            }
                            Console.Write(one + "|" + two + "|" + three + "\n");
                            Console.WriteLine("---+---+---");
                            Console.Write(four + "|" + five + "|" + six + "\n");
                            Console.WriteLine("---+---+---");
                            Console.Write(seven + "|" + eight + "|" + nine + "\n");
                            if (flag == 1)
                            {
                                Console.WriteLine("X's move >");
                                turn = Convert.ToInt32(Console.ReadLine());
                                switch (turn)
                                {
                                    case 1:
                                        if (one == "   ")
                                        {
                                            one = " X ";
                                            flag++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    case 2:
                                        if (two == "   ")
                                        {
                                            two = " X ";
                                            flag++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    case 3:
                                        if (three == "   ")
                                        {
                                            three = " X ";
                                            flag++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    case 4:
                                        if (four == "   ")
                                        {
                                            four = " X ";
                                            flag++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    case 5:
                                        if (five == "   ")
                                        {
                                            five = " X ";
                                            flag++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    case 6:
                                        if (six == "   ")
                                        {
                                            six = " X ";
                                            flag++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    case 7:
                                        if (seven == "   ")
                                        {
                                            seven = " X ";
                                            flag++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    case 8:
                                        if (eight == "   ")
                                        {
                                            eight = " X ";
                                            flag++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    case 9:
                                        if (nine == "   ")
                                        {
                                            nine = " X ";
                                            flag++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Illegal move! Try again.");
                                        break;
                                }

                                if ((one == " X " && two == " X " && three == " X ")
                                    ||
                                    (four == " X " && five == " X " && six == " X ")
                                    ||
                                    (seven == " X " && eight == " X " && nine == " X ")
                                    ||
                                    (one == " X " && four == " X " && seven == " X ")
                                    ||
                                    (two == " X " && five == " X " && eight == " X ")
                                    ||
                                    (three == " X " && six == " X " && nine == " X ")
                                    ||
                                    (one == " X " && five == " X " && nine == " X ")
                                    ||
                                    (three == " X " && five == " X " && seven == " X "))
                                {
                                    Console.WriteLine("X WON!\nGame Over");
                                    next = false;
                                    Console.ReadKey();

                                }
                            }

                            else
                            {
                                Console.WriteLine("O's move >");
                                turn = Convert.ToInt32(Console.ReadLine());
                                switch (turn)
                                {
                                    case 1:
                                        if (one == "   ")
                                        {
                                            one = " O ";
                                            flag--;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    case 2:
                                        if (two == "   ")
                                        {
                                            two = " O ";
                                            flag--;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    case 3:
                                        if (three == "   ")
                                        {
                                            three = " O ";
                                            flag--;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    case 4:
                                        if (four == "   ")
                                        {
                                            four = " O ";
                                            flag--;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    case 5:
                                        if (five == "   ")
                                        {
                                            five = " O ";
                                            flag--;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    case 6:
                                        if (six == "   ")
                                        {
                                            six = " O ";
                                            flag--;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    case 7:
                                        if (seven == "   ")
                                        {
                                            seven = " O ";
                                            flag--;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    case 8:
                                        if (eight == "   ")
                                        {
                                            eight = " O ";
                                            flag--;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    case 9:
                                        if (nine == "   ")
                                        {
                                            nine = " O ";
                                            flag--;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Illegal move! Try again.");
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Illegal move! Try again.");
                                        break;
                                }

                                if ((one == " O " && two == " O " && three == " O ")
                                    ||
                                    (four == " O " && five == " O " && six == " O ")
                                    ||
                                    (seven == " O " && eight == " O " && nine == " O ")
                                    ||
                                    (one == " O " && four == " O " && seven == " O ")
                                    ||
                                    (two == " O " && five == " O " && eight == " O ")
                                    ||
                                    (three == " O " && six == " O " && nine == " O ")
                                    ||
                                    (one == " O " && five == " O " && nine == " O ")
                                    ||
                                    (three == " O " && five == " O " && seven == " O "))
                                {
                                    Console.WriteLine("O WON!\nGame Over");
                                    next = false;
                                    Console.ReadKey();

                                }
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Name Surname: BERKAY OZTOPRAK");
                        break;
                    case 3:
                        Console.WriteLine("Are you sure you want to quit? [y/n]");
                        char exit = Convert.ToChar(Console.ReadLine());
                        if (exit == 'y')
                        {
                            game = false;
                            next = false;
                        }
                        break;
                }
            }
        }
    }
}
