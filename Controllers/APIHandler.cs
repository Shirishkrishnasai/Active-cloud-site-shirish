using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Active_cloud_site_5.Models;


namespace FoodRecallEnforcements.APIHandlerManager
{
    public class APIHandler
    {
       
       
        static string BASE_URL = "https://api.fda.gov/food/enforcement.json?"; 
        static string API_KEY = "AIzaSyClzfrOzB818x55FASHvX4JuGQciR9lv7q"; 
       
        public Enforcements GetEnforcements(int num,HttpClient httpClient)
        {
            string FOOD_DATA_CENTRAL_API_PATH = BASE_URL + "api_key=" + API_KEY + "&search=report_date:[20040101+TO+20200410]&limit=100&skip="+ num;
            string enforcementData = "";

            Enforcements enforcement = null;

           
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(FOOD_DATA_CENTRAL_API_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    enforcementData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }

                if (!enforcementData.Equals(""))
                {
                    enforcement = JsonConvert.DeserializeObject<Enforcements>(enforcementData);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return enforcement;
        }
    }
}
