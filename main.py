import math
import random as rd

n = int(input("후보 수 : "))
l = list(range(n + 1))[1:]
rd.shuffle(l)
flag = False

rnd = 1
while len(l) > 1:
    print("--------라운드 %d--------"%rnd)
    rnd += 1
    for i in range(len(l) // 2):
        flag = True
        while flag:
            flag = False
            d = int(input("     %d vs %d ? --> "%(l[i * 2], l[i * 2 + 1])))
            if l[i * 2] == d: l[i * 2 + 1] = 0
            elif l[i * 2 + 1] == d: l[i * 2] = 0
            else:
                print("     뒤질래? 다시해")
                flag = True
    nl = []
    for i in l:
        if i != 0: nl.append(i)
    rd.shuffle(nl)
    l = nl.copy()

print("--------1위는 : %d번!--------"%l[0])