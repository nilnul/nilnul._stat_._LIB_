using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Globalization;

namespace nilnul.prob._rnd
{
	public class RandomOrg
	{
		static public async Task<string> GetIntAsync(int min, int max)
		{
			//var client =  HttpWebRequest.Create("https://www.random.org/integers/");
			var client = new HttpClient();//  WebClient();
			return  await  client.GetStringAsync($"https://www.random.org/integers/?num=1&min={min}&max={max}&col=1&base=16&format=plain&rnd=new");
		}


		static public  int GetInt(int min, int max)
		{
			return int.Parse(  GetIntAsync(min, max).Result);

		}
		

		static public  IEnumerable<int> GetList(int min, int max,int num)
		{
				//var client =  HttpWebRequest.Create("https://www.random.org/integers/");
			var client = new HttpClient();//  WebClient();
			return    client.GetStringAsync($"https://www.random.org/integers/?num={num}&min={min}&max={max}&col=1&base=16&format=plain&rnd=new").Result.Split(new[] { '\n' },StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x,NumberStyles.HexNumber)).ToArray();
		

		}

		static public  IEnumerable<int> GetListPerInterval(int min, int max)
		{
				//var client =  HttpWebRequest.Create("https://www.random.org/integers/");
			var client = new HttpClient();//  WebClient();
			return    client.GetStringAsync($"https://www.random.org/sequences/?min={min}&max={max}&col=1&base=16&format=plain&rnd=new").Result.Split(new[] { '\n' },StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x,NumberStyles.HexNumber)).ToArray();
		

		}


		static public  string GetListAsStr(int min, int max,int num)
		{
				//var client =  HttpWebRequest.Create("https://www.random.org/integers/");
			var client = new HttpClient();//  WebClient();
			return client.GetStringAsync($"https://www.random.org/integers/?num={num}&min={min}&max={max}&col=1&base=16&format=plain&rnd=new").Result;
		

		}


		

	}
}
