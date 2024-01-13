class Solution(object):
    def threeSumClosest(self, nums, target):
        nums.sort()
        closest_sum = sum(nums[:3])

        for i in range(len(nums) - 2):
            lo, hi = i + 1, len(nums) - 1

            while lo < hi:
                current_sum = nums[i] + nums[lo] + nums[hi]

                if abs(current_sum - target) < abs(closest_sum - target):
                    closest_sum = current_sum

                if current_sum < target:
                    lo += 1
                elif current_sum > target:
                    hi -= 1
                else:
                    return current_sum

        return closest_sum
