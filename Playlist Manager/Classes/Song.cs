using System.Net.Http.Headers;
using SongLists;
namespace Classes
{

    public class Song
    {
        public string Title { get; protected set; }
        public string Artist { get; protected set; }
        public TimeSpan Duration { get; protected set; } = new TimeSpan(0, 0, 0);
        public Genre Genre { get; protected set; } = Genre.Other;
        public Album Album { get; set; } = null;

        public Song(string title, string artist, TimeSpan duration, Genre genre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            Genre = genre;
        }
        public override string ToString()
        {
            if (Album != null)
            {
                return $"{Title} by {Artist}\n{Genre}\n({Duration})\nAlbum: {Album.Title}";
            }
            return $"{Title} by {Artist}\n{Genre}\n({Duration})";
        }
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