using DoAnCSharp.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSharp.Service
{
    public class BaseService
    {
        protected async Task<JObject> GetDataFromURL(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            // Add our custom headers
            requestMessage.Headers.Add("User-Agent", "PostmanRuntime/7.28.4");
            HttpResponseMessage response = await httpClient.SendAsync(requestMessage);
            return JObject.Parse(await response.Content.ReadAsStringAsync());
        }

        public async Task<Song> GetSongDetail(string id)
        {
            try
            {
                var data = await GetDataFromURL($"https://dat-zing-mp3-api.herokuapp.com/song/full/{id}");
                return JsonConvert.DeserializeObject<Song>(data.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }
    }
}
