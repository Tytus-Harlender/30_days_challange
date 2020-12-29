using System.Collections.Generic;
using System.Xml.Serialization;

namespace Task3
{
	[XmlRoot(ElementName = "catalog")]
	public class Catalog
	{
		[XmlElement(ElementName = "book")]
		public List<Book> Book { get; set; }
	}
}
