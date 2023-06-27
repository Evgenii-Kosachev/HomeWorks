/*
    Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. 
              Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.

    3, 4 ->
    1 1 1 1
    1 0 0 1
    1 1 1 1
*/

void FillArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){

            if(i == 0 || j == 0 
               || i == array.GetLength(0) - 1 
               || j == array.GetLength(1) - 1) Console.Write($"{array[i, j] = 1} ");
            else Console.Write($"{array[i, j]} ");    
        }
        Console.WriteLine();    
    }
}

Console.Write("Rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] table = new int[rows, columns];

FillArray(table); 