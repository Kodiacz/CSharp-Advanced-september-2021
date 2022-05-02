using System;
using System.Collections.Generic;

namespace MatchinBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> brackets = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    brackets.Push(i);
                }
                else if (input[i] == ')')
                {
                    brackets.Push(i);
                    int closingBracketIndex = brackets.Pop();
                    int openingBracketIndex = brackets.Pop();
                    int lenghtOfExprresion = closingBracketIndex - openingBracketIndex + 1;
                    string expression = input.Substring(openingBracketIndex, lenghtOfExprresion);
                    Console.WriteLine(expression);
                }
            }
        }
    }
}
