using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Programt
    {
        public static void Main()

        {

            string expression = "1 + (3 + 2 - (2+3) * 4 - ((3+1)*(4-2)))";

            Stack<int> stack = new Stack<int>();

            bool correctBrackets = true;



            // обхождане на израза expression 

            for (int index = 0; index < expression.Length; index++)

            {

                char ch = expression[index];

                if (ch == '(') // ако изразът е отваряща скоба слагаме в стека индекса й 

                {

                    stack.Push(index);

                }

                else if (ch == ')')  // ако изразът е отваряща скоба 

                {

                    if (stack.Count == 0) // ако стекът е празен 

                    {

                        correctBrackets = false;

                        break;

                    }

                    stack.Pop();

                }

            }

            if (stack.Count != 0)

            {

                correctBrackets = false;

            }

            Console.WriteLine("Еднакъв ли е броят на фигурните скоби? " +

            correctBrackets);

        }
    }
}
