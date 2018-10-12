using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveDiscography
{

    enum eAlbumType
    {
        Single,
        EP,
        Album
    }

    enum eMonth
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    class Album
    {
        int releaseYear;
        eMonth releaseMonth;
        int releaseDay;
        string releaseCountry;
        string recordLabel;
        string genre;
        int totalMinLength;
        int numberOfTracks;
        Artist albumArtist;

        public Album(int releaseYear, eMonth releaseMonth, int releaseDay, string releaseCountry, string recordLabel, string genre, int totalMinLength, int numberOfTracks, Artist albumArtist)
        {
            this.ReleaseYear = releaseYear;
            this.ReleaseMonth = releaseMonth;
            this.ReleaseDay = releaseDay;
            this.ReleaseCountry = releaseCountry;
            this.RecordLabel = recordLabel;
            this.Genre = genre;
            this.TotalMinLength = totalMinLength;
            this.NumberOfTracks = numberOfTracks;
            this.AlbumArtist = albumArtist;
        }

        public int ReleaseYear { get => releaseYear; set => releaseYear = value; }
        public int ReleaseDay { get => releaseDay; set => releaseDay = value; }
        public string ReleaseCountry { get => releaseCountry; set => releaseCountry = value; }
        public string RecordLabel { get => recordLabel; set => recordLabel = value; }
        public string Genre { get => genre; set => genre = value; }
        public int TotalMinLength { get => totalMinLength; set => totalMinLength = value; }
        public int NumberOfTracks { get => numberOfTracks; set => numberOfTracks = value; }
        internal eMonth ReleaseMonth { get => releaseMonth; set => releaseMonth = value; }
        internal Artist AlbumArtist { get => albumArtist; set => albumArtist = value; }
    }
}
