/*
    Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

    3 -> 1, 8, 27
    5 -> 1, 8, 27, 64, 125
*/

void GetCube(double arg){
    int index = 1;
    double count = 0;

    while(index <= arg){
        count = Math.Pow(index, 3);
        Console.Write(count + " ");
        index++;
    }  
}

Console.Write("Enter any number: ");
double numberN = Convert.ToDouble(Console.ReadLine());

GetCube(numberN);