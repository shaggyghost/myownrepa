n = int(input("Введите количество школьников: "))
k = int(input("Введите количество мандаринов: "))

mandarins_per_student = k // n
mandarins_left = k % n

print(f"\nКаждому школьнику достанется мандаринов: {mandarins_per_student}")
print(f"В корзине останется мандаринов: {mandarins_left}")