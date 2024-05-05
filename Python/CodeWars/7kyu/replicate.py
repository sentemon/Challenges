@countcalls
def replicate(times, number) -> list:
    if times <= 0:
        return []
    return [number] + replicate(times - 1, number)