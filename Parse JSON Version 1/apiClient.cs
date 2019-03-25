using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Parse_JSON_Version_1
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public class apiClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }

        public apiClient()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }

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
