#Задача №3

list = [float(i) for i in input("введите посследовательность: ").split()]

#Второй вариант - не меняем список, ищем мин и макс самостоятельно
min_num = list [0]
max_num = 0

for n in list:
    n = n % 1
    if n != 0:
        if n > max_num: max_num = n
        if n < min_num: min_num = n

#первый вариант
i = 0
while i < len(list):
    list[i] = list[i] % 1
    if list[i] == 0: #фильтруем целые так как по условию 0 не является минимумом
        del list[i]
        continue
    i+=1

print ('ответ первого варианта: ', max(list)-min(list))
print ('ответ второго варианта: ', max_num-min_num)