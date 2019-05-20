using System;

namespace lab5_1
{
	class Program
	{
		class A
		{
			public int a;
			public int b;
			public int C => a > b ? a - b : b - a;

			// Default constructor.
			public A()
			{
				a = 10;
				b = 15;
			}

			public A(int a, int b)
			{
				this.a = a;
				this.b = b;
			}
		}
		class B : A
		{
			public int d;
			public int C2 => a + b + d;

			public B() { }

			public B(int d)
			: this(d: d, a: 0, b: 0) { }

			public B(int a, int b, int d) : base(a, b) => this.d = d;

		}
		static void Main(string[] args)
			{
			A a = new A();
			Console.WriteLine(a.C);
			B b = new B(3);

			Console.WriteLine($"a = {b.a}, b = {b.b}, d = {b.d}");
		}
	
}
}