using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace FosterCollector.Classes
{
	public class ItemsCollected
	{
		public long ID {get; set;}
		public string ItemDescription {get; set;}
		public double MinimumPrice { get; set; }
		public double MaximumPrice { get; set; }

		public ItemsCollected ()
		{
		}

		public override string ToString ()
		{
			return ItemDescription;
		}

		public static List<ItemsCollected> GetItemsCollected()
		{
			var assembly = typeof(App).GetTypeInfo().Assembly;
			Stream stream = assembly.GetManifestResourceStream("FosterCollector.TestItems.xml");

			List<ItemsCollected> itemList;

			using (var reader = new StreamReader (stream)) 
			{
				var serializer = new XmlSerializer(typeof(List<ItemsCollected>));
				itemList = (List<ItemsCollected>)serializer.Deserialize(reader);
			}

			return itemList;
		}
	}
}

