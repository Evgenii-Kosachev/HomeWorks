/*
    Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7

    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

void SmallSumElements(int[,] array, int row){
    int[] rowS = new int[row];
    int smallElement = 0; 

    for(int i = 0; i < array.GetLength(0); i++){ 
        for(int j = 0; j < array.GetLength(1); j++){

            rowS[i] = rowS[i] + array[i, j];   
        }    
    }

    for(int k = 0; k < rowS.Length; k++){
        Console.WriteLine($"line {k + 1}: {rowS[k]}");

        if(rowS[smallElement] > rowS[k]) smallElement = k; 
    }
    Console.WriteLine($"The row with the smallest sum of elements: {smallElement + 1}.");
}

Console.WriteLine("Define a rectangular matrix: ");
Console.Write("rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("columns: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = new int[userRows, userColumns];

FillArray(matrix);
PrintArray(matrix);
SmallSumElements(matrix, userRows);