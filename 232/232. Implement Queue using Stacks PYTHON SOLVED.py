class MyQueue(object):

    def __init__(self):
        self.stackPush = []
        self.stackPop = []

    def push(self, x):
        """
        :type x: int
        :rtype: None
        """
        self.stackPush.append(x)

    def pop(self):
        """
        :rtype: int
        """
        self.peek()
        return self.stackPop.pop()

    def peek(self):
        """
        :rtype: int
        """
        if not self.stackPop:
            while self.stackPush:
                self.stackPop.append(self.stackPush.pop())
        return self.stackPop[-1]

    def empty(self):
        """
        :rtype: bool
        """
        return len(self.stackPush) == 0 and len(self.stackPop) == 0
