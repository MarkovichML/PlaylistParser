using System.Collections.Generic;
using HtmlAgilityPack;
using System.Net;
using System.IO;
using System;

namespace PlaylistParser
{
    public class HtmlHelperForTidal
    {
        //HtmlWeb web;
        //HtmlDocument document;
        //SongInformation songInfo;
        //public override List<SongInformation> GetSongInformationInPlaylist(string url)
        //{
        //    web = new HtmlWeb();
        //    HtmlDocument document = web.Load(url);
        //    HtmlNodeCollection htmlSongs = document.DocumentNode.SelectNodes("//*[@data-test='tracklist-row']");
        //    List<SongInformation> songs = new List<SongInformation>();
        //    foreach (HtmlNode node in htmlSongs)
        //    {
        //        songInfo.SongName = node.SelectSingleNode("//*[@data-test='table-row-title']").InnerText;
        //        songInfo.ArtistName = node.SelectSingleNode("//*[@data-test='track-row-artist']").InnerText;
        //        songInfo.AlbumName = node.SelectSingleNode("//*[@data-test='track-row-album']").InnerText;
        //        songInfo.Duration = node.SelectSingleNode("//*[@data-test='duration']").InnerText;
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
        //    string artistName = document.DocumentNode.SelectSingleNode($"(//*[@class='product-creator typography-large-title'])").InnerText.Replace("\n", "").Trim();
        //    string albumName = document.DocumentNode.SelectSingleNode($"(//*[@class='product-name typography-large-title-semibold clamp-4'])").InnerText.Replace("\n", "").Trim();
        //    List<SongInformation> songs = new List<SongInformation>();
        //    for (int i = 1; i <= htmlSongs.Count; i++)
        //    {
        //        SongInformation songInfo = new SongInformation();

        //        songInfo.SongName = document.DocumentNode.SelectSingleNode($"(//*[@class='songs-list-row__song-name'])[{i}]").InnerText.Replace("\n", "").Trim();
        //        songInfo.ArtistName = artistName;
        //        songInfo.AlbumName = albumName;
        //        songInfo.Duration = document.DocumentNode.SelectSingleNode($"(//*[@class='songs-list__col songs-list__col--time typography-body'])[{i}]").InnerText.Replace("\n", "").Trim();
        //        songs.Add(songInfo);
        //    }

        //    return songs;
        //}
    }
}
