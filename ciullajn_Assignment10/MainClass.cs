/*
 * Name: John Ciulla
 * Email: ciullajn@mail.uc.edu
 * Assignment: Assignment 10
 * Course/Semester: IT 3045C Fall 2021
 * Description: Demonstrates Luhn's Algorithm
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
    class MainClass
    {
        static void Main(string[] args)
        {

            LuhnsAlgorithm test = new LuhnsAlgorithm();
            test.LuhnsAlgorithmTest("12345567");
            test.LuhnsAlgorithmTest("123456");
           

           
            
        }
    }

}
