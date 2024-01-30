class Solution(object):
    def evalRPN(self, tokens):
        """
        :type tokens: List[str]
        :rtype: int
        """
        stack = []
        for token in tokens:
            if token in ["+", "-", "*", "/"]:
                num2 = stack.pop()
                num1 = stack.pop()
                if token == "+":
                    stack.append(num1 + num2)
                elif token == "-":
                    stack.append(num1 - num2)
                elif token == "*":
                    stack.append(num1 * num2)
                else:  # token == "/"
                    stack.append(int(float(num1) / num2))  # This line ensures truncation towards zero
            else:
                stack.append(int(token))
        return stack.pop()
