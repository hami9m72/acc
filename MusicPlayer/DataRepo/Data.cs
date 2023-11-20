using MusicPlayer.Model;
using MusicPlayer.Utils;
using MusicPlayer.View;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MusicPlayer.DataRepo
{
    public static class Data
    {
        #region setting
        public static string basePath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) + "/dplayer";
        public static List<string> localPath = new List<string>();
        public static string downloadPath = "";
        public static string karaokePath = "";
        public static string favouritePlaylistName = "Yêu thích";
        public static string recentPlaylistName = "Gần đây";
        public static List<Playlist> settingPlaylist = new List<Playlist>();

        public static void SaveSetting()
        {
            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);
            using (StreamWriter writetext = new StreamWriter(basePath + "/setting.txt"))
            {
                writetext.WriteLine(string.Join(";", localPath));
                writetext.WriteLine(downloadPath);
                writetext.WriteLine(karaokePath);
            }
        }

        public static void LoadSetting()
        {
            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);
            if (File.Exists(basePath + "/setting.txt"))
            {
                using (StreamReader readtext = new StreamReader(basePath + "/setting.txt"))
                {
                    localPath.AddRange(readtext.ReadLine().Split(';').ToArray());
                    downloadPath = readtext.ReadLine();
                    karaokePath = readtext.ReadLine();
                }
            }

        }
        #endregion

        public static List<Playlist> MyPlaylist = new List<Playlist>();
        public static void CreatePlayList(string name)
        {
            MyPlaylist.Add(new Playlist(name));
        }
        public static void AddSongToPlayList(int idx, Song song)
        {
            MyPlaylist[idx].files.Insert(0, song);
        }
        public static void DeleteSongToPlayList(int idx, Song song)
        {
            MyPlaylist[idx].files.Remove(song);
        }
        public static List<Song> GetAllSong(string byName)
        {
            HashSet<Song> list = new HashSet<Song>(new SongComparer());
            List<Playlist> allPlaylist = new List<Playlist>();
            allPlaylist.AddRange(MyPlaylist);
            allPlaylist.AddRange(settingPlaylist);
            foreach (var playlist in allPlaylist)
            {
                foreach (var song in playlist.files)
                {
                    string songName = song.GetTitle() == null ? "" : song.GetTitle().ToLower();
                    string artist = song.GetArtistNameJoined() == null ? "" : song.GetArtistNameJoined().ToLower();
                    string album = song.GetAlbumName() == null ? "" : song.GetAlbumName().ToLower();
                    string search = byName.ToLower();
                    if (songName.Contains(search) || artist.Contains(search) || album.Contains(search))
                    {
                        list.Add(song);
                    }
                }
            }
            return new List<Song>(list);
        }

        public static Playlist LoadLocalSong(List<string> paths, String name)
        {
            Playlist p = new Playlist();
            p.name = name;
            List<string> files = new List<string>();
            foreach (var path in paths)
            {
                var extensions = Helper.GetAllSupportFile();
                var temp = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories)
                                        .Where(f => extensions.Contains(Path.GetExtension(f).ToLower()))
                                        .ToArray();
                if (temp.Length > 0)
                    files.AddRange(temp);
            }
            if (files.Count > 0)
            {
                CultureInfo culture = new CultureInfo("vi-VN");
                files = files.OrderBy(f => Path.GetFileName(f), StringComparer.Create(culture, false)).ToList();
                List<Song> tmp = new List<Song>();
                for (int i = files.Count - 1; i > -1; i--)
                {
                    var tfile = TagLib.File.Create(files[i]);
                    SongLocal song = new SongLocal(tfile);
                    tmp.Add(song);
                }
                for (int i = tmp.Count - 1; i > -1; i--)
                    p.files.Add(tmp[i]);
            }
            settingPlaylist.Add(p);
            return p;
        }
        public static void SaveMyPlayList()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Playlists");
            xmlDoc.AppendChild(rootNode);

            foreach (var playlist in MyPlaylist)
            {
                XmlNode pNode = xmlDoc.CreateElement("Playlist");
                XmlAttribute attribute = xmlDoc.CreateAttribute("name");
                attribute.Value = playlist.name;
                pNode.Attributes.Append(attribute);

                foreach (var path in playlist.files.Select(e => e.GetSrc()))
                {
                    XmlNode pathNode = xmlDoc.CreateElement("Path");
                    pathNode.InnerText = path;
                    pNode.AppendChild(pathNode);
                }
                rootNode.AppendChild(pNode);
            }
            xmlDoc.Save(basePath + "/playlists.xml");
        }
        public static void LoadMyPlayList()
        {
            if (File.Exists(basePath + "/playlists.xml"))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(basePath + "/playlists.xml");
                XmlNodeList pNodes = xmlDoc.SelectNodes("//Playlist");
                foreach (XmlNode p in pNodes)
                {
                    Playlist playlist = new Playlist(p.Attributes["name"].Value);
                    foreach (XmlNode s in p.ChildNodes)
                    {
                        if (File.Exists(s.InnerText))
                        {
                            TagLib.File file = TagLib.File.Create(s.InnerText);
                            Song song = new SongLocal(file);
                            playlist.files.Add(song);
                        }

                    }
                    MyPlaylist.Add(playlist);
                }
            }
            InitDefaultPlaylist();
        }

        private static void InitDefaultPlaylist()
        {
            Boolean containsFavourite = false;
            Boolean containsRecent = false;
            foreach (var item in MyPlaylist)
            {
                if (item.name.Equals(favouritePlaylistName))
                {
                    containsFavourite = true;
                } else if (item.name.Equals(recentPlaylistName))
                {
                    containsRecent = true;
                }
            }
            if (!containsFavourite)
            {
                Playlist playlist = new Playlist(favouritePlaylistName);
                MyPlaylist.Add(playlist);
            }
            if (!containsRecent)
            {
                Playlist playlist = new Playlist(recentPlaylistName);
                MyPlaylist.Add(playlist);
            }
        }

        public class SongComparer : IEqualityComparer<Song>
        {
            public bool Equals(Song x, Song y)
            {
                // Check whether the compared objects reference the same data.
                if (Object.ReferenceEquals(x, y)) return true;

                // Check whether any of the compared objects is null.
                if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                    return false;

                // Check whether the objects' properties are equal.
                return x.GetTitle() == y.GetTitle();
            }

            public int GetHashCode(Song obj)
            {
                // Check whether the object is null
                if (Object.ReferenceEquals(obj, null)) return 0;

                // Get hash code for the Id field.
                return obj.GetTitle() == null ? 0: obj.GetTitle().GetHashCode();
            }
        }

    }
}
