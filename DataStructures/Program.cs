using System;

namespace DataStructures
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Stack<String> wordStack = new Stack<String>();
			wordStack.push("hello");
			Console.WriteLine(wordStack.peek());
			wordStack.pop(); 
		}
	}
}
