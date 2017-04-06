using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BjGuaHaoRobot
{
    public class HttpRequestFactory
    {
        private readonly static HttpClient request;
        static HttpRequestFactory()
        {
            request = new HttpClient();
            request.BaseAddress = new Uri("http://www.bjguahao.gov.cn");
        }
        public static HttpClient GetRequest()
        {
            return request;
        }
    }
}
