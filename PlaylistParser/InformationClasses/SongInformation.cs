using HtmlAgilityPack;

namespace PlaylistParser
{
    public class SongInformation
    {
        #region Constructor

       
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
