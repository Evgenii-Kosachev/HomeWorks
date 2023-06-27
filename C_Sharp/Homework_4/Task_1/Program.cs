/*
    Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

    3, 5 -> 243 (3⁵)
    2, 4 -> 16    
*/

double Exponentiation(double numbA, double numbB){
    double result = 0;
    for(int i = 0; i <= numbB; i++){
        result = Math.Pow(numbA, numbB);
    }
    return result;
}

Console.WriteLine();
Console.WriteLine("Enter two numbers: \"A\" and \"B\".");
Console.Write("A: ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.Write("B: ");
double numberB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\"A\" to the degree \"B\": " + Exponentiation(numberA, numberB));

Console.WriteLine();