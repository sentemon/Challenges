def smaller(arr):
    result = []
    
    for i in range(len(arr)):
        count = 0
        for j in range(i+1, len(arr)):
            if arr[j] < arr[i]:
                count += 1
        result.append(count)
        
    return result