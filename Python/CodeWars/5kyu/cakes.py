def cakes(recipe: dict = {}, avalible: dict = {}):
    array_keys_object: list = recipe.keys()
    array_num_of: list[int] = []
    for key in array_keys_object:
        if key in avalible:
            array_num_of.append(int(avalible[key]/recipe[key]))
        if key not in avalible:
            return 0
    return min(array_num_of)