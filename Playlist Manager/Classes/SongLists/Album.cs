using Classes;
namespace SongLists
{
    public class Album : Songlist
    {
        public string Artist { get; set; } = "Unknown";
        public string[] BandMembers { get; set; } = new string[0];
        public DateTime ReleaseDate { get; set; } = new DateTime(0);
        public Album(string title) : base(title)
        {
        }
        public Album(string title, string artist, DateTime releaseDate, string[] bandMembers, params Song[] songs) : base(title, songs)
        {
            foreach (Song song in songs)
            {
                song.Album = this;
            }
            this.Artist = artist;
            ReleaseDate = releaseDate;
            BandMembers = bandMembers;
        }
        public Album(List<Song> songList, string title) : base(songList, title)
        {

        }

        /// <summary>
        /// This is used to display album information to the console
        /// </summary>
        /// <returns>A string containing the albums information</returns>
        public override string ToString()
        {
            return $"{Title} by {Artist}\nBand Members: \t{string.Join("\n\t\t", BandMembers)}\nRelease Date: \t{DateOnly.FromDateTime(ReleaseDate)}";
        }
    }
}