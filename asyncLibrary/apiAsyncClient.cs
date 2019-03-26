/* apiAsyncClient.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace asyncLibrary
{
    /// <summary>
    /// Simple static class to help with the api handling.
    /// </summary>
    public static class apiAsyncClient
    {
        /// <summary>
        /// HTTPClient that allows for get requests.
        /// </summary>
        public static HttpClient ApiClient { get; set; }
        /// <summary>
        /// Initialized in the JSONParser class.
        /// Creates a new ApiClient, clears the headers, and accepts JSON headers.
        /// </summary>
        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
