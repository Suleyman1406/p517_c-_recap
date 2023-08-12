using System;
namespace Quiz
{
	public class CustomList<T>
	{
		T[] items;

		public CustomList()
		{
			items = new T[0];
		}

		public void Add(T item)
		{
			Array.Resize(ref items, items.Length + 1);
			items[items.Length - 1] = item;
		}

		public T[] GetItems()
		{
			return items;
		}

		public void Print()
		{
			foreach(T item in items)
			{
				Console.Write(item + ", ");
			}
			Console.WriteLine();
		}
	}
}

