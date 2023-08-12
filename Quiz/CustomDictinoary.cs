using System;
namespace Quiz
{
	public class CustomDictinoary<T, G>
	{
		CustomDictionaryItem<T,G>[] items;

		public CustomDictinoary()
		{
		
			items = new CustomDictionaryItem<T, G>[0];

        }

		public void Add(T key,G value)
		{
			if(items.ToList().Find(m => m.Key.Equals(key)) is not null)
			{
				throw new Exception("This key is already exist!");
			}
			Array.Resize(ref items, items.Length + 1);
			items[items.Length-1] = new CustomDictionaryItem<T, G>(key, value);
		}


		public void TryGetValue(T key,out G value)
		{
			var result = GetValue(key);
			value = result is null ? default : result.Value;
		}

		private CustomDictionaryItem<T,G>? GetValue(T key)
		{
			foreach (var item in items)
			{
				if (item.Key.Equals(key))
				{
					return item;
				}
			}
            return null;
		}

		public void RemoveItem(T key)
		{
			var listItem = GetValue(key);
			if (listItem is null)
			{
                Console.WriteLine("We cannot find element with your key!");
				return;
            }
            var itemList = items.ToList();
			itemList.Remove(listItem);
            Array.Resize(ref items, items.Length - 1);
            for (int i=0;i<itemList.Count; i++)
			{
				items[i] = itemList[i];
			}
		}
	}
}

