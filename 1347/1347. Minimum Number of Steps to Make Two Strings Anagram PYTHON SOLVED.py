        sCount = [0]*26
        tCount = [0]*26
        steps = 0

        for i in range(len(s)):
            sCount[ord(s[i]) - ord('a')] += 1
            tCount[ord(t[i]) - ord('a')] += 1

        for i in range(26):
            if tCount[i] < sCount[i]:
                steps += sCount[i] - tCount[i]

        return steps
