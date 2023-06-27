''' Задача: Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
            Если остается 1 элемент без пары - умножаем его самого на себя.
    Пример:
        [2, 3, 4, 5, 6] => [12, 15, 16];
        [2, 3, 5, 6] => [12, 15]
'''
def MultiplicationOfNumbers (numbers):
    result = []

    for i in range(len(numbers) // 2):
        result.append(numbers[i] * numbers[((i + 1) * -1)])

    if len(numbers) % 2 != 0:
        result.append(numbers[len(numbers) // 2] ** 2)

    return result

list = [2, 3, 4, 5, 6]

print(MultiplicationOfNumbers(list))