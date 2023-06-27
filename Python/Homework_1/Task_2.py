''' Напишите программу, которая принимает на вход координаты точки (X и Y), и выдаёт номер четверти плоскости, в которой находится эта точка (или на какой оси она находится).
    Пример:
        x=34; y=-30 -> 4
        x=2; y=4-> 1
        x=-34; y=-30 -> 3
'''

def Quarter(x, y):
    if x > 0 and y > 0:
        return '1 quarter.'
    elif x < 0 and y > 0:
        return '2 quarter.'
    elif x < 0 and y < 0:
        return '3 quarter.'
    elif x > 0 and y < 0:
        return '4 quarter.'
    else:
        return 'Out of range.'

userX = float(input('Введите значение X: '))
userY = float(input('Введите значение Y: '))

print(Quarter(userX, userY))