using System;

namespace Inheritance
{
	public class Text : PresentationObject
	{
		public int fontSize { get; set; }
		public string fontName { get; set; }

		public void AddHyperLink(string url)
		{
            Console.WriteLine("We Added hyperlink " + url);
		}
	}
}
