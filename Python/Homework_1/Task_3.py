'''Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).'''

def Quarter(number):
    if number == 1:
        return 'x > 0 and y > 0'
    elif number == 2:
        return 'x < 0 and y > 0'
    elif number == 3:
        return 'x < 0 and y < 0'
    elif number == 4:
        return 'x > 0 and y < 0'
    else:
        return 'Out of range.'

userNumber = int(input('Enter the quarter number: '))

print(Quarter(userNumber))