using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace asyncLibrary
{
    public class MFLPlayerProcessor
    {
        /// <summary>
        /// This static async class awaits a response from the 
        /// apiAsyncClient and reads in the response as an ApiPlayerModel type.
        /// </summary>
        /// <param name="url">Website Address</param>
        /// <returns></returns>
        public static async Task<MFLPlayerModel.ApiAllPlayerObject> LoadPlayerInformation()
        {
            string playerURL = "http://www54.myfantasyleague.com/2018/export?TYPE=players&DETAILS=&SINCE=&PLAYERS=&JSON=1";

            using (HttpResponseMessage response = await apiAsyncClient.ApiClient.GetAsync(playerURL))
            {
                if (response.IsSuccessStatusCode)
                {
                    MFLPlayerModel playerModel = await response.Content.ReadAsAsync<MFLPlayerModel>();
                    return playerModel.Players;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<MFLPlayerModel.ApiRosterObject> LoadRosterInformation()
        {
            string rosterURL = "http://www54.myfantasyleague.com/2018/export?TYPE=rosters&L=30916&APIKEY=ahBp1sybvuKnx0emO1nIYDQeHLox&FRANCHISE=&JSON=1";
            
            using (HttpResponseMessage response = await apiAsyncClient.ApiClient.GetAsync(rosterURL))
            {
                if (response.IsSuccessStatusCode)
                {
                    MFLPlayerModel playerModel = await response.Content.ReadAsAsync<MFLPlayerModel>();
                    return playerModel.Rosters;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<MFLPlayerModel.ApiLeagueObject> LoadLeagueInformation()
        {
            string leagueURL = "http://www54.myfantasyleague.com/2018/export?TYPE=league&L=30916&APIKEY=ahBp1sybvuKnx0emO1nIYDQeHLox&JSON=1";

            using (HttpResponseMessage response = await apiAsyncClient.ApiClient.GetAsync(leagueURL))
            {
                if (response.IsSuccessStatusCode)
                {
                    MFLPlayerModel playerModel = await response.Content.ReadAsAsync<MFLPlayerModel>();
                    return playerModel.League;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
