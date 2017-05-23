﻿using System;

class EnglishNameOfLastDigit
{
    static void Main()
    {
        long number;
        if(long.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine(EnglishNameOfDigit(number));
        } 
        
    }

    static string EnglishNameOfDigit(long number)
    {
        string name = string.Empty;
        var lastDigit = number % 10;
        int digit = (int)Math.Abs(lastDigit);
        switch (digit)
            {
            case 0:
                name = "zero";
                break;
            case 1:
                name = "one";
                break;
            case 2:
                name = "two";
                break;
            case 3:
                name = "three";
                break;
            case 4:
                name = "four";
                break;
            case 5:
                name = "five";
                break;
            case 6:
                name = "six";
                break;
            case 7:
                name = "seven";
                break;
            case 8:
                name = "eight";
                break;
            case 9:
                name = "nine";
                break;
            default:
                break;
        }
        return name;
    }
}

