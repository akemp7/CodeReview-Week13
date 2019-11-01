using System.Threading.Tasks;
using RestSharp;

namespace ParksClient.Models
{
    class ApiHelper
    {
        public static async Task<string> ApiCall()
        {
            RestClient client = new RestClient("http://localhost:5000/api/ParksApi");
            RestRequest request = new RestRequest("/", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public static async Task<string> ApiCallParksList(string parks)
        {
            RestClient client = new RestClient("http://localhost:5000/api/ParksApi");
            RestRequest request = new RestRequest($"?parkList={parks}", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

         public static async Task<string> ApiPost(Park park)
        {
            RestClient client = new RestClient("http://localhost:5000/api/ParksApi");
            RestRequest request = new RestRequest("/", Method.POST);
            request.AddJsonBody(park);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public static async Task<string> ApiPut(int id, Park park)
        {
            RestClient client = new RestClient("http://localhost:5000/api/ParksApi");
            RestRequest request = new RestRequest($"/{id}", Method.PUT);
            request.AddJsonBody(park);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }
    }
}