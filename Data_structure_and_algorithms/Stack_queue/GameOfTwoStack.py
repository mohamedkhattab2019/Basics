#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'twoStacks' function below.
#
# The function is expected to return an INTEGER.
# The function accepts following parameters:
#  1. INTEGER maxSum
#  2. INTEGER_ARRAY a
#  3. INTEGER_ARRAY b
#

def twoStacks(maxSum, a, b):
    # Write your code here
    # reverse elements in stack
    a = a[::-1]
    b = b[::-1]
    sum1=0;
    trials=0;
    handy_stack = []
    el_count = 0
    total = 0
    print(a[-1])
    while len(a) > 0:
        if total + a[-1] <= maxSum:
            print("yes1")
            temp = a.pop()
            handy_stack.append(temp)
            total += temp
            el_count += 1
        else:
            break
    total_b=0
    while len(b) > 0:
        if total_b + b[-1] <= maxSum:
            if total + b[-1]<= maxSum:
                temp=b.pop()
                total+=temp
                total_b+=temp
                el_count += 1
            else:
                temp = b.pop()
                total = total - handy_stack.pop() + temp
                total_b += temp                
        else:
            break
        
    return el_count
if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    g = int(input().strip())

    for g_itr in range(g):
        first_multiple_input = input().rstrip().split()

        n = int(first_multiple_input[0])

        m = int(first_multiple_input[1])

        maxSum = int(first_multiple_input[2])

        a = list(map(int, input().rstrip().split()))

        b = list(map(int, input().rstrip().split()))

        result = twoStacks(maxSum, a, b)

        fptr.write(str(result) + '\n')

    fptr.close()
