using System;
using FinalProjectTC.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FinalProjectTC
{
    public class CityBikeAPI
    {
        public static Root CallBikeAPI()
        {
            HttpClient client = new HttpClient(); //client

            string apiUrl = "http://api.citybik.es/v2/networks"; //endpoint

            string jsonResponse = client.GetStringAsync(apiUrl).Result; //calling endpoint with client


            Root networksResponse = JsonConvert.DeserializeObject<Root>(jsonResponse); //converting string into object

            return networksResponse;

        
            Console.WriteLine("Here are the Names and Locations of the CityBikes in the United States! : ");
            Console.WriteLine();

            foreach (Network network in networksResponse.Networks) //iterating through List of networks
            {

                if (network.Location.Country == "US")
                {

                    if (network.Location.Country == "US")
                    {

                        Console.WriteLine(network.Name);
                        Console.WriteLine(network.Location.City);

                    }
                    if (network.Ebikes == true)
                    {
                        Console.WriteLine("There are E-Bikes available at this location!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, there are no E-Bikes available at this location");
                    }

                    Console.WriteLine();
                    Console.WriteLine();


                }

            }

        }

    }
}

