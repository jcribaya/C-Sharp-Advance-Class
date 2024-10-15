using System.Collections.Generic;

namespace Indexers
{
	public class HttpCokie
	{
		private readonly Dictionary<string, string> _dictionary;

		public HttpCokie()
		{
			_dictionary = new Dictionary<string, string>();
		}

		public string this[string key] { 
			get { return _dictionary[key]; }
			set { _dictionary[key] = value; }
		}
	}
}
