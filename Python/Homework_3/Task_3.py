''' Задача: Задайте список из вещественных чисел. Напишите программу, которая найдёт разницу между максимальным и минимальным значением дробной части элементов.
    Пример:
        [1.1, 1.2, 3.1, 5, 10.01] => 0.19
'''
import math

list = [1.1, 1.2, 3.1, 5, 10.01]

max = list[0] % 1
min = list[0] % 1

for i in list:
    i %= 1

    if max < i: max = i
    if min > i: min = i

print( (math.trunc((max - min) * 100)) / 100 )