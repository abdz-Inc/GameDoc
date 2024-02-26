using GameDoc.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GameDoc.Services
{

    public class RestService : IRestService
    {
        HttpClient _httpClient;

        JsonSerializerOptions _serializerOptions;
        // public List<Game> Items { get; private set; }
        public ResponseModel ResponseModel_ { get; set; }


        public RestService()
        {
            _httpClient = new HttpClient();
            _serializerOptions = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
                
            };

        }

        public async Task<ObservableCollection<Game>> RefreshDataAsync()
        {

            ResponseModel_ = new ResponseModel();
            var key = "e782ee17d2f149c7885f0412903de121";
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"https://rawg.io/api/games?token=&key={key}");
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(content);
                    
                    ResponseModel_ = JsonSerializer.Deserialize<ResponseModel>(content, _serializerOptions
                        );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(ResponseModel_.Results);
            return ResponseModel_.Results;
        }

    }
}
