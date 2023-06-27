/*
    Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

    645 -> 5
    78 -> третьей цифры нет
    32679 -> 6    
*/

void thirdDigit(int arg){
    
    if(arg >= 100){

        while(arg >= 100){
            if(arg > 1000) arg = arg / 10;

            if(arg >= 100 && arg < 1000){
                arg = arg % 10;
                Console.Write(arg + " - is the third digit.");
            }                          
        } 

    }else{
        Console.Write("Ther isn't third digit in this number.");
    }  
}

Console.Write("Enter any number: ");
int usersNumber = Convert.ToInt32(Console.ReadLine());

thirdDigit(usersNumber);