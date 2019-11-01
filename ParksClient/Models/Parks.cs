using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ParksClient.Models {
    public class Park {
        public int ParkId { get; set; }
        public string Name { get; set; }
        public double Land { get; set; }
        public int State { get; set; }

        public static List<Park> GetParks() {
            var apiCallTask = ApiHelper.ApiCall ();
            var result = apiCallTask.Result;

            JArray jsonResponse = JsonConvert.DeserializeObject<JArray> (result);
            List<Park> parkList = JsonConvert.DeserializeObject<List<Park>>(jsonResponse.ToString());
            return parkList;
        }