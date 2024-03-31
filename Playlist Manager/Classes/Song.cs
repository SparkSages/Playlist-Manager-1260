using System.Net.Http.Headers;
using SongLists;
namespace Classes
{
    /// <summary>
    /// Represents a song.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// The title of the song.
        /// </summary>
        public string Title { get; protected set; }
        /// <summary>
        /// The artist of the song.
        /// </summary>
        public string Artist { get; protected set; }
        /// <summary>
        /// The duration of the song.
        /// </summary>
        public TimeSpan Duration { get; protected set; } = new TimeSpan(0, 0, 0);
        /// <summary>
        /// The genre of the song.
        /// </summary>
        public Genre Genre { get; protected set; } = Genre.Other;
        /// <summary>
        /// The album the song belongs to.
        /// </summary>
        public Album Album { get; set; } = null;
        /// <summary>
        /// Creates a new song.
        /// </summary>
        /// <param name="title">The title of the song.</param>
        /// <param name="artist">The artist of the song.</param>
        /// <param name="duration">The duration of the song.</param>
        /// <param name="genre">The genre of the song.</param>
        public Song(string title, string artist, TimeSpan duration, Genre genre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
        }

        /// <summary>
        /// Display the song as a string without console commands
        /// </summary>
        public override string ToString()
        {
            if (Album != null)
            {
                return $"{Title} by {Artist}\n{Genre}\n({Duration})\nAlbum: {Album.Title}";
            }
            return $"{Title} by {Artist}\n{Genre}\n({Duration})";
        }
        /// <summary>
        /// Display the album of the song
        /// </summary>
        public string ListAlbum()
        {
            if (Album != null)
            {
                return Album.ToString();
            }
            return "This song does not belong to an album.";
        }
    }

}