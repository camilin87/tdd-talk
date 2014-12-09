using System.IO;
using System.Net;

namespace FactorialEngine
{
    public class WebServiceWrapper : IWebServiceWrapper
    {
        public string ReadUrl(string url)
        {
            using (var sr = new StreamReader(WebRequest.Create(url).GetResponse().GetResponseStream()))
            {
                return sr.ReadLine();
            }
        }
    }
}