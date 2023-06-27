/*
    Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

    0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223-> 3
*/

void FillArray(int[] array){
    int userNumber;

    for (int i = 0; i < array.GetLength(0); i++){

        Console.Write($"Enter {i + 1} number : ");
        userNumber = Convert.ToInt32(Console.ReadLine());

        array[i] = userNumber;    
    }    
}

int PrintArray(int[] array){
    int result = 0;
    
    for (int i = 0; i < array.GetLength(0); i++){

        if(i == 0) Console.Write("Array {");
        if(i < array.GetLength(0) - 1) Console.Write($"{array[i]}, ");
        if(i == array.GetLength(0) - 1) Console.Write(array[i] + "};");

        if(array[i] > 0) result++;    
    }
    return result;
}

Console.WriteLine();
Console.Write("Set the length of the array: ");
int userArrayLength = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[userArrayLength];

FillArray(numbers);

Console.WriteLine($" {PrintArray(numbers)} number(s) bigger 0.");
Console.WriteLine();