using AdventOfCode._2025;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Program
    {
        protected static int origRow; // Sets the origin for the WriteAt function
        protected static int origCol;

        public static void WriteAt(string s, int x, int y) // Writes string 's' at the position of integers 'x' and 'y'
        {
            try
            {
                // Sets the cursors position at origin plus offset 'x' and 'y'
                // Writes string 's' at cursor position
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e) //Triggers if the previous set of arguments fail
            {
                // Clears and shows error message
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            _2025Day1.Part2();
        }
    }
}
