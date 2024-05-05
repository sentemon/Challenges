def matrix(array): 
    for i in range(len(array)):
        for j in range(len(array)):
            if i == j:
                if array[i][j] < 0:
                    array[i][j] = 0
                else:
                    array[i][j] = 1
    return array
