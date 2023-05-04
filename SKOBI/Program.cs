namespace SKOBI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите много скобок: ");
            string skobi = Console.ReadLine().Replace(" ", "");


            Stack<char> stack = new Stack<char>();
            bool real = true;

            foreach (var skob in skobi)
            {
                if (skob == '(' || skob == '{' || skob == '[')
                {
                    stack.Push(skob);
                }
                else if (stack.Count != 0)
                {
                    if ((skob == ')' && stack.Peek() != '(') || (skob == '}' && stack.Peek() != '{') || (skob == ']' && stack.Peek() != '['))
                        real = false;
                    else
                        stack.Pop();
                }
                else
                    real = false;
                
            }
            
            if (real)
                Console.WriteLine("Всё идеально");
            else
                Console.WriteLine("Мда...Неверно!");

            Console.ReadKey();
        }
    }
}