// Created by: sophie
// Created on: oct 2020
//
// This program calculates volume of a pyramid

using System;

class Program
{
    public static void Main(string[] args)
    {
        int length;
        int width;
        int height;
        int volume;

        Console.WriteLine("calculates the area of a trapezoid.");
        Console.WriteLine("");

        Console.Write("Enter length: ");
        length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter width: ");
        width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter height: ");
        height = Convert.ToInt32(Console.ReadLine());

        volume = (height * width * length) / 3;

        Console.WriteLine("");
        Console.WriteLine("The volume is: " + volume + ". ");

        Console.WriteLine("\nDone.");
    }
}