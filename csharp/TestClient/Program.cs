using ServiceStack;
using SimonlineDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClient
{
    class Program
    {
        private static string url = "api.simonline.dk";
        public static JsonServiceClient authenticatedClient(int domain_id, string username, string password)
        {

            var jsonclient = new JsonServiceClient("https://" + url);
            jsonclient.StoreCookies = true;
            var response = jsonclient.Post<AuthenticationResponse>(new Authentication() { domain_id = domain_id, password = password, username = username });

            var headers = jsonclient.Headers.AllKeys;
            var cookie = new System.Net.Cookie("ss-id", response.session_id, "/", url);
            jsonclient.CookieContainer.Add(cookie);
            return jsonclient;
        }

        static void Main(string[] args)
        {
            try
            {
                var client = authenticatedClient(1, "username", "password");
                var response = client.Post<BasicResponse>(new Basic() { imsi = new List<long> { 238028210068987 } });


                var result = response;
            }
            catch (WebServiceException e)
            {
                //Fill in error handling
                Console.WriteLine("Something didnt work  handled response {0}, or big failure {1}", e.ResponseDto, e.Message + " " + e.ErrorCode );
            }
        }
    }
}
