''' Задача: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
    Пример:
        A (3,6); B (2,1) -> 5,09
        A (7,-5); B (1,-1) -> 7,21
'''
import math

def LengthTwoPoints (firstPointX, firstPointY, secondPointX, secondPointY):
    result = math.sqrt(math.pow((secondPointX - firstPointX), 2) + math.pow((secondPointY - firstPointY), 2))
    return math.trunc(result * 100) / 100

pointAx = float(input('Enter point Ax: '))
pointAy = float(input('Enter point Ay: '))
pointBx = float(input('Enter point Bx: '))
pointBy = float(input('Enter point By: '))

print(LengthTwoPoints(pointAx, pointAy, pointBx, pointBy))