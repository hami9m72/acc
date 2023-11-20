using DoAnCSharp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCSharp.Service
{
    public class MediaService : BaseService
    {
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

        public async Task<Lyric> GetSongLyric(string id)
        {
            try
            {
                var data = await GetDataFromURL($"https://dat-zing-mp3-api.herokuapp.com/song/lyric/{id}");
                return JsonConvert.DeserializeObject<Lyric>(data.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<Streaming> GetSongStream(string id)
        {
            try
            {
                var data = await GetDataFromURL($"https://dat-zing-mp3-api.herokuapp.com/song/stream/{id}");
                return JsonConvert.DeserializeObject<Streaming>(data.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
