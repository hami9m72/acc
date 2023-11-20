using MusicPlayer.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.Service
{
    public class MediaService
    {
        public static async Task<JObject> GetDataFromURL(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            // Add our custom headers
            requestMessage.Headers.Add("User-Agent", "PostmanRuntime/7.28.4");
            HttpResponseMessage response = await httpClient.SendAsync(requestMessage);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return JObject.Parse(await response.Content.ReadAsStringAsync());
            return null;
        }



        public static async Task<Lyric> GetSongLyric(string songId)
        {
            try
            {
                var data = await GetDataFromURL($"https://dat-zing-mp3-api.herokuapp.com/song/lyric/{songId}");
                if (data != null)
                    return JsonConvert.DeserializeObject<Lyric>(data.ToString());
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static async Task<string> GetSongStream(string songId)
        {
            try
            {
                var data = await GetDataFromURL($"https://dat-zing-mp3-api.herokuapp.com/song/stream/{songId}");
                return data["128"].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //public static async Task<List<Song>> GetSongs(List<string> lstID)
        //{
        //    List<Song> songs = new List<Song>();
        //    foreach (var id in lstID)
        //        songs.Add(await GetSongDetail(id));
        //    return songs;
        //}


    }
}
