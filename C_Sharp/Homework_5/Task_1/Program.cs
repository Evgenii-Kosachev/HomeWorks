/*
    Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

    [345, 897, 568, 234] -> 2
*/

void FillArray(int[] arr, int length){
       
    for(int i = 0; i < length; i++){
        arr[i] = new Random().Next(100,1000);

        if(i != length - 1) Console.Write(arr[i] + ", ");
        if(i == length - 1) Console.WriteLine(arr[i] + "};"); 
    }
}

int EvenNumber(int[] arr, int length){
    int number = 0;

    for(int i = 0; i < length; i++){
        if(arr[i] % 2 == 0) number++;   
    }
    return number; 
}

int[] array = new int[12];
int lengthArray = array.Length;

Console.WriteLine();
Console.Write("Array {");

FillArray(array, lengthArray);
Console.WriteLine("Even numbers: " + EvenNumber(array, lengthArray));