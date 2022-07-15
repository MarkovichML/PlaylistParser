using HtmlAgilityPack;

namespace PlaylistParser
{
    public class SongInformation
    {
        #region Constructor

        public SongInformation(HtmlNode node)
        {
                SongName = node.SelectSingleNode("//*[@data-test='table-row-title']").InnerText;
                ArtistName = node.SelectSingleNode("//*[@data-test='track-row-artist']").InnerText;
                AlbumName = node.SelectSingleNode("//*[@data-test='track-row-album']").InnerText;
                Duration = node.SelectSingleNode("//*[@data-test='duration']").InnerText;
        }
        public SongInformation()
        {

        }

        #endregion

        #region Properties

        public string SongName { get; set; }
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public string Duration { get; set; }

        #endregion
    }
}
