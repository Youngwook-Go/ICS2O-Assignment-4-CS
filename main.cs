// Created by: Youngwook
// Created on: NOV 2022
//
// This function gets lengths of three side of triangle to answer properly

using System;

class Program
{
    public static void Main(string[] args)
    {
        // input
        string sizeInput;
        string beverageInput;
        int topping;

        int size;
        int beverage;

        double HST = 0.13;
        int check;
        int price;
        double answer;

        Console.WriteLine("TThis program gets user input and answer the price.");

        Console.Write("\nChoose size of the pizza\n( M, L, XL ) : "); sizeInput = Console.ReadLine();
        Console.Write("\nChoose the beverage\n( water, soda, coffie, shake ) : "); beverageInput = Console.ReadLine();
        Console.Write("\nChoose number of topping\nYou must add at least 1 topping : "); topping = Convert.ToInt32(Console.ReadLine());

        if (sizeInput == "M")
        {
            size = 8;
        } 
        else if (sizeInput == "L")
        {
            size = 10;
        } 
        else if (sizeInput == "XL") 
        {
            size = 12;
        } 
        else 
        {
            size = 0;
        }

        if (beverageInput == "water") 
        {
            beverage = 1;
        } 
        else if (beverageInput == "soda") 
        {
            beverage = 2;
        } 
        else if (beverageInput == "coffie") 
        {
            beverage = 3;
        }
        else if (beverageInput == "shake") 
        {
            beverage = 4;
        } 
        else 
        {
            beverage = 0;
        }

        check = size  * beverage * topping;
        price = size + beverage + topping;
        answer = price + (price * HST);

        if (check == 0) 
        {
            Console.WriteLine("\nPlease input properly");
        } 
        else 
        {
            Console.WriteLine("\nThe size of the pizza is : " + sizeInput + " (" + size + " $)");
            Console.WriteLine("The beverage is : " + beverageInput + " (" + beverage + " $)");
            Console.WriteLine("The number of topping is : " + topping + " (" + topping + " $)");

            Console.WriteLine("\nThe total price is : " + answer + " $");
        }
        
        Console.WriteLine("\ndone.");
    }
}
