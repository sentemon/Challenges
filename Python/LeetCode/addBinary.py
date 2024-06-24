# 67. Add Binary
class Solution:
    def addBinary(self, a: str, b: str) -> str:
            a = int(a, 2)
            b = int(b, 2)
            sum = bin(a + b)

            return sum[2:] # it's python lmao