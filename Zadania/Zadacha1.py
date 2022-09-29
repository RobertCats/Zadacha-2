Задача №1

import time

buh = 6
number = int(input("Попробуем, введите цифру от 1 до 7\n"))

if number >= buh and number < 8:
    print("Сегодня выходной, а значит время ехать в бар!")
elif number > 0 and number < 6:
    print("Ну шо, сегодня будни а значит надо на работу. Не проспи :)")
else:
    print("Неужели сложная задача??? Просто ввести число от 1 до 7... Ты меня пугаешь.")
time.sleep(3)
end = input("Нажмите Enter для выхода\n")
