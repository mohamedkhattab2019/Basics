#!/user/bin/env python3

# from tracemalloc import start


def partiton(arr,start,end):
    pivot   = arr[start]  ## 
    low     = start+1
    high    = end

    while True:
         # If the current value we're looking at is larger than the pivot
        # it's in the right place (right side of pivot) and we can move left,
        # to the next element.
        # We also need to make sure we haven't surpassed the low pointer, since that
        # indicates we have already moved all the elements to their correct side of the pivot
                
        # Decrement the end pointer till it finds an
        # element less than pivot
        while low <= high and arr[high] >= pivot:
            high-=1
        # Increment the start pointer till it finds an
        # element greater than  pivot
        while low <= high and arr[low] <= pivot:
            low+=1
        if low <= high:
            arr[low],arr[high]=arr[high],arr[low]
            print(arr)

        else:
            break
    arr[start],arr[high]=arr[high],arr[start]
    return high

def quickSort(arr,start,end):
    if start > end:
        return 
    p=partiton(arr,start,end)
    quickSort(arr,start,p-1)
    quickSort(arr,p+1,end)


array = [29,99,27,41,66,28,44,78,87,19,31,76,58,88,83,97,12,21,44]
print(array)
quickSort(array, 0, len(array) - 1)
print(array)

# class Person:
#     def __init__(self, name, age):
#         self.name = name
#         self.age = age

#     def __str__(self):
#         return self.name

# def partition(array, start, end, compare_func):
#     pivot = array[start]
#     low = start + 1
#     high = end

#     while True:
#         while low <= high and compare_func(array[high], pivot):
#             high = high - 1

#         while low <= high and not compare_func(array[low], pivot):
#             low = low + 1

#         if low <= high:
#             array[low], array[high] = array[high], array[low]
#         else:
#             break

#     array[start], array[high] = array[high], array[start]

#     return high
# def quick_sort(array, start, end, compare_func):
#     if start >= end:
#         return

#     p = partition(array, start, end, compare_func)
#     quick_sort(array, start, p-1, compare_func)
#     quick_sort(array, p+1, end, compare_func)

# p1 = Person("Dave", 21)
# p2 = Person("Jane", 58)
# p3 = Person("Matthew", 43)
# p4 = Person("Mike", 21)
# p5 = Person("Tim", 10)
# array = [p1,p2,p3,p4,p5]
# quick_sort(array, 0, len(array) - 1,lambda x,y:x.age>y.age)
# for person in array:
#     print(person)    
