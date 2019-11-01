using System.Threading.Tasks;
using RestSharp;

namespace ParksClient.Models
{
    class ApiHelper
    {
        public static async Task<string> ApiCall()
        {
            RestClient client = new RestClient("http://localhost:5000/api/parks");
            RestRequest request = new RestRequest("/", Method.GET);
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }