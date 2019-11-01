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
            List<Park> parkList = new List<Park> ();
                foreach (JObject jo in jsonResponse) {
                    Park newPark = JsonConvert.DeserializeObject<Park> (jo.ToString ());
                    parkList.Add (newPark);
            }

            return parkList;
        }
    }
}
    