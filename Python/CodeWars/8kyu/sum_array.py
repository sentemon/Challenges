def sum_array(arr):
    if (arr == None or len(arr) <= 1):
        return 0
    
    min_num = min(arr)
    max_num = max(arr)
    
    return sum(arr) - (min_num + max_num)