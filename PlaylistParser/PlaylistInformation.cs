using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Controls;

namespace PlaylistParser
{
    class PlaylistInformation
    {
        public Image PlayListAvatar { get; set; }
        public string Description { get; set; }
        public List<SongInformation> SongInfo { get; set; }
        public string PlaylistName { get; set; }
    }
}
