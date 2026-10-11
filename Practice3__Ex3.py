num1_input = input("Введите первое число: ")
num2_input = input("Введите второе число: ")

num1 = int(num1_input)
num2 = int(num2_input)

result = num1 + num2
print(f"Результат сложения: {result}")

#Дополнительное задание*
try:
    num1_input = input("Введите первое число: ")
    num2_input = input("Введите второе число: ")

    num1 = int(num1_input)
    num2 = int(num2_input)

    result = num1 + num2
    print(f"Результат сложения: {result}")

except ValueError:
    print("\nОшибка! Вы ввели некорректные данные.")
    print("Пожалуйста, вводите только целые числа.")