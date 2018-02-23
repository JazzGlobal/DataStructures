using System;
using System.Collections.Generic;

namespace DataStructures
{
	public class Stack<T>
	{
		List<T> data;
		T Top;

		/// <summary>
		/// Push the specified item to the top of the stack
		/// </summary>
		/// <returns>The push.</returns>
		/// <param name="item">Item.</param>
		public void push(T item)
		{
			Top = item;

			if (data == null)
			{
				data = new List<T>();
				data.Add(item);
			}
			else
			{
				data.Add(item);
			}
		}
		/// <summary>
		/// Removes the item from the top of the stack
		/// </summary>
		public void pop()
		{
			if (data != null)
			{
				data.RemoveAt(data.Count - 1);
				if (data.Count > 0)
				{
					Top = data[data.Count - 1];
				}
				else
				{
					Top = default(T);
				}
			}
			else
			{
				throw new StackEmptyException("Stack is empty. Cannot call 'pop()'");
			}
		}
		/// <summary>
		/// Returns the item at the top of the stack
		/// </summary>
		/// <returns>The peek.</returns>
		public T peek()
		{
			if (Top == null)
			{
				throw new StackEmptyException("Stack is empty. Cannot call 'peek()'"); 
			}
			return Top;
		}
	}
	public class StackEmptyException : Exception
	{
		public StackEmptyException(String message) : base(message)
		{
		}
	}
}
