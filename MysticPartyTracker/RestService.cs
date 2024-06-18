using MysticPartyTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Diagnostics;


namespace MysticPartyTracker
{
    class RestService
    {
        HttpClient _client;
        JsonSerializerOptions _serialzedOptions;

        public ObservableCollection<Response> Responses { get; set; }

        public RestService()
        {
            _client =  new HttpClient();
            _serialzedOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

        }

        public async Task<ObservableCollection<Response>> GetResultAsync()
        {
            Uri uri = new Uri("https://www.dnd5eapi.co/api/spells");
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Responses = JsonSerializer.Deserialize<ObservableCollection<Response>>(content, _serialzedOptions);

                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex);   
            }
            return Responses ?? [];



        }




    }
}
