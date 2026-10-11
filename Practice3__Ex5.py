shopping_list = ["milk", "bread", "apples", "cheese"]
shopping_list.append("bananas")
print(shopping_list)

unique_items = set(shopping_list)
print(unique_items)

#Да, выведенное множество отличается от списка.
#Во-первых, если бы у меня в списке shopping_list присутствовали дубликаты, то множество бы их убрало, так как все элементы множества уникальны.
#Во-вторых, в отличие от списка, множество не имеет порядка, поэтому элементы могут располагаться в разном порядке.