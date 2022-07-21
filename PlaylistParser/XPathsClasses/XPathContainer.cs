using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistParser.XPathsClasses
{
    public abstract class XPathContainer
    {
        public abstract string SongNameXPath { get; }
        public abstract string ArtistNameXPath { get; }
        public abstract string AlbumNameXPath { get; }
        public abstract string DescriptionXPath { get; }
        public abstract string DurationXPath { get; }
        public abstract string AlbumAvatarXPath { get; }
        public abstract string XPathToSongs { get; }
        public abstract string BaseLink { get; }
        public abstract string PlaylistNameXPath { get; }
        public abstract string ArtistNameInAlbumXPath { get; }


    }
}
