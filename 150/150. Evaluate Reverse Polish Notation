public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        foreach (string token in tokens) {
            if (int.TryParse(token, out int num)) {
                stack.Push(num);
            } else {
                int num2 = stack.Pop();
                int num1 = stack.Pop();
                switch (token) {
                    case "+":
                        stack.Push(num1 + num2);
                        break;
                    case "-":
                        stack.Push(num1 - num2);
                        break;
                    case "*":
                        stack.Push(num1 * num2);
                        break;
                    case "/":
                        stack.Push(num1 / num2);
                        break;
                }
            }
        }
        return stack.Pop();
    }
}
