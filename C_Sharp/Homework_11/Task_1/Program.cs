/*
    Дополнить решение домашней задачи прошлого семинара, добавив возможность ввода массивов info и data пользователем. Проработать возможные частные случаи несоответствия данных в этих массивах.
*/

void Exceptions(int[] data, int finish){

    if(data.Length > finish){
        for(int i = finish; i < data.Length; i++){
            if(i == finish) Console.Write($"The remaining part is \"data\": {data[i]}, ");
            if(i > finish && i < data.Length - 1) Console.Write($"{data[i]}, ");
            if(i == data.Length - 1) Console.Write($"{data[i]}.");   
        }
    }
    if(data.Length < finish){

        Console.WriteLine("There are not enough \"date\" values for \"info\".");   // Не смог избавиться от нулей  :(( 
    }
    Console.WriteLine();
}

int[] ConvertToDecimal(int[] info, int[] data){
    int binaryStart = 0, binaryFinish = 0;
    int[] result = new int[info.Length];

    for(int i = 0; i < info.Length; i++){
        int count = info[i];
        double temp = 0;

        binaryFinish = binaryStart + info[i];
        if(data.Length < binaryFinish) break; 
        for(int j = binaryStart; j < binaryFinish; j++){

            temp += data[j] * Math.Pow(2, --count);
        }
        binaryStart += info[i];

        result[i] = (int)temp;
    }
    Exceptions(data, binaryFinish);
    return result;
}

void FillArray(int[] array){
    for(int i = 0; i < array.Length; i++){

        Console.Write($"number {i + 1}: ");
        int number = Convert.ToInt32(Console.ReadLine());

        array[i] = number;    
    }
}

void PrintArray(int[] array, string name){
    for(int i = 0; i < array.Length; i++){

        if(i == 0) Console.Write(name + " {" + array[i] + ", ");
        if(i > 0 && i < array.Length - 1) Console.Write($"{array[i]}, ");
        if(i == array.Length - 1) Console.WriteLine(array[i] + "}");
    }
    Console.WriteLine();
}

string nameInfo= "info";
Console.Write("Set the length of the \"info\" array: ");
int infoLength = Convert.ToInt32(Console.ReadLine());
int[] info = new int[infoLength];
FillArray(info);
PrintArray(info, nameInfo);

string nameData= "data";
Console.Write("Set the length of the \"data\" array: ");
int dataLength = Convert.ToInt32(Console.ReadLine());
int[] data = new int[dataLength];
FillArray(data);
PrintArray(data, nameData);

string nameDecimal = "decimal";
PrintArray(ConvertToDecimal(info, data), nameDecimal);