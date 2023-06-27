/*
    Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
*/

void FillArray(int[] arr, int length){
       
    for(int i = 0; i < length; i++){
        arr[i] = new Random().Next(-99,100);

        if(i != length - 1) Console.Write(arr[i] + ", ");
        if(i == length - 1) Console.WriteLine(arr[i] + "};"); 
    }
}

int OddSum(int[] arr, int length){
    int number = 0;

    for(int i = 1; i < length; i += 2){
        number = number + arr[i];   
    }
    return number; 
}

int[] array = new int[4];
int lengthArray = array.Length;

Console.WriteLine();
Console.Write("Array {");

FillArray(array, lengthArray);
Console.WriteLine("Sum of odd numbers: " + OddSum(array, lengthArray)  + ".");