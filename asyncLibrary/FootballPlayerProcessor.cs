using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace asyncLibrary
{
    public class FootballPlayerProcessor
    {
        public static async Task<FootballPlayerModel> LoadPlayerInformation(string url)
        {
            if(url == "")
            {
                //url = "http://www54.myfantasyleague.com/2018/export?TYPE=players&DETAILS=&SINCE=&PLAYERS=&JSON=1";
            }
            Console.WriteLine(url);
            using (HttpResponseMessage response = await apiAsyncClient.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Possible Response");
                    Console.WriteLine(response);
                    FootballResultModel playerModel = await response.Content.ReadAsAsync<FootballResultModel>();
                    return playerModel.players;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}