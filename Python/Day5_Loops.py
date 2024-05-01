#!/bin/python3

import math
import os
import random
import re
import sys



if __name__ == '__main__':
    n = int(input().strip())
    
    for item in range(1, 11):
        product = n * item
        print(f"{n} x {item} = {product}")
