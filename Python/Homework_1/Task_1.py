''' Задача: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    Пример:
        6 -> да
        7 -> да
        1 -> нет
'''
def DayOfWeek (day):
    if day == 1:
        print(f'Number {day} is Monday. Weekday.')
    elif day == 2:
        print(f'Number {day} is Tuesday. Weekday.')
    elif day == 3:
        print(f'Number {day} is Wednesday. Weekday.')
    elif day == 4:
        print(f'Number {day} is Thursday. Weekday.')
    elif day == 5:
        print(f'Number {day} is Friday. Weekday.')
    elif day == 6:
        print(f'Number {day} is Saturday. Weekend.')
    elif day == 7:
        print(f'Number {day} is Sunday. Weekend.')
    else:
        print('Out of range.')
    
userNumber = int(input('Enter number day of the week: '))

DayOfWeek(userNumber)