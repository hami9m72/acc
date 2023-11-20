using DoAnCSharp.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSharp.Service
{
    public class HomeService : BaseService
    {
        private JObject data;
        private string url = "https://dat-zing-mp3-api.herokuapp.com/home/1";
        public HomeService()
        {
        }

        public async Task<List<Song>> BanerSongs()
        {
            if (data == null)
                data = await GetDataFromURL(url);
            List<Song> songs = new List<Song>();
            int i = 0;
            foreach (var item in data["items"][0]["items"])
            {
                if (item["link"].ToString().Contains("bai-hat"))
                {
                    var temp = item["link"].ToString().Split(new char[] { '/', '.' });
                    string songID = temp[temp.Length - 2];
                    var song = await GetSongDetail(songID);
                    if (song != null)
                        songs.Add(song);
                    if (i++ == 3 || song == null) break;
                }

            }
            return songs;
        }

        public async Task<List<string>> BanerPicture()
        {
            if (data == null)
                data = await GetDataFromURL(url);
            List<string> result = new List<string>();
            foreach (var item in data["items"][0]["items"])
            {
                if (item.ToString().Contains("bai-hat"))
                    result.Add(item["banner"].ToString());
            }
            return result;

        }
    }
}
