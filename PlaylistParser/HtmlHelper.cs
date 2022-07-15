using System.Collections.Generic;
using HtmlAgilityPack;
using System.Net;

namespace PlaylistParser
{
    public class HtmlHelper
    {
        SongInformation songInfo;
        public List<SongInformation> GetSongsInformation(string url)
        {
            NetworkCredential credentials = new NetworkCredential("markovichml13@gmail.com", "Marko28011111");
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load(url, "GET", new WebProxy(), credentials);
            HtmlNodeCollection htmlSongs = document.DocumentNode.SelectNodes("//*[@data-test='tracklist-row']");
            List<SongInformation> songs = new List<SongInformation>();
            foreach (HtmlNode node in htmlSongs)
            {
                songInfo = new SongInformation(node);
                songs.Add(songInfo);
            }

            return songs;
        }
    }
}
