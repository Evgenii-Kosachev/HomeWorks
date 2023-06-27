''' Задача: Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр(отсекаем минус, считаем все в плюс).
    Пример:
        67,82 -> 23
        0,56 -> 11
'''
def SumOfNumbers(numb):
    if numb < 0: 
        numb *= -1

    sumLeft = 0
    sumRight = 0

    numbLeft = numb
    while int(numbLeft) != 0:
        sumLeft += int(numbLeft % 10)
        numbLeft /= 10

    numbRight = numb
    while int((numbRight * 10) % 10) != 0:
        sumRight += int((numbRight * 10) % 10)
        numbRight *= 10                             # При умножении на 10 (для смещения запятой), у некоторых чисел почему-то появляется "хвост". Не смог с ним ничего сделать.

    return (sumLeft + sumRight)

userNumber = float(input('Enter any number: '))

print(f'Sum: {SumOfNumbers(userNumber)}') 