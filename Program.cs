using System.Collections;

namespace TPLExample
{
    class ClassA
    {
        public ClassA() : this(23)
        { }

        public ClassA(int pValue)
        {
            Console.WriteLine(pValue);

        }
    }

    public class emp
    {
        public static int age = 40;
        public static int salary = 25000;

    }

    class Calculator
    {

        public int number1, number2;
        public Calculator(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }

        // Function to perform operation
        // By changing sign of integers
        public static Calculator operator -(Calculator c1)
        {
            c1.number1 = -c1.number1;
            c1.number2 = -c1.number2;
            return c1;
        }

        // Function to print the numbers
        public void Print()
        {
            Console.WriteLine("Number1 = " + number1);
            Console.WriteLine("Number2 = " + number2);
        }
    }
    class baseclass
    {
        public baseclass(int a)
        {
                
        }
        public void func1()
        {
            Console.WriteLine("baseclass func1");
        }
        public virtual void func2()
        {
            Console.WriteLine("baseclass func2");
        }
        public virtual void func3()
        {
            Console.WriteLine("baseclass func3");
        }
    }
    class derivedclass : baseclass
    {
        public derivedclass(int x) : base(x)
        {
                
        }
        new public void func1()
        {
            Console.WriteLine("derivedclass func1");
        }
        public override void func2()
        {
            Console.WriteLine("derivedclass func2");
        }
       new  public  void func3()
        {
            Console.WriteLine("derivedclass func3");
        }
    }

    class sample
    {
        public sample()
        {
            Console.WriteLine("constructor 1 called");
        }
        public sample(int x)
        {
            int p = 2;
            int u;
            u = p + x;
            Console.WriteLine("constructor 2 called");
        }
    }
    internal class Program : emp
    {
        new public static int salary = 50000;
        delegate void Printer();
        static void Main(string[] args)
        {
            sample s = new sample(4);
            sample t = new sample();
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
