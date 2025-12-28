using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;


namespace AdventOfCode._2025
{
    internal class _2025Day1
    {
        public static void Part1()
        {
            // Instructions for solving the puzzle
            // Shorter set of instructions for testing
            // A pattern used for recognising one step of the instructions
            string input = File.ReadAllText("C:\\Users\\johnw\\Desktop\\Unity Projekt\\AdventOfCode\\2025\\Input2025Day1.txt");
            string test = "R20\r\nR10\r\nL11\r\nR45\r\nR13\r\nR32\r\nR46\r\nL20\r\nL1\r\nL26\r\n";
            string pattern = @"([LR])([0-9]+)";

            // Dial to rotate according to the instructions that goes from 0 to 99 and starts 50
            // How many times the dial turns to 0
            int dial = 50;
            int password = 0;

            // List for storing the direction of rotation 'L' or 'R'
            // List for storing how far to rotate in corresponding rotation
            List<string> rotation = new List<string>();
            List<int> distance = new List<int>();

            Console.WriteLine("2025 Day 1 Part 1\n");

            // Instantiate regular expression object with pattern
            // Matches the first step in the instructions to the regular expression pattern
            Regex r = new Regex(pattern);
            Match m = r.Match(input);

            int matchCount = 0;

            // Runs if match was a success
            while (m.Success)
            {
                // Stores each step of the instructions in the "rotation" and "distance" lists
                rotation.Add(m.Groups[1].ToString());
                distance.Add(int.Parse(m.Groups[2].ToString()));

                /*
                Console.WriteLine("Match" + (matchCount));
                Console.WriteLine("Rotation = " + m.Groups[1]);
                Console.WriteLine("Distance = " + m.Groups[2]);
                */

                // Adds 1 to the counter
                // Matches the next step of the instructions to the regular expression pattern
                ++matchCount;
                m = m.NextMatch();
            }

            // loop length of lists
            for (int i = 0; i < rotation.Count; i++)
            {
                // Checks if rotation is 'L' or 'R'
                if (rotation[i] == "L")
                {
                    dial -= distance[i];
                    //Console.WriteLine("Left " + distance[i]);
                }
                else if (rotation[i] == "R")
                {
                    dial += distance[i];
                    //Console.WriteLine("Right " + distance[i]);
                }
                //Console.WriteLine(dial);

                // Loops dial around if it exceeds 0 or 99
                while (dial > 99 || dial < 0)
                {
                    if (dial > 99)
                    {
                        dial -= 100;
                    }
                    else if (dial < 0)
                    {
                        dial += 100;
                    }
                }
                //Console.WriteLine(dial);

                // Adds 1 to password every time dial is 0
                if (dial == 0)
                {
                    password += 1;
                }
            }

            Console.WriteLine("The password is: " + password);
        }

        public static void Part2()
        {
            // Instructions for solving the puzzle
            // Shorter set of instructions for testing
            // A pattern used for recognising one step of the instructions
            string input = File.ReadAllText("C:\\Users\\johnw\\Desktop\\Unity Projekt\\AdventOfCode\\2025\\Input2025Day1.txt");
            string test = "R20\r\nR10\r\nL11\r\nR45\r\nR13\r\nR32\r\nR46\r\nL20\r\nL1\r\nL26\r\n";
            string pattern = @"([LR])([0-9]+)";

            // Dial to rotate according to the instructions that goes from 0 to 99 and starts 50
            // How many times the dial turns to 0
            int dial = 50;
            int password = 0;

            // List for storing the direction of rotation 'L' or 'R'
            // List for storing how far to rotate in corresponding rotation
            List<string> rotation = new List<string>();
            List<int> distance = new List<int>();

            Console.WriteLine("2025 Day 1 Part 2\n");

            // Instantiate regular expression object with pattern
            // Matches the first step in the instructions to the regular expression pattern
            Regex r = new Regex(pattern);
            Match m = r.Match(input);

            int matchCount = 0;

            // Runs if match was a success
            while (m.Success)
            {
                // Stores each step of the instructions in the "rotation" and "distance" lists
                rotation.Add(m.Groups[1].ToString());
                distance.Add(int.Parse(m.Groups[2].ToString()));

                /*
                Console.WriteLine("Match" + (matchCount));
                Console.WriteLine("Rotation = " + m.Groups[1]);
                Console.WriteLine("Distance = " + m.Groups[2]);
                */

                // Adds 1 to the counter
                // Matches the next step of the instructions to the regular expression pattern
                ++matchCount;
                m = m.NextMatch();
            }

            // loop length of lists
            for (int i = 0; i < rotation.Count; i++)
            {
                // Checks if rotation is 'L' or 'R'
                if (rotation[i] == "L")
                {
                    dial -= distance[i];
                    //Console.WriteLine("Left " + distance[i]);
                }
                else if (rotation[i] == "R")
                {
                    dial += distance[i];
                    //Console.WriteLine("Right " + distance[i]);
                }
                //Console.WriteLine(dial);

                // Loops dial around if it exceeds 0 or 99
                while (dial > 99 || dial < 0)
                {
                    if (dial > 99)
                    {
                        dial -= 100;
                    }
                    else if (dial < 0)
                    {
                        dial += 100;
                    }

                    password += 1;
                }
                //Console.WriteLine(dial);

                // Adds 1 to password every time dial is 0
                if (dial == 0)
                {
                    password += 1;
                }
            }

            Console.WriteLine("The password is: " + password);
        }
    }
}
