using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BjGuaHaoRobot
{
    public class Hospital
    {
        public static List<Dictionary<String, String>> AllHospitals()
        {
            return null;
        }
        public static async Task<Dictionary<String, String>> GetAreas()
        {
            var request = HttpRequestFactory.GetRequest();
            var response = await request.GetStringAsync("/hp/qsearch.htm?areaId=-1&levelId=3&isAjax=true");
            Console.WriteLine(response);
            dynamic value = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response);

            return new Dictionary<String, String>();
        }
    }
}
