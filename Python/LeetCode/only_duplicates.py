def only_duplicates(st):
    char_count = {}

    for char in st:
        if char in char_count:
            char_count[char] += 1
        else:
            char_count[char] = 1

    result_str = ""

    for char in st:
        if char_count[char] > 1:
            result_str += char

    return result_str