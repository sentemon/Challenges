class Solution:
    @staticmethod
    def sortArray(nums: List[int]) -> List[int]:
        def merge(nums: List[int]) -> List[int]:
            if len(nums) == 1:
                return nums

            middle = len(nums) // 2
            left = merge(nums[:middle])
            right = merge(nums[middle:])

            return mergeTwoArray(left, right)

        def mergeTwoArray(a: List[int], b: List[int]) -> List[int]:
            result = []
            i = j = 0

            while i < len(a) and j < len(b):
                if a[i] < b[j]:
                    result.append(a[i])
                    i += 1
                else:
                    result.append(b[j])
                    j += 1

            if i < len(a):
                result += a[i:]
            if j < len(b):
                result += b[j:]

            return result
        
        return merge(nums)