using System;
using System.Collections.Generic;

public class ReversePolishNotation
{
    public string Convert(string infix)
    {
        var output = new List<string>();
        var stack = new Stack<string>();
        var operators = new Dictionary<string, int> {{ "+", 1 }, { "-", 1 }, { "*", 2 }, { "/", 2 }, { "sin", 1 }, { "(", 10 } };
        var str = "";

        foreach (char c in infix)
        {
            if (char.IsDigit(c))
            {
                output.Add(c.ToString());
                str = "";
            }
            else if (c == '(')
            {
                stack.Push(c.ToString());
                str = "";
            }
            else if (c == ')')
            {
                while (stack.Peek() != "(")
                {
                    output.Add(stack.Pop());
                }
                stack.Pop();
                str = "";
            }
            else if (operators.ContainsKey(c.ToString()))
            {
                while (stack.Count > 0 && operators[stack.Peek()] >= operators[c.ToString()])
                {
                    output.Add(stack.Pop());
                }
                stack.Push(c.ToString());
                str = "";
            }
            else
            {
                str += c;
                if (operators.ContainsKey(str.Trim()))
                {
                    while (stack.Count > 0 && operators[stack.Peek()] >= operators[str.Trim()])
                    {
                        output.Add(stack.Pop());
                    }
                    stack.Push(str);
                }

            }
        }

        while (stack.Count > 0)
        {
            output.Add(stack.Pop());
        }

        return string.Join(" ", output);
    }
}