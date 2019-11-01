using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ParksClient.Models {
    public class Park {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public string Land { get; set; }
        public string State { get; set; }

        public static List<Park> GetParks() 
        {
            var apiCallTask = ApiHelper.ApiCall ();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray> (result);
            List<Park> parkList = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());
            return parkList;
        }

         public static Park PostPark(Park park)
        {
            var apiCallTask = ApiHelper.ApiCallParksList(park.Name);
            var result = apiCallTask.Result;
            JArray jresponse = JsonConvert.DeserializeObject<JArray>(result);
            List<Park> parkList = JsonConvert.DeserializeObject<List<Park>>(jresponse.ToString());
            Park newPark = parkList[0];
            var apiPutTask = ApiHelper.ApiPost(newPark.ParkId, newPark);
            return newPark;
        }
    }
}
    