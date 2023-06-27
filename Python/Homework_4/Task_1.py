''' Задание: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
    Пример:
        45 -> 101101
        3 -> 11
        2 -> 10
'''
def ConvertToBinary (number):
    list = []
    while number != 1:
        list.insert(0, number % 2)
        number //=  2
    if number <= 1: list.insert(0, number)
    print(*list)

userNumber = int(input('Enter any number: '))

ConvertToBinary(userNumber)