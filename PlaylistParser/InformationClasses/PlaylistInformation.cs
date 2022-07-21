using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Media.Imaging;
namespace PlaylistParser
{
    public class PlaylistInformation
    {
        #region Public Constructor

        public PlaylistInformation()
        {
            SongInfo = new List<SongInformation>();
        }

        #endregion

        public Bitmap PlayListAvatar { get; set; }
        public string Description { get; set; }
        public List<SongInformation> SongInfo { get; set; }
        public string PlaylistName { get; set; }
    }
}
