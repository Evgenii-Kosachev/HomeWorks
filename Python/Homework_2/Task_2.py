''' Задача: Напишите программу, которая принимает на вход число N и выдает набор произведений чисел от 1 до N.
    Пример:
        пусть N = 4, тогда [ 1, 2, 6, 24 ] (1, 12, 123, 1234)
'''
import math

userNumber = int(input('Enter any number: '))

for i in range(1, userNumber + 1):
    print(f'{i} - {math.factorial(i)}')