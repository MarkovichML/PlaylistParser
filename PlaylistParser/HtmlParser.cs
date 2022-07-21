using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using Avalonia.Media.Imaging;
using PlaylistParser.XPathsClasses;

namespace PlaylistParser
{
    public class HtmlParser<T> where T : XPathContainer
    {
        #region Public Constructor

        public HtmlParser(T provider)
        {
            XPathProvider = provider;
        }

        #endregion

        #region Protected Properties

        protected T XPathProvider { get; }

        #endregion

        public PlaylistInformation Parse(string url)
        {
            PlaylistInformation pi;
            bool isPlaylist = IsPlaylist(url);
            
            if (isPlaylist)
                pi = GetPlaylist(url);
            else
                pi = GetAlbum(url);

            return pi;

        }
        private bool IsPlaylist(string url)
        {
            if (url.Contains("playlist"))
                return true;
            else return false;
        }
        
        private PlaylistInformation GetPlaylist(string url)
        {
            string html = string.Empty;
            PlaylistInformation pi = new PlaylistInformation();
            HtmlDocument document = new HtmlDocument();
            //HtmlWeb web = new HtmlWeb();
            using (WebClient client = new WebClient())
            {
                client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Safari/537.36");
                html = client.DownloadString(url);  
            }
            document.LoadHtml(html);
            HtmlNodeCollection htmlSongs = document.DocumentNode.SelectNodes(XPathProvider.XPathToSongs);
            for (int i = 1; i <= htmlSongs.Count; i++)
            {
                SongInformation songInfo = new SongInformation();

                songInfo.SongName = document.DocumentNode.SelectSingleNode(string.Format(XPathProvider.SongNameXPath, i)).InnerText.Replace("\n", "").Trim();
                songInfo.ArtistName = document.DocumentNode.SelectSingleNode(string.Format(XPathProvider.ArtistNameXPath, i)).InnerText.Replace("\n", "").Trim();
                songInfo.AlbumName = document.DocumentNode.SelectSingleNode(string.Format(XPathProvider.AlbumNameXPath, i)).InnerText.Replace("\n", "").Trim();
                songInfo.Duration = document.DocumentNode.SelectSingleNode(string.Format(XPathProvider.DurationXPath, i)).InnerText.Replace("\n", "").Trim();
                pi.SongInfo.Add(songInfo);
            }
            HtmlNode imageNode = document.DocumentNode.SelectSingleNode("//source");

            string[] imagePath = imageNode.GetAttributeValue("srcset", "Not found").Split(' ');

            WebClient c = new WebClient();
            byte[] responseData = c.DownloadData(imagePath[0]);
            Stream stream = new MemoryStream(responseData);
            
            pi.Description = document.DocumentNode.SelectSingleNode(XPathProvider.DescriptionXPath).InnerText.Replace("\n", "").Trim();
            pi.PlaylistName = document.DocumentNode.SelectSingleNode(XPathProvider.PlaylistNameXPath).InnerText.Replace("\n", "").Trim();
            
            pi.PlayListAvatar = Bitmap.DecodeToWidth(stream, 400);

            return pi;
        }

        private PlaylistInformation GetAlbum(string url)
        {
            PlaylistInformation pi = new PlaylistInformation();
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(url);
            
            HtmlNodeCollection htmlSongs = document.DocumentNode.SelectNodes(XPathProvider.XPathToSongs);
            string artistName = document.DocumentNode.SelectSingleNode(string.Format(XPathProvider.ArtistNameInAlbumXPath)).InnerText.Replace("\n", "").Trim();
            for (int i = 1; i <= htmlSongs.Count; i++)
            {
                SongInformation songInfo = new SongInformation();

                songInfo.SongName = document.DocumentNode.SelectSingleNode(string.Format(XPathProvider.SongNameXPath, i)).InnerText.Replace("\n", "").Trim();
                songInfo.Duration = document.DocumentNode.SelectSingleNode(string.Format(XPathProvider.DurationXPath, i)).InnerText.Replace("\n", "").Trim();
                songInfo.ArtistName = artistName;
                pi.SongInfo.Add(songInfo);
            }
            HtmlNode imageNode = document.DocumentNode.SelectSingleNode("//source");

            string[] imagePath = imageNode.GetAttributeValue("srcset", "Not found").Split(' ');

            WebClient c = new WebClient();
            byte[] responseData = c.DownloadData(imagePath[0]);
            Stream stream = new MemoryStream(responseData);
            
            pi.Description = document.DocumentNode.SelectSingleNode(XPathProvider.DescriptionXPath).InnerText.Replace("\n", "").Trim();
            pi.PlaylistName = document.DocumentNode.SelectSingleNode(XPathProvider.PlaylistNameXPath).InnerText.Replace("\n", "").Trim();

            pi.PlayListAvatar = Bitmap.DecodeToWidth(stream, 400);

            return pi;
        }
    }
}
