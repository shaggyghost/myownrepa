number_str = input("Введите положительное четырехзначное целое число: ")

thousands = number_str[0]
hundreds = number_str[1]
tens = number_str[2]
ones = number_str[3]

print(f"Цифра в позиции тысяч равна {thousands}")
print(f"Цифра в позиции сотен равна {hundreds}")
print(f"Цифра в позиции десятков равна {tens}")
print(f"Цифра в позиции единиц равна {ones}")