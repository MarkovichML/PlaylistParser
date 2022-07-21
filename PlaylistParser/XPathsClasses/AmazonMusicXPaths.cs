using PlaylistParser.XPathsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistParser.XPathsClasses
{
    public class AmazonMusicXPaths : XPathContainer
    {
        public override string SongNameXPath => $"(//*[@class='songs-list-row__song-name'])";
        public override string ArtistNameXPath => $"(//*[@class='songs-list__col songs-list__col--artist typography-body'])";
        public override string AlbumNameXPath => $"(//*[@class='songs-list__col songs-list__col--album typography-body'])";
        public override string DescriptionXPath => "//*[@class='truncated-content-container']";
        public override string DurationXPath => "(//*[@class='songs-list__col songs-list__col--time typography-body'])";
        public override string AlbumAvatarXPath => "//source";
        public override string BaseLink => "music.apple.com";
        public override string XPathToSongs => "//*[@class='songs-list-row songs-list-row--web-preview web-preview songs-list-row--two-lines songs-list-row--song']";
        public override string PlaylistNameXPath => "//*[@class='product-name typography-large-title-semibold clamp-4']";

        public override string ArtistNameInAlbumXPath => "//*[@class='product-name typography-large-title-semibold clamp-4']";
    }
}
