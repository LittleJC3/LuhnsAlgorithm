/*
 * Name: John Ciulla
 * Email: ciullajn@mail.uc.edu
 * Assignment: Assignment 10
 * Course/Semester: IT 3045C Fall 2021
 * Description: Performs Luhn's Algorithm
 * Citations: https://www.geeksforgeeks.org/luhn-algorithm/ 
 *            https://en.wikipedia.org/wiki/Luhn_algorithm
 *            https://www.youtube.com/watch?v=g-5fXthdZ9U&t=199s 
 * Anything Else: 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciullajn_Assignment10
{
    public class LuhnsAlgorithm
    {
        /// <summary>
        /// Performs and tests Luhn's Algorithm
        /// </summary>
        /// <param name="numberToCheck">The number to be checked</param>
        /// <returns>Valid or not valid</returns>
        public bool LuhnsAlgorithmTest(String numberToCheck)
        {
            // Convert the numberToCheck into an int
            int[] number = new int[numberToCheck.Length];

            // loops through and converts the string to an integer
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = (int)(numberToCheck[i] - '0');
            }

            // This loop goes through and picks out every other number and doubles that number.
            // If that number doubled is greater than 9, it mods it by 10 and then adds one.
            // That is the same thing as 9 * 2 = 18 and then 1 + 8 = 9
            for (int i = number.Length - 2; i >= 0; i = i - 2)
            {
                int placeHolder = number[i];
                placeHolder = placeHolder * 2;
                if (placeHolder > 9)
                {
                    placeHolder = placeHolder % 10 + 1;
                }
                // save value to the array
                number[i] = placeHolder;
            }
            // Time to add things up!
            int total = 0;
            for (int i = 0; i < number.Length; i++)
            {
                total += number[i];
            }
            if (total % 10 == 0)
            {
                Console.WriteLine("Tis Valid");
                return true;
            } else
            {
                Console.WriteLine("Tis Invalid");
                return false;
            }
        }
    }
}
