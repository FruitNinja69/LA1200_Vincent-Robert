



using System;



namespace Randomnumberguesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();

            string end = @"
    
                     __     __        _     _     _       ____        _                   _ 
                     \ \   / /       | |   | |   | |     |  _ \      | |                 | |
                      \ \_/ /__  __ _| |__ | |__ | |__   | |_) | __ _| |__  _   _ _   _  | |
                       \   / _ \/ _` | '_ \| '_ \| '_ \  |  _ < / _` | '_ \| | | | | | | | |
                        | |  __/ (_| | | | | | | | | | | | |_) | (_| | |_) | |_| | |_| | |_|
                        |_|\___|\__,_|_| |_|_| |_|_| |_| |____/ \__,_|_.__/ \__, |\__, | (_)
                                                                                   __/ | __/ |    
                                                                                  |___/ |___/     


             ";

            string tittle = @"
 _____                 _                   _   _                                        _____                      
|  __ \               | |                 | \ | |                                      / ____|                     
| |__) |__ _ _ __   __| | ___  _ __ ___   |  \| |_   _ _ __ ___  _ __ ___   ___ _ __  | |  __  __ _ _ __ ___   ___ 
|  _  // _` | '_ \ / _` |/ _ \| '_ ` _ \  | . ` | | | | '_ ` _ \| '_ ` _ \ / _ \ '__| | | |_ |/ _` | '_ ` _ \ / _ \
| | \ \ (_| | | | | (_| | (_) | | | | | | | |\  | |_| | | | | | | | | | | |  __/ |    | |__| | (_| | | | | | |  __/
|_|  \_\__,_|_| |_|\__,_|\___/|_| |_| |_| |_| \_|\__,_|_| |_| |_|_| |_| |_|\___|_|     \_____|\__,_|_| |_| |_|\___|
                                                                                                                                                                                                                                            
             ";
            string answer = "Yes";
            do
            {
                Console.WriteLine(tittle);


                int rand_num = rd.Next(1, 100);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(rand_num);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Random number has been generated");
                Console.WriteLine("Please type in a number between 1 - 100");
                Console.ForegroundColor = ConsoleColor.Gray;
                int UserGuesser = Convert.ToInt32(Console.ReadLine());
                int UserAttempt = 1;




                if (UserGuesser > 100)
                {
                    Console.WriteLine("Invalid Input tipe a valid between 1-100");
                    UserGuesser--;
                }

                if (UserGuesser > rand_num)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Your number is larger, try typing a smaller one");
                    UserAttempt++;
                }

                else if (UserGuesser == rand_num)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("You got it right!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("It took you" + UserAttempt + " tries ");
                }

                if (UserGuesser < rand_num)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Your number is smaller, try typing a larger one");
                    UserAttempt++;
                }





                while (UserGuesser != rand_num)

                {
                    if (UserGuesser > 100)
                    {
                        Console.WriteLine("Invalid Input tipe a valid between 1-100");
                        UserGuesser--;
                    }


                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("No worries! You've got an unlimited amount of tries ");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    UserGuesser = Convert.ToInt32(Console.ReadLine());

                    if (UserGuesser > rand_num)
                    {

                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Your Number is larger, try typing a smaller one");
                        UserAttempt++;

                    }
                    else if (UserGuesser == rand_num)
                    {

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("You got it right!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("It took you " + UserAttempt + " tries ");
                        Console.WriteLine(end);
                        Console.WriteLine("Wanna play a another game?Yes or NO");
                        answer = Console.ReadLine();


                    }
                    if (UserGuesser < rand_num)
                    {

                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Your number is smaller, try typing a larger one");
                        UserAttempt++;
                    }



                }

            }
            while (answer == "Yes");

        }




    }
}

