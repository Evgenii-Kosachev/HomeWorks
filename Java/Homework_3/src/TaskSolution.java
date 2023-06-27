/*
    1. Напишите программу, чтобы создать новый список массивов, добавить несколько цветов (строку) и вывести коллекцию на экран.
    2. Напишите программу для итерации всех элементов списка цветов и добавления к каждому символа '!'.
    3. Напишите программу для вставки элемента в список массивов в первой позиции.
    4. Напишите программу для извлечения элемента (по указанному индексу) из заданного списка.
    5. Напишите программу для обновления определенного элемента массива по заданному элементу.
    6. Напишите программу для удаления третьего элемента из списка массивов.
    7. Напишите программу для поиска элемента в списке массивов.
    8. Напишите программу для сортировки заданного списка массивов.
    9. Напишите программу для копирования одного списка массивов в другой.
*/

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class TaskSolution {
    public static void main(String[] args) {
        // 1. Напишите программу, чтобы создать новый список массивов, добавить несколько цветов (строку) и вывести коллекцию на экран.
        String[] data1 = {"Red", "Green", "Blue"};
        String[] data2 = {"Black", "White", "Orange"};
        String[] data3 = {"Yellow", "Grey", "Brown"};

        List<String> colors = new ArrayList<>(List.of(data1));
        colors.addAll(List.of(data2));
        colors.addAll(List.of(data3));
        System.out.printf("1. %s.\n", colors);

        // 2. Напишите программу для итерации всех элементов списка цветов и добавления к каждому символа '!'.
        System.out.print("2. ");
        colors.forEach((o) -> System.out.printf("%s! ", o));

        // 3. Напишите программу для вставки элемента в список массивов в первой позиции.
        colors.add(0, "Pink");
        System.out.printf("\n3. %s.\n", colors);

        // 4. Напишите программу для извлечения элемента (по указанному индексу) из заданного списка.
        String element = colors.get(9);
        System.out.printf("4. %s, element = \"%s\".\n", colors, element);

        // 5. Напишите программу для обновления определенного элемента массива по заданному элементу.
        String[] elementArray = {"Black", "BlackJack"};
        String[] temp = colors.toArray(new String[0]);
        for (int i = 0; i < temp.length; i++)  if (temp[i] == elementArray[0])  temp[i] = elementArray[1];

        colors.clear();
        colors.addAll(List.of(temp));
        System.out.printf("5. %s.\n", colors);

        // 6. Напишите программу для удаления третьего элемента из списка массивов.
        colors.remove(2);
        System.out.printf("6. %s.\n", colors);

        // 7. Напишите программу для поиска элемента в списке массивов.
        String elementList = "Red";
        if (colors.contains(elementList))  System.out.printf("7. Элемент \"%s\" в списке под индексом: %d.\n", elementList, colors.indexOf(elementList));
        else System.out.printf("7. Элемент \"%s\" в списке отсутствует.\n", elementList);

        // 8. Напишите программу для сортировки заданного списка массивов.
        Collections.sort(colors);
        System.out.printf("8. %s.\n", colors);

        // 9. Напишите программу для копирования одного списка массивов в другой.
        List<String> colors2 = new ArrayList<>(colors);
        System.out.printf("9. %s.", colors2);
    }
}
