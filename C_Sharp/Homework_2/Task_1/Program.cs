/*
    Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

    456 -> 5
    782 -> 8
    918 -> 1
*/

void SecondNumber(int arg){
    if(arg > 100 && arg <1000){
        int number = (arg / 10) % 10;
        Console.Write(number);
    }else{
        Console.WriteLine("Number out of range.");
    } 
}

Console.Write("Enter three-digit number: ");
int usersNumber = Convert.ToInt32(Console.ReadLine());

SecondNumber(usersNumber);