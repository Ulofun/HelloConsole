#2. Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.
#Простые делители числа
#Простые делители числа онлайн

#in
#54

#out
#[2, 3, 3, 3]

#in
#9990

#out
#[2, 3, 3, 3, 5, 37]

#in
#650

#out
#[2, 5, 5, 13]

print("Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.")

num = int(input("Введите число: "))
i = 2 # первое простое число
lst = []
old = num
while i <= num:
    if num % i == 0:
        lst.append(i)
        num //= i
        i = 2
    else:
        i += 1
print(f"Простые множители числа {old} приведены в списке: {lst}")