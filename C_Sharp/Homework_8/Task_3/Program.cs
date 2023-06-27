/*
    Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

    массив размером 2 x 2 x 2

    12(0,0,0) 22(0,0,1)
    75(0,1,0) 31(0,1,1)
    45(1,0,0) 53(1,0,1)
    32(1,1,0) 23(1,1,1)
*/

// 3 задание не смог сделать.

void FillArray(int[,,] array){ 
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for(int k = 0; k < array.GetLength(2); k++){

                int temp = new Random().Next(10, 100);
                   
                if(array[i, j, k] == temp) FillArray(array);
                 
                if(array[i, j, k] == 0){
                    array[i, j, k] = temp;
                    FillArray(array);
                } 
            }
        }   
    }
}

void PrintArray(int[,,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for(int k = 0; k < array.GetLength(2); k++){
                
                Console.Write($"{array[i, j, k]}({i},{j},{k})  ");    
            }
            Console.WriteLine();
        }
        Console.WriteLine();   
    }    
}

int Test(int[,,] array){
    int copy = 0;

    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for(int k = 0; k < array.GetLength(2); k++){

                for(int x = 0; x < array.GetLength(0); x++){
                    for(int y = 0; y < array.GetLength(1); y++){
                        for(int z = k + 1; z < array.GetLength(2); z++){

                            if(array[i, j, k] == array[x, y, z]) copy++;
                        }
                    }
                }
            }
        }
    }
    return copy;
}

int[,,] matrix = new int[3, 3, 3];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine($"Копий: {Test(matrix)}");