using System.Text.Json.Nodes;
using static System.Net.WebRequestMethods;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        RonVSKanyeAPI.yeSays();
            //    }
            //    else
            //    {
            //        RonVSKanyeAPI.ronSays();
            //    }
            //}

            OpenWeatherMapAPI.getWeatherAsync();
        }
    }
}
