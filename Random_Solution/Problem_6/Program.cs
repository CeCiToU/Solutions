using System;
using System.Collections.Generic;

namespace ConsoleApp341
{
    class Program
    {
        static void Main(string[] args)
        {
            bool winner = false;
            Dictionary<int, string> questions = new Dictionary<int, string>();
            Dictionary<string, string> answers = new Dictionary<string, string>();

            //set questions

            questions.Add(0, "In the Broadway musical \"Annie, \" where does Annie live?");
            questions.Add(1, "According to a well-known expression, a wealthy person is said to live \"high off the\" what?");
            questions.Add(2, "The state of Maine is known for producing which of these foods?");
            questions.Add(3, "The word \"grand\" is slang for what amount of money");
            questions.Add(4, "According to a popular phrase, a person having a fun adventure is said to be \"on a\" what?");
            questions.Add(5, "A magnet would most likely attract which of the following?");
            questions.Add(6, "What is the smallest country in the world?");
            questions.Add(7, "In what year Bulgaria get into European Union?");
            questions.Add(8, " Which city will host the 2028 Olympic Games?");
            questions.Add(9, "How many kilometers is the earth away from the sun?");
            questions.Add(10, "At a restaurant, someone who “foots the bill” does what?");
            questions.Add(11, "Oberon is the satellite of which planet?");
            questions.Add(12, "If you planted the seeds of Quercus robur, what would grow?");
            questions.Add(13, "A number one followed by one hundred zeros is known by what name?");
            questions.Add(14, "A common piece of advice goes, “Be there or be” what?");

            //questions.Add(-1, " ");

            //set answers

            answers.Add("In the Broadway musical \"Annie, \" where does Annie live?", "A\\ Deep Space Nine\nB\\ Desert island\nC\\ Orphange\nD\\ Jungle tree house\n");
            answers.Add("According to a well-known expression, a wealthy person is said to live \"high off the\" what?", "A\\ Honey\nB\\ Government\nC\\ Hog\nD\\ Hippopotamus\n");
            answers.Add("The state of Maine is known for producing which of these foods?", "A\\ Jambalaya\nB\\ Lobster\nC\\ Baked beans\nD\\ Beef\n");
            answers.Add("The word \"grand\" is slang for what amount of money", "A\\ $1,000,000\nB\\ $1\nC\\ $100\nD\\ $1,000\n");
            answers.Add("According to a popular phrase, a person having a fun adventure is said to be \"on a\" what?", "A\\ Shopping spree\nB\\ Lark\nC\\ Loon\nD\\ Goose\n");
            answers.Add("A magnet would most likely attract which of the following?", "A\\ Metal\nB\\ Copper\nC\\ Spoon\nD\\ Gold\n");
            answers.Add("What is the smallest country in the world?", "A\\ Vatican City\nB\\ Bulgaria\nC\\ Russia\nD\\ Germany\n");
            answers.Add("In what year Bulgaria get into European Union?", "A\\ 2005\nB\\ 2006\nC\\ 2007\nD\\ 2008\n");
            answers.Add(" Which city will host the 2028 Olympic Games?", "A\\ Sofia\nB\\ New York City\nC\\ Los Angeles\nD\\ Berlin\n");
            answers.Add("How many kilometers is the earth away from the sun?", "A\\ ~104 million km\nB\\ ~152 million km\nC\\ ~78 million km\nD\\ ~483 million km\n");
            answers.Add("At a restaurant, someone who “foots the bill” does what?", "A\\ Pays it\nB\\ Takes it for the oders to pay\nC\\ Eats it\nD\\ Throw it away\n");
            answers.Add("Oberon is the satellite of which planet?", "A\\ Uranus\nB\\ Neptun\nC\\ Jupiter\nD\\ Earth\n");
            answers.Add("If you planted the seeds of Quercus robur, what would grow?", "A\\ Potatoes\nB\\ Plants\nC\\ Bushes\nD\\ Trees\n");
            answers.Add("A number one followed by one hundred zeros is known by what name?", "A\\ Billion\nB\\ Trillion\nC\\ Sextillion\nD\\ Googol\n");
            answers.Add("A common piece of advice goes, “Be there or be” what?", "A\\ Dot\nB\\ Line\nC\\ Triangle\nD\\ Square\n");

            //answers.Add(" ", "A\\ \nB\\ \nC\\ \nD\\ \n");

            //set concetenation

            int[] concatenation = Concatenation(questions.Count);

            ////main logic for playing

            for (int i = 0; i < 10; i++)
            {
                int currentNum = concatenation[i];
                foreach (var quest in questions)
                {
                    if (quest.Key == currentNum)
                    {
                        foreach (var ans in answers)
                        {
                            if (ans.Key == quest.Value)
                            {
                                switch (quest.Value)
                                {
                                    case "In the Broadway musical \"Annie, \" where does Annie live?":
                                        Console.WriteLine(ans.Key);
                                        Console.WriteLine(ans.Value);
                                        Console.Write("Your answer is:  ");
                                        string playerAns1 = Console.ReadLine().ToLower();
                                        Console.WriteLine();
                                        if (playerAns1 == "c")
                                        {
                                            winner = true;
                                            Console.WriteLine("CORRECT!!!");
                                            Console.WriteLine("Next question ->\n\n");
                                        }
                                        else
                                        {
                                            winner = false;
                                            Console.WriteLine("INCORRECT!!!");
                                            Console.WriteLine("TRY AGAIN!!!");
                                            questions.Clear();
                                            answers.Clear();
                                        }
                                        break;
                                    case "According to a well-known expression, a wealthy person is said to live \"high off the\" what?":
                                        Console.WriteLine(ans.Key);
                                        Console.WriteLine(ans.Value);
                                        Console.Write("Your answer is:  ");
                                        string playerAns2 = Console.ReadLine().ToLower();
                                        Console.WriteLine();

                                        if (playerAns2 == "c")
                                        {
                                            winner = true;
                                            Console.WriteLine("CORRECT!!!");
                                            Console.WriteLine("Next question ->\n\n");
                                        }
                                        else
                                        {
                                            winner = false;
                                            Console.WriteLine("INCORRECT!!!");
                                            Console.WriteLine("TRY AGAIN!!!");
                                            questions.Clear();
                                            answers.Clear();
                                        }
                                        break;
                                    case "The state of Maine is known for producing which of these foods?":
                                        Console.WriteLine(ans.Key);
                                        Console.WriteLine(ans.Value);
                                        Console.Write("Your answer is:  ");
                                        string playerAns3 = Console.ReadLine().ToLower();
                                        Console.WriteLine();

                                        if (playerAns3 == "b")
                                        {
                                            winner = true;
                                            Console.WriteLine("CORRECT!!!");
                                            Console.WriteLine("Next question ->\n\n");
                                        }
                                        else
                                        {
                                            winner = false;
                                            Console.WriteLine("INCORRECT!!!");
                                            Console.WriteLine("TRY AGAIN!!!");
                                            questions.Clear();
                                            answers.Clear();
                                        }
                                        break;
                                    case "The word \"grand\" is slang for what amount of money":
                                        Console.WriteLine(ans.Key);
                                        Console.WriteLine(ans.Value);
                                        Console.Write("Your answer is:  ");
                                        string playerAns4 = Console.ReadLine().ToLower();
                                        Console.WriteLine();
                                        if (playerAns4 == "d")
                                        {
                                            winner = true;
                                            Console.WriteLine("CORRECT!!!");
                                            Console.WriteLine("Next question ->\n\n");
                                        }
                                        else
                                        {
                                            winner = false;
                                            Console.WriteLine("INCORRECT!!!");
                                            Console.WriteLine("TRY AGAIN!!!");
                                            questions.Clear();
                                            answers.Clear();
                                        }
                                        break;
                                    case "According to a popular phrase, a person having a fun adventure is said to be \"on a\" what?":
                                        Console.WriteLine(ans.Key);
                                        Console.WriteLine(ans.Value);
                                        Console.Write("Your answer is:  ");
                                        string playerAns5 = Console.ReadLine().ToLower();
                                        Console.WriteLine();
                                        if (playerAns5 == "b")
                                        {
                                            winner = true;
                                            Console.WriteLine("CORRECT!!!");
                                            Console.WriteLine("Next question ->\n\n");
                                        }
                                        else
                                        {
                                            winner = false;
                                            Console.WriteLine("INCORRECT!!!");
                                            Console.WriteLine("TRY AGAIN!!!");
                                            questions.Clear();
                                            answers.Clear();
                                        }
                                        break;
                                    case "A magnet would most likely attract which of the following?":
                                        Console.WriteLine(ans.Key);
                                        Console.WriteLine(ans.Value);
                                        Console.Write("Your answer is:  ");
                                        string playerAns6 = Console.ReadLine().ToLower();
                                        Console.WriteLine();
                                        if (playerAns6 == "a")
                                        {
                                            winner = true;
                                            Console.WriteLine("CORRECT!!!");
                                            Console.WriteLine("Next question ->\n\n");
                                        }
                                        else
                                        {
                                            winner = false;
                                            Console.WriteLine("INCORRECT!!!");
                                            Console.WriteLine("TRY AGAIN!!!");
                                            questions.Clear();
                                            answers.Clear();
                                        }
                                        break;
                                    case "What is the smallest country in the world?":
                                        Console.WriteLine(ans.Key);
                                        Console.WriteLine(ans.Value);
                                        Console.Write("Your answer is:  ");
                                        string playerAns7 = Console.ReadLine().ToLower();
                                        Console.WriteLine();
                                        if (playerAns7 == "a")
                                        {
                                            winner = true;
                                            Console.WriteLine("CORRECT!!!");
                                            Console.WriteLine("Next question ->\n\n");
                                        }
                                        else
                                        {
                                            winner = false;
                                            Console.WriteLine("INCORRECT!!!");
                                            Console.WriteLine("TRY AGAIN!!!");
                                            questions.Clear();
                                            answers.Clear();
                                        }
                                        break;
                                    case "In what year Bulgaria get into European Union?":
                                        Console.WriteLine(ans.Key);
                                        Console.WriteLine(ans.Value);
                                        Console.Write("Your answer is:  ");
                                        string playerAns8 = Console.ReadLine().ToLower();
                                        Console.WriteLine();
                                        if (playerAns8 == "c")
                                        {
                                            winner = true;
                                            Console.WriteLine("CORRECT!!!");
                                            Console.WriteLine("Next question ->\n\n");
                                        }
                                        else
                                        {
                                            winner = false;
                                            Console.WriteLine("INCORRECT!!!");
                                            Console.WriteLine("TRY AGAIN!!!");
                                            questions.Clear();
                                            answers.Clear();
                                        }
                                        break;
                                    case "Which city will host the 2028 Olympic Games?":
                                        Console.WriteLine(ans.Key);
                                        Console.WriteLine(ans.Value);
                                        Console.Write("Your answer is:  ");
                                        string playerAns9 = Console.ReadLine().ToLower();
                                        Console.WriteLine();
                                        if (playerAns9 == "c")
                                        {
                                            winner = true;
                                            Console.WriteLine("CORRECT!!!");
                                            Console.WriteLine("Next question ->\n\n");
                                        }
                                        else
                                        {
                                            winner = false;
                                            Console.WriteLine("INCORRECT!!!");
                                            Console.WriteLine("TRY AGAIN!!!");
                                            questions.Clear();
                                            answers.Clear();
                                        }
                                        break;
                                    case "How many kilometers is the earth away from the sun?":
                                        Console.WriteLine(ans.Key);
                                        Console.WriteLine(ans.Value);
                                        Console.Write("Your answer is:  ");
                                        string playerAns10 = Console.ReadLine().ToLower();
                                        Console.WriteLine();
                                        if (playerAns10 == "b")
                                        {
                                            winner = true;
                                            Console.WriteLine("CORRECT!!!");
                                            Console.WriteLine("Next question ->\n\n");
                                        }
                                        else
                                        {
                                            winner = false;
                                            Console.WriteLine("INCORRECT!!!");
                                            Console.WriteLine("TRY AGAIN!!!");
                                            questions.Clear();
                                            answers.Clear();
                                        }
                                        break;
                                    case "At a restaurant, someone who “foots the bill” does what?":
                                        Console.WriteLine(ans.Key);
                                        Console.WriteLine(ans.Value);
                                        Console.Write("Your answer is:  ");
                                        string playerAns11 = Console.ReadLine().ToLower();
                                        Console.WriteLine();
                                        if (playerAns11 == "a")
                                        {
                                            winner = true;
                                            Console.WriteLine("CORRECT!!!");
                                            Console.WriteLine("Next question ->\n\n");
                                        }
                                        else
                                        {
                                            winner = false;
                                            Console.WriteLine("INCORRECT!!!");
                                            Console.WriteLine("TRY AGAIN!!!");
                                            questions.Clear();
                                            answers.Clear();
                                        }
                                        break;
                                    case "Oberon is the satellite of which planet?":
                                        Console.WriteLine(ans.Key);
                                        Console.WriteLine(ans.Value);
                                        Console.Write("Your answer is:  ");
                                        string playerAns12 = Console.ReadLine().ToLower();
                                        Console.WriteLine();
                                        if (playerAns12 == "a")
                                        {
                                            winner = true;
                                            Console.WriteLine("CORRECT!!!");
                                            Console.WriteLine("Next question ->\n\n");
                                        }
                                        else
                                        {
                                            winner = false;
                                            Console.WriteLine("INCORRECT!!!");
                                            Console.WriteLine("TRY AGAIN!!!");
                                            questions.Clear();
                                            answers.Clear();
                                        }
                                        break;
                                    case "A common piece of advice goes, “Be there or be” what?":
                                        Console.WriteLine(ans.Key);
                                        Console.WriteLine(ans.Value);
                                        Console.Write("Your answer is:  ");
                                        string playerAns13 = Console.ReadLine().ToLower();
                                        Console.WriteLine();
                                        if (playerAns13 == "d")
                                        {
                                            winner = true;
                                            Console.WriteLine("CORRECT!!!");
                                            Console.WriteLine("Next question ->\n\n");
                                        }
                                        else
                                        {
                                            winner = false;
                                            Console.WriteLine("INCORRECT!!!");
                                            Console.WriteLine("TRY AGAIN!!!");
                                            questions.Clear();
                                            answers.Clear();
                                        }
                                        break;
                                    case "If you planted the seeds of Quercus robur, what would grow?":
                                        Console.WriteLine(ans.Key);
                                        Console.WriteLine(ans.Value);
                                        Console.Write("Your answer is:  ");
                                        string playerAns14 = Console.ReadLine().ToLower();
                                        Console.WriteLine();
                                        if (playerAns14 == "d")
                                        {
                                            winner = true;
                                            Console.WriteLine("CORRECT!!!");
                                            Console.WriteLine("Next question ->\n\n");
                                        }
                                        else
                                        {
                                            winner = false;
                                            Console.WriteLine("INCORRECT!!!");
                                            Console.WriteLine("TRY AGAIN!!!");
                                            questions.Clear();
                                            answers.Clear();
                                        }
                                        break;
                                    case "A number one followed by one hundred zeros is known by what name?":
                                        Console.WriteLine(ans.Key);
                                        Console.WriteLine(ans.Value);
                                        Console.Write("Your answer is:  ");
                                        string playerAns15 = Console.ReadLine().ToLower();
                                        Console.WriteLine();
                                        if (playerAns15 == "d")
                                        {
                                            winner = true;
                                            Console.WriteLine("CORRECT!!!");
                                            Console.WriteLine("Next question ->\n\n");
                                        }
                                        else
                                        {
                                            winner = false;
                                            Console.WriteLine("INCORRECT!!!");
                                            Console.WriteLine("TRY AGAIN!!!");
                                            questions.Clear();
                                            answers.Clear();
                                        }
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            if (winner)
            {
                Console.WriteLine("        !!!YOU WON!!!");
                Console.WriteLine("          TRY AGAIN");
            }
            else
            {
                Console.WriteLine("Read more next time :(");
            }
        }


        static int[] Concatenation(int index)
        {
            Random num = new Random();
            List<int> listOfSteps = new List<int>();
            while (listOfSteps.Count < index)
            {
                int numToAdd = num.Next(0, index);
                if (!listOfSteps.Contains(numToAdd))
                {
                    listOfSteps.Add(numToAdd);
                }
            }

            return listOfSteps.ToArray();
        }
    }
}
