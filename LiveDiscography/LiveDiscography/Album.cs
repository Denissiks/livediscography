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
        string title;
        int releaseYear;
        string releaseMonth;
        int releaseDay;
        string releaseCountry;
        string recordLabel;
        string genre;
        int totalMinLength;
        int numberOfTracks;
        string albumArtist;

        public Album(string title, int releaseYear, string releaseMonth, int releaseDay, string releaseCountry, string recordLabel, string genre, int totalMinLength, int numberOfTracks, string albumArtist)
        {
            this.Title = title;
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

        public string Title { get => title; set => title = value; }
        public int ReleaseYear { get => releaseYear; set => releaseYear = value; }
        public int ReleaseDay { get => releaseDay; set => releaseDay = value; }
        public string ReleaseCountry { get => releaseCountry; set => releaseCountry = value; }
        public string RecordLabel { get => recordLabel; set => recordLabel = value; }
        public string Genre { get => genre; set => genre = value; }
        public int TotalMinLength { get => totalMinLength; set => totalMinLength = value; }
        public int NumberOfTracks { get => numberOfTracks; set => numberOfTracks = value; }
        internal string ReleaseMonth { get => releaseMonth; set => releaseMonth = value; }
        internal string AlbumArtist { get => albumArtist; set => albumArtist = value; }

       
    }

    
    

}
