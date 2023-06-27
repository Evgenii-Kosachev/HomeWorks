/*
    Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

    a = 5; b = 7 -> max = 7
    a = 2 b = 10 -> max = 10
    a = -9 b = -3 -> max = -3
*/

//int firstNumber = new Random().Next(5, 7);
//int firstNumber = new Random().Next(2, 10);
int firstNumber = new Random().Next(-9, -3);
Console.WriteLine("First number: " + firstNumber + ".");

//int secondNumber = new Random().Next(5, 7);
//int secondNumber = new Random().Next(2, 10);
int secondNumber = new Random().Next(-9, -3);
Console.WriteLine("Second number: " + secondNumber + ".");


if(firstNumber > secondNumber){
    Console.WriteLine("Number " + firstNumber + " is bigger.");
}
if(firstNumber < secondNumber){
    Console.WriteLine("Number " + secondNumber + " is bigger.");
}
if(firstNumber == secondNumber){                                      
    Console.WriteLine("Both numbers are equal.");
}
