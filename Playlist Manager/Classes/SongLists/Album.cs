using Classes;
namespace SongLists
{
    /// <summary>
    /// Represents an album.
    /// </summary>
    public class Album : Songlist
    {
        /// <summary>
        /// The artist of the album.
        /// </summary>
        public string Artist { get; set; } = "Unknown";
        /// <summary>
        /// The band members of the album.
        /// </summary>
        public string[] BandMembers { get; set; } = new string[0];
        /// <summary>
        /// The release date of the album.
        /// </summary>
        public DateTime ReleaseDate { get; set; } = new DateTime(0);


        /// <inheritdoc />
        public Album(string title) : base(title)
        {
        }
        /// <summary>
        /// Creates a new album with the given title, artist, release date, band members, and songs.
        /// </summary>
        /// <param name="title">The title of the album.</param>
        /// <param name="artist">The artist of the album.</param>
        /// <param name="releaseDate">The release date of the album.</param>
        /// <param name="bandMembers">The band members of the album.</param>
        /// <param name="songs">The songs of the album.</param>
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

        /// <inheritdoc />
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