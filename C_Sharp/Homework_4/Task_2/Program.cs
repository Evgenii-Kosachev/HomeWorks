/*
    Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    452 -> 11
    82 -> 10
    9012 -> 12    
*/

int Sum(int numb){
    int result = 0;

    while(numb > 0){
        int remainder = numb % 10;
        numb = numb / 10;
        result = result + remainder;    
    }

    if(numb < 0) numb = numb * (-1);
    while(numb > 0){
        int remainder = numb % 10;
        if(numb < 10) remainder = remainder * (-1);
        numb = numb / 10;
        result = result + remainder;    
    }
    
    return result;
}

Console.Write("Enter any number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.Write(Sum(userNumber));