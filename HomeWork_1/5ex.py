# Задайте двумерный массив из целых чисел. 
# Количество строк и столбцов задается с клавиатуры. 
# Отсортировать элементы по возрастанию слева направо и сверху вниз.


#Я не смог сделать сортировку....

from random import randint
m = int(input("Введите необходимое количество символов в строке:"))
n = int(input("Введите необходимое количество строк:"))
a = [[randint(1, 10) for j in range(m)] for i in range(n)]
print(a)
print("Итак, мы получили строки различных цифр. По заданию надо их отсортировать.")
input("Давай сам отсортируешь? Нажми Enter")
print(sorted(a))
input("Press Enter to exit")