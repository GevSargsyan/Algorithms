
namespace AlgorithmsAndDataStructures
{
    internal static class Stacks
    {

        #region Recursion
        public static int Pow(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            return a * Pow(a, b - 1);
        }

        /* 
         a=2      .      b=3;
         => 2 * Pow(2,3 - 1);
         => 2 * Pow(2,2 - 1);
         => 2 * Pow(2,1 - 1);
         => 1;
         --------------------
         => 2 * (2 * (2 * 1));
         => 2 * (2 * 1);
         => 2 * 1;
         => 1; 
        */

        public static int Pow2(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            }

            if (b % 2 == 0)
            {
                int t = Pow2(a, b / 2);
                return t * t;
            }
            else
            {
                return a * Pow2(a, b - 1);
            }

        }

        /* 
         a=2      .      b=13;
         => 2 * Pow2(2,13 - 1);
         => Pow2(2,12 / 2) * Pow2(2,12 / 2);
         => Pow2(2,6 / 2) * Pow2(2,6 / 2);
         => 2 * Pow2(2,3 - 1);
         => Pow2(2,2 / 2) * Pow2(2,2 / 2); 
         => 2 * Pow2(2,1 - 1);
         => 1;
         --------------------
         => 2 * ((2 * (2 * 1)^2)^2)^2; => 8192
         => ((2 * (2 * 1)^2)^2)^2; => 4096
         => (2 * (2 * 1)^2)^2; => 64
         => 2 * (2 * 1)^2; => 8 
         => (2 * 1)^2; => 4
         => 2 * 1; => 2
         => 1; => 1
         
         2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 * 2 
         
         
         */

        #endregion

        #region CheckBracketEquality
        public static bool CheckBracketEquality(string str)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var c in str)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    if (c == ')' && stack.Peek() == '(')
                    {
                        stack.Pop();
                        continue;
                    }
                    if (c == ']' && stack.Peek() == '[')
                    {
                        stack.Pop();
                        continue;
                    }
                    if (c == '}' && stack.Peek() == '{')
                    {
                        stack.Pop();
                        continue;
                    }
                }
            }

            if (stack.Count > 0)
            {
                return false;
            }
            return true;
        }

        #endregion
    }
}
