/*
    Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

    [3 7 22 2 78] -> 76
*/

void FillArray(double[] arr, int length){
       
    for(int i = 0; i < length; i++){
        arr[i] = new Random().Next(0,100);

        if(i != length - 1) Console.Write(arr[i] + ", ");
        if(i == length - 1) Console.WriteLine(arr[i] + "};"); 
    }
}

double Difference(double[] arr, int length){
    double max = arr[0], min = arr[0];
    double diff = 0;

    for(int i = 0; i < length; i++){
        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
        diff = max - min;
    }
    return diff; 
}

double[] array = new double[4];
int lengthArray = array.Length;

Console.WriteLine();
Console.Write("Array {");

FillArray(array, lengthArray);
Console.WriteLine("Difference: " + Difference(array, lengthArray) + ".");