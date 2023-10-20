﻿// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 2 - Even Fibonacci Numbers

/*
Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...

By considering the terms in the Fibonacci sequence whose values do not exceed n, find the sum of the even-valued terms.
*/

Console.WriteLine(FiboEvenSum(10)); // should return a number
Console.WriteLine(FiboEvenSum(34)); // should return a number
Console.WriteLine(FiboEvenSum(60)); // should return a number
Console.WriteLine(FiboEvenSum(1000)); // should return a number
Console.WriteLine(FiboEvenSum(100000)); // should return a number
Console.WriteLine(FiboEvenSum(4000000)); // should return a number

int FiboEvenSum(int notToExceedNumber)
{
    int firstFibonacciNumber = 1;
    int secondFibonacciNumber = 1;
    int sumEvenNumbers = 0;

    while (secondFibonacciNumber <= notToExceedNumber)
    {
        if (secondFibonacciNumber % 2 == 0)
        {
            sumEvenNumbers += secondFibonacciNumber;
        }

        int nextFibonacciNumber = firstFibonacciNumber + secondFibonacciNumber;
        firstFibonacciNumber = secondFibonacciNumber;
        secondFibonacciNumber = nextFibonacciNumber;
    }

    return sumEvenNumbers;
}