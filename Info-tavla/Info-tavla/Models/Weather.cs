using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Info_tavla.Models
{
    public class Weather
    {
		public string key { get; set; }
		public string title { get; set; }
		public string summary { get; set; }
		public Alert[] alerts { get; set; }
		public Message[] messages { get; set; }
		public Districtview[] districtviews { get; set; }
		public Metadata[] metadata { get; set; }
	}

	public class Alert
	{
		public string type { get; set; }
		public string href { get; set; }
	}

	public class Message
	{
		public string type { get; set; }
		public string href { get; set; }
	}

	public class Districtview
	{
		public string key { get; set; }
		public Type[] types { get; set; }
	}

	public class Type
	{
		public string type { get; set; }
		public string href { get; set; }
	}

	public class Metadata
	{
		public Meteorology[] meteorology { get; set; }
		public Hydrology[] hydrology { get; set; }
		public Oceanography[] oceanography { get; set; }
	}

	public class Meteorology
	{
		public string type { get; set; }
		public string href { get; set; }
	}

	public class Hydrology
	{
		public string type { get; set; }
		public string href { get; set; }
	}

	public class Oceanography
	{
		public string type { get; set; }
		public string href { get; set; }
	}
}
