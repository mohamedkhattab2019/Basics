#!/bin/python3

import math
import os
import random
import re
import sys

#
# Complete the 'largestRectangle' function below.
#
# The function is expected to return a LONG_INTEGER.
# The function accepts INTEGER_ARRAY h as parameter.
#

def largestRectangle(h):
    # Write your code here
    # define a stack has the index of bulding
    stack = []
    i,area=0,0
    h.append(0)
    while i < len(h) :
        # base case stack is empty or greater height is found
        if not stack or h[stack[-1]]< h[i] :
            print("yes1")
            # pushthe index of building into stack
            stack.append(i)
            print(stack)
            i += 1
        else:
            print("else")
            top = stack.pop()
            print("top = "+str(top) + "stack[-1] = " + str(stack[-1] if stack else i))
            area = max (area,h[top]*(i-stack[-1]-1 if stack else i))
            print("area:")
            print(area)
    return area
            

    
if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')

    n = int(input().strip())

    h = list(map(int, input().rstrip().split()))

    result = largestRectangle(h)

    fptr.write(str(result) + '\n')

    fptr.close()
