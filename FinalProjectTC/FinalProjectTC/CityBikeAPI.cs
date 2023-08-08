using System;
using FinalProjectTC.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FinalProjectTC
{
	public class CityBikeAPI
	{
	    static async Task Main()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string apiUrl = "http://api.citybik.es/v2/networks";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        Root networksResponse = JsonConvert.DeserializeObject<Root>(jsonResponse);

                        
                        foreach (Network item in networksResponse.Networks)
                        {
                            Console.WriteLine($"ID: {item.Id}, Name: {item.Name}, Company: {item.Company}, Location: {item.Location}");
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine($"API request failed with status code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }

}


