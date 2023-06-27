/*
    Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

    2, 3, 7 -> 7
    44 5 78 -> 78
    22 3 9 -> 22
*/

//int firstNumber = 2, secondNumber = 3, thirdNumber = 7; 
//int firstNumber = 44, secondNumber = 5, thirdNumber = 78;
int firstNumber = 22, secondNumber = 3, thirdNumber = 9;

if(firstNumber > secondNumber){
    if(firstNumber > thirdNumber) Console.Write("Numbers: [" + firstNumber + ", " + secondNumber + ", " + thirdNumber + "]. [" + firstNumber + "] is max.");
}
if(secondNumber > firstNumber){
    if(secondNumber > thirdNumber) Console.Write("Numbers: [" + firstNumber + ", " + secondNumber + ", " + thirdNumber + "]. [" + secondNumber + "] is max.");
}
if(thirdNumber > firstNumber){
    if(thirdNumber > secondNumber) Console.Write("Numbers: [" + firstNumber + ", " + secondNumber + ", " + thirdNumber + "]. [" + thirdNumber + "] is max.");
}