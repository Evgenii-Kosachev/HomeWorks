''' Задача: Реализуйте случайное перемешивания списка.
    Пример:
        Исходный вариант -> ['Веселый пианист', 250, 3.14, 'True '] Результат -> [250, 3.14, 'True ', 'Веселый пианист']
'''
import random

list = ['Веселый пианист', 250, 3.14, 'True ']
random.shuffle(list)
print(list)