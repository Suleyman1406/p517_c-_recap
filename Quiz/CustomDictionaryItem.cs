using System;
namespace Quiz
{
	public class CustomDictionaryItem<T,G>
	{
		public T Key { get; set; }
		public G Value { get; set; }

		public CustomDictionaryItem(T key, G value)
		{
			Key = key;
			Value = value;
		}
	}
}

