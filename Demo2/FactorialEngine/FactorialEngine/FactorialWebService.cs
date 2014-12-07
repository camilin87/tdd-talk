using System.IO;
using System.Net;

namespace FactorialEngine
{
    public class FactorialWebService : IFactorialWebService
    {
        public string GetFactorialFor(string url)
        {
            using (var sr = new StreamReader(WebRequest.Create(url).GetResponse().GetResponseStream()))
            {
                return sr.ReadLine();
            }
        }
    }
}