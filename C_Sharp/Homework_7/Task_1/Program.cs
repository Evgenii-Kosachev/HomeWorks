/*
    Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

    m = 3, n = 4.
    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9
*/

void FillMatrix(double[,] array){

    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){

            array[i, j] = new Random().Next(-100, 101);

            if(array[i, j] < 0){
                array[i, j] = array[i, j] * -1;
                array[i, j] = Math.Round(Math.Sqrt(array[i, j]), 1);
                array[i, j] = array[i, j] * -1; 
            }
            else array[i, j] = Math.Round(Math.Sqrt(array[i, j]), 1);   
        }
    }
}

void PrintMatrix(double[,] array){

    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){

            Console.Write($"({array[i, j]}) ");    
        }
        Console.WriteLine();
    }
}

Console.Write("Set the rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Set the columns: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double[,] matrix = new double[userRows, userColumns];

FillMatrix(matrix);
PrintMatrix(matrix);