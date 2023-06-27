/*
    Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    14212 -> нет
    12821 -> да
    23432 -> да    
*/

void FiveDigit(int numb){
    if(numb >= 10000 && numb < 100000){
        if(numb / 10000 == numb % 10){

            if(numb / 1000 % 10 == numb % 100 / 10){
                Console.Write("This number is a palindrome."); 
            }else{
                Console.Write("This number isn't a palindrome.");
            }
            
        }else{
            Console.Write("This number isn't a palindrome.");
        }    
    }
    if(numb >= 100000) Console.WriteLine("Number bigger 5.");
    if(numb < 10000) Console.WriteLine("Number less 5.");
}

Console.Write("Enter any five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

FiveDigit(number);