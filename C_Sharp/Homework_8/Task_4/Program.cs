/*
    Задача 4: Заполните спирально массив 4 на 4.

    На выходе получается вот такой массив:

    1 2 3 4
    12 13 14 5
    11 16 15 6
    10 9 8 7
*/

void FillArray(int[,] array){
   
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){

            array[0, j] = j + 1;
            array[i, array.GetLength(1) - 1] = i + array.GetLength(0);
            array[array.GetLength(0) - 1, j] = array[i, array.GetLength(1) - 1] + (array.GetLength(0) - 1) - j;

            if(i > 0){
                array[i, 0] = array[array.GetLength(0) - 1, j] + (array.GetLength(0) + 2) - i - i;

                if(j < array.GetLength(1) - 1) array[array.GetLength(0) - 3, j] = array[i, 0] + j + j;

                if(i < array.GetLength(0) - 1) array[i, array.GetLength(1) - 2] = array[array.GetLength(0) - 3, j] + i + i - 2; 
                
                if(j > 0) array[array.GetLength(0) - 2, array.GetLength(1) - 3] = array[i, array.GetLength(1) - 2] + j + j;         
            } 
            Console.Write($"{array[i, j]} ");         
        }
        Console.WriteLine();     
    }
}            

int[,] matrix = new int[4, 4];

FillArray(matrix);