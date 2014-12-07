using System.IO;
using System.Net;

namespace FactorialEngine
{
    public class FactorialWebService : IFactorialWebService
    {
        public string GetFactorialFor(int n)
        {
            var url = string.Format("https://murmuring-ravine-8545.herokuapp.com/?n={0}", n);
            using (var responseStream = WebRequest.Create(url).GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(responseStream))
                {
                    return sr.ReadLine();
                }
            }
        }
    }
}