/*
    Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4

    В итоге получается вот такой массив:

    1 2 4 7
    2 3 5 9
    2 4 4 8
*/

void FillArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){

            array[i, j] = new Random().Next(0, 10);
        }    
    } 
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){

            Console.Write($"{array[i, j]} ");    
        }
        Console.WriteLine();    
    }
    Console.WriteLine();
}

void IncreasingString(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){

            int minNumber = j;

            for(int k = j + 1; k < array.GetLength(1); k++){
                if(array[i, k] < array[i, minNumber]) minNumber = k;
            }

            int temp = array[i, minNumber];
            array[i, minNumber] = array[i, j];
            array[i, j] = temp;     
        }
    }
}

Console.WriteLine("Set the matrix: ");
Console.Write("rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("columns: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[userRows, userColumns];

FillArray(matrix);
PrintArray(matrix);
IncreasingString(matrix);
PrintArray(matrix);