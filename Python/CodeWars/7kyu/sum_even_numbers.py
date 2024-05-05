def sum_even_numbers(seq): 
    sumEven = 0
    for i in seq:
        if i % 2 == 0:
            sumEven += i
    return sumEven