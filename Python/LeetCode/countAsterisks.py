# 2315. Count Asterisks
class Solution:
    def countAsterisks(self, s: str) -> int:
        count = 0
        words = s.split("|")

        for i in range(len(words)):
            if i % 2 == 0:
                count += words[i].count("*")
        
        return count