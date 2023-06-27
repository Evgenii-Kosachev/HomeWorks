/*
    Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4

    1 7 -> такого числа в массиве нет
*/

void FillAndPrintArray(int[,] array){

    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){

            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]} ");    
        }
       Console.WriteLine();
    }
}

void SearchElement(int[,] array, int row, int column){
    
    if(row < array.GetLength(0) + 1 && column < array.GetLength(1) + 1){
        Console.WriteLine($"Elemet: {array[row - 1, column - 1]}");
    } 
    else Console.WriteLine("Out of range.");
}

int[,] matrix = new int[3, 4];
FillAndPrintArray(matrix);

Console.WriteLine();
Console.WriteLine("Specify the position of the element: ");
Console.Write("row: ");
int userRow = Convert.ToInt32(Console.ReadLine());
Console.Write("column: ");
int userColumn = Convert.ToInt32(Console.ReadLine());

SearchElement(matrix, userRow, userColumn);