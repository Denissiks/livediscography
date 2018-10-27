using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveDiscography
{
    class Song
    {
        string songName;
        string songAlbum;
        string songArtist;
        int minLength;
        int secLength;
        string genre;

        public Song(string songName, string songAlbum, string songArtist, int minLength, int secLength, string genre)
        {
            this.SongName = songName;
            this.SongAlbum = songAlbum;
            this.SongArtist = songArtist;
            this.MinLength = minLength;
            this.SecLength = secLength;
            this.Genre = genre;
        }

        public string SongName { get => songName; set => songName = value; }
        public string SongAlbum { get => songAlbum; set => songAlbum = value; }
        public string SongArtist { get => songArtist; set => songArtist = value; }
        public int MinLength { get => minLength; set => minLength = value; }
        public int SecLength { get => secLength; set => secLength = value; }
        public string Genre { get => genre; set => genre = value; }
    }
}
