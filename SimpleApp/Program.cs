using System;
using System.IO;
using System.Threading.Tasks;

namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declarations
            bool runProgram = true;
            bool colourIsChanged = false;
            string text = "";
            string text3 = "";
            int input = new int();
            int value1 = new int();
            int value2 = new int();
            int from1To100 = new int();
            float value3 = new float();
            int value4 = new int();
            Random rnd = new Random();

            //loop with cases
            while (runProgram == true)
            {
                Console.WriteLine("[0] Close Program" + "\n" +
                "[1] Print Hello Word!" + "\n" +
                "[2] Print User Input" + "\n" +
                "[3] Toggle Text Color In Console" + "\n" +
                "[4] Print Current Date" + "\n" +
                "[5] Print the largest of two numbers given by user" + "\n" +
                "[6] Guess the Random Number" + "\n" +
                "[7] Write text to file on harddrive" + "\n" +
                "[8] Read and print content from file to console" + "\n" +
                "[9] Decimal calculations" + "\n" +
                "[10] Print multiplication tables, 1-10" + "\n" +
                "[11] Print arrays" + "\n" +
                "[12] Check if user input is a palindrome" + "\n" +
                "[13] Print all numbers between x and y" + "\n" +
                "[14] Sorting and listing of even numbers and odd numbers" + "\n" +
                "[15] Print sum of submitted numbers" + "\n" +
                "[16] Print Characters");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        runProgram = false;
                        break;

                    case 1:
                        Console.WriteLine("Hello World!");
                        break;

                    case 2:
                        Console.WriteLine("What is your first name, second name and age?");
                        string nameAndAge = Console.ReadLine();
                        Console.WriteLine(nameAndAge);
                        break;

                    case 3:
                        if (colourIsChanged == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Colour has been set to green");
                            colourIsChanged = true;
                        }
                        else
                        {
                            Console.ResetColor();
                            Console.WriteLine("Colour has been reset");
                            colourIsChanged = false;
                        }
                        break;

                    case 4:
                        string[] dateSplit = ((DateTime.Today).ToString()).Split(" ");
                        Console.WriteLine(dateSplit[0]);
                        break;

                    case 5:
                        Console.WriteLine("input two seperate integers");
                        value1 = int.Parse(Console.ReadLine());
                        value2 = int.Parse(Console.ReadLine());
                        if (value1 > value2)
                        {
                            Console.WriteLine(value1 + " is the larger value");
                        }
                        else
                        {
                            Console.WriteLine(value2 + " is the larger value");
                        }
                        break;
                    case 6:
                        from1To100 = rnd.Next(1, 101);
                        value1 = 0;
                        value2 = 0;
                        while (value1 != from1To100)
                        {
                            value2++;
                            Console.WriteLine("guess a number from 1 to 100");
                            value1 = int.Parse(Console.ReadLine());
                            if (value1 > from1To100)
                            {
                                Console.WriteLine("your guess was too large");
                            }
                            else if (value1 < from1To100)
                            {
                                Console.WriteLine("your guess was not large enough");
                            }
                        }
                        Console.WriteLine("You managed to guess the correct number!\nIt took " + value2 + " tries.");
                        break;
                    case 7:
                        Console.WriteLine("Write text and press ENTER to write it to file");
                        text = Console.ReadLine();
                        File.WriteAllTextAsync("testsavefile.txt", input + "\n");
                        Console.WriteLine("Text was written to file: ");
                        break;
                    case 8:
                        text = File.ReadAllText("testsavefile.txt");
                        Console.WriteLine(text);
                        break;
                    case 9:
                        Console.WriteLine("enter a decimal value");
                        value3 = float.Parse(Console.ReadLine());
                        Console.WriteLine("the square root of your value is: " + Math.Pow(value3, 0.5) + "\nThe square of your value is " + Math.Pow(value3, 2) + "\nThe tenth power of your value is " + Math.Pow(value3, 10));
                        break;
                    case 10:
                        text = "";
                        for (int i = 1; i <= 10; i++)
                        {
                            for (int j = 1; j <= 10; j++)
                            {
                                text += (i * j) + "\t";
                            }
                            text += "\n";
                        }
                        Console.WriteLine(text);
                        break;
                    case 11:
                        int[] sortMe = new int[] { rnd.Next(1, 101), rnd.Next(1, 101), rnd.Next(1, 101), rnd.Next(1, 101), rnd.Next(1, 101), rnd.Next(1, 101) };
                        Console.WriteLine("the unsorted list goes as follows:");
                        foreach (int value in sortMe)
                        {
                            Console.Write(value + ", ");
                        }
                        for (int i = 0; i < sortMe.Length - 1; i++)
                        {
                            for (int j = i + 1; j < sortMe.Length; j++)
                            {
                                if (sortMe[i] > sortMe[j])
                                {
                                    value1 = sortMe[i];
                                    sortMe[i] = sortMe[j];
                                    sortMe[j] = value1;
                                }
                            }
                        }
                        Console.WriteLine("the sorted list goes as follows:");
                        foreach (int value in sortMe)
                        {
                            Console.Write(value + ", ");
                        }
                        Console.Write("\n");
                        break;
                    case 12:
                        Console.WriteLine("enter a word");
                        text = Console.ReadLine().ToLower();
                        char[] charText = text.ToCharArray();
                        Array.Reverse(charText);
                        text3 = string.Join("", charText);
                        if (text == text3)
                        {
                            Console.WriteLine("the word you entered is a palindrome");
                        }
                        else
                        {
                            Console.WriteLine("the word you entered is not a palindrome");
                        }
                        break;
                    case 13:
                        Console.WriteLine("enter two integers");
                        value1 = int.Parse(Console.ReadLine());
                        value2 = int.Parse(Console.ReadLine());
                        if (value1 > value2)
                        {
                            value4 = value2;
                            value2 = value1;
                            value1 = value4;
                        }
                        value4 = value1;
                        while (value4 != value2 - 1)
                        {
                            value4++;
                            Console.WriteLine(value4);
                        }
                        break;
                    case 14:
                        Console.WriteLine("enter a series of numbers with each seperated by a comma (,)");
                        text = Console.ReadLine();
                        string[] collection = text.Split(",");
                        Console.WriteLine("even numbers:");
                        foreach (string text2 in collection)
                        {
                            if (int.Parse(text2) % 2 == 0)
                            {
                                Console.WriteLine(text2);
                            }
                        }
                        Console.WriteLine("odd numbers:");
                        foreach (string text2 in collection)
                        {
                            if (int.Parse(text2) % 2 != 0)
                            {
                                Console.WriteLine(text2);
                            }
                        }
                        break;
                    case 15:
                        value1 = 0;
                        Console.WriteLine("enter a series of numbers with each seperated by a comma (,)");
                        text = Console.ReadLine();
                        string[] collection2 = text.Split(",");
                        foreach (string text2 in collection2)
                        {
                            value1 = value1 + int.Parse(text2);
                        }
                        Console.WriteLine(value1);
                        break;
                    case 16:
                        
                        break;
                }
                Console.WriteLine("press ENTER to continue.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}