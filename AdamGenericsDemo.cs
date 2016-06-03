using System;

namespace Demo
{
	class Generic<T>
	{
		public string Add(T item)
		{
			if(item is string)
			{
				return item as string;
			}
			return item.ToString();
		}
	}
	
	class Program
	{
		static void Main()
		{
			Generic<string> a = new Generic<string>();
			Generic<int> b = new Generic<int>();
			Generic<char> c = new Generic<char>();
			
			Console.WriteLine(a.Add("Testing"));
			Console.WriteLine(b.Add(123));
			Console.WriteLine(c.Add('A'));
		}
	}
}