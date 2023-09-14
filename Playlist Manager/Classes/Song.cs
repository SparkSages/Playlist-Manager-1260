using System.Net.Http.Headers;

namespace Classes
{

    public class Song
    {
        public string Title { get; protected set; }
        public string Artist { get; protected set; }
        public TimeSpan Duration { get; protected set; } = new TimeSpan(0, 0, 0);
        public Genre Genre { get; protected set; } = Genre.Other;
    }

}