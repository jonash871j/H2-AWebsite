using System;
using System.IO;
using System.Net;

namespace AWebsite.DataReaders
{
    public class WebReader : IDataRequest
    {
        public WebReader(string url = "")
        {
            Url = url;
        }

        public string Url { get; set; } 

        public string RequestData()
        {
            return GetResponseFromUrl();
        }

        /// <summary>
        /// Used to get web data from url
        /// </summary>
        /// <returns>All web data as a string</returns>
        private string GetResponseFromUrl()
        {
            try
            {
                // Makes a web request to the url
                WebRequest request = WebRequest.Create(Url);

                // Sets default credentails
                request.Credentials = CredentialCache.DefaultCredentials;

                // Gets the web response
                WebResponse response = request.GetResponse();

                string responseText = "";

                // Reads the web data
                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    responseText = reader.ReadToEnd();
                }

                // Closes the response
                response.Close();

                return responseText;
            }
            catch (Exception ex)
            {
                return $"Error couldn't get respone from {Url} : {ex.Message}";
            }
        }
    }
}
