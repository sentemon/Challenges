def high_and_low(numbers):
    # The implementation is a bit kludgy
    nums = []
    sln = ""

    for num in numbers.split():
        nums.append(int(num))
    
    max_min = max(nums), min(nums)

    for i in max_min:
        sln += str(i) + " "
    return sln[:-1]