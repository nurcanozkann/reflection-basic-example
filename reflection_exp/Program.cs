using System;
using System.Reflection;

namespace reflection_exp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(Transaction);

            Console.WriteLine("type name:{0}", type.Name);
            MethodInfo[] methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine("Method name:{0}", method.Name);

                foreach (var parameter in method.GetParameters())
                {
                    Console.WriteLine("Parameter name:{0}", parameter.Name);
                }
            }
        }
    }

    public class Transaction
    {
        int _x, _y;
        public Transaction(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int Addition()
        {
            return _x + _y;
        }

        public int Multiply()
        {
            return _x * _y;
        }

        public void Set(int a, int b)
        {
            Console.WriteLine("Set(int, int) called method");
            _x = a;
            _y = b;
            Show();
        }

        public void Set(double a, double b)
        {
            Console.WriteLine("Set(double, double) called method");
            _x = (int)a;
            _y = (int)b;

            Show();
        }

        public void Show()
        {
            Console.WriteLine("x value: " + _x + " y value: " + _y);
        }
    }
}
