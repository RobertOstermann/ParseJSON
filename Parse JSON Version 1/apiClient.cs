/* apiClient.cs
 * Author: Robert Ostermann
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Parse_JSON_Version_1
{
    /// <summary>
    /// Not really sure what this is?!?
    /// </summary>
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    /// <summary>
    /// This class makes a web request and returns a string.
    /// </summary>
    public class apiClient
    {
        /// <summary>
        /// The URL that is retrieved.
        /// </summary>
        public string endPoint { get; set; }
        /// <summary>
        /// Not really sure what this is?!?
        /// </summary>
        public httpVerb httpMethod { get; set; }
        /// <summary>
        /// Initialize the endpoint as an empty string.
        /// Initialize the httpMethod as a GET request call.
        /// </summary>
        public apiClient()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }
        /// <summary>
        /// Makes a request to the HTTP website.
        /// Utilizes multiple using statements to read
        /// in the response from the website.
        /// </summary>
        /// <returns>String retrieved from the website.</returns>
        public string makeRequest()
        {
            string responseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("Error Code: " + response.StatusCode.ToString());
                }
                //Process the response stream...(could be JSON, XML, HTML, etc...)
                using (Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            responseValue = reader.ReadToEnd();
                        }
                    }
                }
            }

            return responseValue;
        }
    }
}
