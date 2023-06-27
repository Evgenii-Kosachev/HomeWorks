/*
    Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

    1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
    6, 1, 33 -> [6, 1, 33]
*/

void FillArray(int[] arr, int length){
    for(int i = 0; i < length; i++){
        Console.Write("Enter " + (i + 1) + " number: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }    
}

void PrintArray(int[] arr, int length){
    Console.Write("Array {");
    for(int i = 0; i < length; i++){
        if(i < length -1) Console.Write(arr[i] + ", "); 
        if(i == length - 1) Console.Write(arr[i] + "};"); 
    }
}

Console.Write("Set the desired array length: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrayLength];

FillArray(array, arrayLength);
PrintArray(array, arrayLength);