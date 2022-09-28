# Напишите простой калькулятор, который считывает с пользовательского ввода три строки: первое число, 
# второе число и операцию после чего применяет операцию к введённым числам 

def plus():
    reason = number1 + number2
    print(reason)

def minus():
    reason = number1 - number2
    print(reason)

def delete():
    reason = number1 / number2
    if number2 == 0:
        print("НА НОЛЬ ДЕЛИТЬ НЕЛЬЗЯ!!!")
    else:
        print(reason)

def umnog():
    reason = number1 * number2
    print(reason)

def mod():
    reason = mod(number1,number2)
    print(reason)

def pow():
    reason = number1 ** number2
    print(reason)

def div():
    reason = div(number1,number2)
    print(reason)



print("Пишем первый калькулятор на Phyton 3.0")
print("Итак, сейчас приведу список команд, которые можно использовать:")
print("+\n-\n/\n*\nmod\npow\ndiv\n ")

number1 = int(input("Давай зададим первое число\n"))
number2 = int(input("Давай зададим второе число\n"))
operation = input("А теперь, напиши какую операцию с числами ты хочешь сделать:\n")

if operation == "+":
    print(plus())
elif operation == "-":
    print(minus())
elif operation == "/":
    print(delete())
elif operation == "*":
    print(umnog())
elif operation == "mod":
    print(mod())
elif operation == "pow":
   print(pow())
elif operation == "div":
    print(div())
    


input("press Enter to exit")

