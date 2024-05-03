#!/bin/python3

import math
import os
import random
import re
import sys



if __name__ == '__main__':
    n = int(input().strip())

    arr = list(map(int, input().rstrip().split()))
 
    reversed_array = []
    
    for i in range(n):
        reversed_array.append(arr[n-i-1])
        
    # output_string = ''
    # for i in range(len(reversed_array)):
    #     output_string += str(reversed_array[i]) + ' '
        
    # print(output_string)
    
    print(' '.join(str(i) for i in reversed_array))
   
#Sample Input
#4
#1 4 3 2