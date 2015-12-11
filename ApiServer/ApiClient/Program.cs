using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiClient
{
	class Program
	{
		static void Main(string[] args)
		{
			string url = "http://localhost:20494/api/Trails/0";
			HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			{
				using (StreamReader reader = new StreamReader(response.GetResponseStream()))
				{
					Trail trail = JsonConvert.DeserializeObject<Trail>(reader.ReadToEnd());
					Console.WriteLine(trail.Name);
				}
			}
		}
	}

	public class Trail
	{
		public string Name { get; set; }

		public int TrailId { get; set; }
	}
}
