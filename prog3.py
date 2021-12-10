import random

array = []
N = 5
n = 3
def prog3():
    
    total = 0 
    aux = 0 
    
    while aux < N:
        n = random.randint(1,100)
        array.append(n)
        aux = aux + 1
    print(array)
    size = aux
    for i in array:
        total = total + i
    
    average = total/size
    return average
#######program#####    
array_new = []
for i in range(n):
    array_new.append(prog3())


def small():
    smallest= array_new[0]
    print("smalles before program:",smallest)
    for i in array_new:
        if i < smallest:
            smallest = i
    return smallest

print("smallest after program:", small())
