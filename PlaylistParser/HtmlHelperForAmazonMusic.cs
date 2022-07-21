using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PlaylistParser
{
    public class HtmlHelperForAmazonMusic
    {
        //SongInformation songInfo;
        //string htmlCode;
        //public override List<SongInformation> GetSongInformationInPlaylist(string url)
        //{
        //    ChromeOptions chromeOptions = new ChromeOptions();
        //    chromeOptions.AddArguments("headless");
        //    chromeOptions.AddArguments("user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/103.0.0.0 Safari/537.36");

        //    using (WebDriver browser = new ChromeDriver(chromeOptions))
        //    {
        //        browser.Url = url;
        //        Thread.Sleep(10000);
        //        htmlCode = browser.PageSource;
        //        var t = browser.FindElements(By.ClassName("content"));
        //    }
        //    HtmlDocument document = new HtmlDocument();
        //    document.LoadHtml(htmlCode);
        //    HtmlNodeCollection htmlSongs = document.DocumentNode.SelectNodes("//*[@class='.content.has-bottom-row']");
            
        //    List<SongInformation> songs = new List<SongInformation>();
        //    foreach (HtmlNode node in htmlSongs)
        //    {
        //        songInfo.SongName = node.SelectSingleNode("//*[@class='col1']").InnerText;
        //        songInfo.ArtistName = node.SelectSingleNode("//*[@class='col2']").InnerText;
        //        songInfo.AlbumName = node.SelectSingleNode("//*[@class='col3']").InnerText;
        //        songInfo.Duration = node.SelectSingleNode("//*[@class='col4']").InnerText;
        //        songs.Add(songInfo);
        //    }

        //    return songs;
        //}
        //public override PlaylistInformation GetPlaylistInformation(string url,bool value,bool value0)
        //{
        //    PlaylistInformation pi = new PlaylistInformation();
        //    pi.Description = "Hello";
        //    return pi;
        //}
        //public override List<SongInformation> GetSongInformationInAlbum(string url)
        //{
        //    HtmlWeb web = new HtmlWeb();
        //    HtmlDocument document = web.Load(url);
        //    HtmlNodeCollection htmlSongs = document.DocumentNode.SelectNodes("//*[@class='songs-list-row songs-list-row--web-preview web-preview songs-list-row--two-lines songs-list-row--song']");
        //    //string artistName = document.DocumentNode.SelectSingleNode($"(//*[@class='product-creator typography-large-title'])").InnerText.Replace("\n", "").Trim();
        //    //string albumName = document.DocumentNode.SelectSingleNode($"(//*[@class='product-name typography-large-title-semibold clamp-4'])").InnerText.Replace("\n", "").Trim();
        //    List<SongInformation> songs = new List<SongInformation>();
        //    for (int i = 1; i <= htmlSongs.Count; i++)
        //    {
        //        SongInformation songInfo = new SongInformation();

        //        songInfo.SongName = document.DocumentNode.SelectSingleNode($"(//*[@class='songs-list-row__song-name'])[{i}]").InnerText.Replace("\n", "").Trim();
        //        songInfo.Duration = document.DocumentNode.SelectSingleNode($"(//*[@class='songs-list__col songs-list__col--time typography-body'])[{i}]").InnerText.Replace("\n", "").Trim();
        //        songs.Add(songInfo);
        //    }

        //    return songs;
        //}
    }
}

