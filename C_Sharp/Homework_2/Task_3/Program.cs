/*
   Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

    6 -> да
    7 -> да
    1 -> нет 
*/

void DayOfWeek(int d){ 
    if(d > 0 && d <=7){  
        switch(d){
            case 1:
                Console.Write("It's Monday!");
                break;
            case 2:
                Console.Write("It's Tuesday!");
                break;
            case 3:
                Console.Write("It's Wednesday!");
                break;
            case 4:
                Console.Write("It's Thursday!");
                break;
            case 5:
                Console.Write("It's Friday!");
                break;
            case 6:
                Console.Write("It's Saturday!");
                break;
            case 7:
                Console.Write("It's Sunday!");
                break;
        }
    }else{
        Console.WriteLine("There is no such day of the week.");
    }
}

void WeekDayEnd(int w){
    if(w > 0 && w <=5) Console.WriteLine(" Weekday.");
    if(w > 5 && w <=7) Console.WriteLine(" Weekend.");   
}

Console.Write("Enter the day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());

DayOfWeek(day);
WeekDayEnd(day);