public class MyQueue {
    private Stack<int> stackPush;
    private Stack<int> stackPop;

    public MyQueue() {
        stackPush = new Stack<int>();
        stackPop = new Stack<int>();
    }
    
    public void Push(int x) {
        stackPush.Push(x);
    }
    
    public int Pop() {
        if (stackPop.Count == 0) {
            while (stackPush.Count > 0) {
                stackPop.Push(stackPush.Pop());
            }
        }
        return stackPop.Pop();
    }
    
    public int Peek() {
        if (stackPop.Count == 0) {
            while (stackPush.Count > 0) {
                stackPop.Push(stackPush.Pop());
            }
        }
        return stackPop.Peek();
    }
    
    public bool Empty() {
        return stackPush.Count == 0 && stackPop.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
