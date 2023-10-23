﻿// Project Euler (https://projecteuler.net/) code exercises
// Taken from FreeCodeCamp (https://www.freecodecamp.org/learn/project-euler/) lesson plan
// Not coded in JavaScript, but C#
// Code by JT Stukes

// Problem 12 - Highly divisible triangular number

/*
The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:
1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...

Let us list the factors of the first seven triangle numbers:
1: 1
3: 1, 3
6: 1, 2, 3, 6
10: 1, 2, 5, 10
15: 1, 3, 5, 15
21: 1, 3, 7, 21
28: 1, 2, 4, 7, 14, 28

We can see that 28 is the first triangle number to have over five divisors.

What is the value of the first triangle number to have over n divisors?
*/

Console.WriteLine(DivisbleTriangleNumber(5)); // should return 28
Console.WriteLine(DivisbleTriangleNumber(23)); // should return 630
Console.WriteLine(DivisbleTriangleNumber(167)); // should return 1385280
Console.WriteLine(DivisbleTriangleNumber(374)); // should return 17907120
Console.WriteLine(DivisbleTriangleNumber(500)); // should return 76576500

long DivisbleTriangleNumber(int overDivisors)
{
    long triangleCounter = 2;

    while (true)
    {
        long workingTriangleNumber = TriangleNumber(triangleCounter);

        if (DivisorCounter(workingTriangleNumber) > overDivisors)
        {
            return workingTriangleNumber;
        }

        if (triangleCounter % 1000 == 0)
        {
            //Console.WriteLine(triangleCounter);
        }
        triangleCounter++;
    }
}

long DivisorCounter(long numberToDivide) // Required to lookup counting divisors algorithm, brute forcing all values was too slow
{
    long divisors = 1;
    long count = 1;
    long workingNumber = numberToDivide;

    while (workingNumber % 2 == 0)
    {
        count++;
        workingNumber = workingNumber / 2;
    }
    divisors = divisors * count;

    long newDivisor = 3;
    while (workingNumber != 1)
    {
        count = 1;
        while (workingNumber % newDivisor == 0)
        {
            count++;
            workingNumber = workingNumber / newDivisor;
        }

        divisors = divisors * count;
        newDivisor = newDivisor + 2;
    }
    return divisors;
}

long TriangleNumber(long sequenceNumber) // speed increased instead of adding all numbers
{
    long triangleNumber = (sequenceNumber + 1) * (sequenceNumber / 2);
    if (sequenceNumber % 2 != 0)
    {
        triangleNumber = triangleNumber + ((sequenceNumber / 2) + 1);
    }
    return triangleNumber;
}