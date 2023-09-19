
using System.Runtime.InteropServices;
using Classes;
namespace SongLists
{
    public abstract class Songlist
    {
        public List<Song> SongList { get; protected set; } = new List<Song>();
        public TimeSpan TotalRuntime { get; protected set; } = new TimeSpan(0, 0, 0);
        public string Title { get; protected set; } = "Untitled";


        /// <summary>
        /// This creates a new <see cref="Songlist"/> with the given <see cref="Title" and any number of <see cref="Song"/>s./>
        /// </summary>
        /// <param name="title">Title of the playlist</param>
        /// <param name="songs"><see cref="Song"/>s to add to the playlist</param>
        public Songlist(string title, params Song[] songs)
        {
            Title = title;
            foreach (Song song in songs)
            {
                TotalRuntime += song.Duration;
                SongList.Add(song);
            }
        }


        /// <summary>
        /// This creates a new <see cref="Songlist"/> with the given <see cref="Title"/> and a list of <see cref="Song"/>s./>
        /// </summary>
        /// <param name="songList">A list of <see cref="Song"/>s to add to the playlist.</param>
        /// <param name="title">Title of the playlist</param>
        public Songlist(List<Song> songList, string title)
        {
            SongList = songList;
            Title = title;
            foreach (Song song in SongList)
            {
                TotalRuntime += song.Duration;
            }
        }


        /// <summary>
        /// creates a new <see cref="Songlist"/> with the given <see cref="Title"/> and no initial songs
        /// </summary>
        /// <param name="title"></param>
        public Songlist(string title)
        {
            Title = title;
            TotalRuntime = new TimeSpan(0, 0, 0);
        }

        /// <summary>
        /// This method is used to add a <see cref="Song"/> to the playlist
        /// </summary>
        /// <param name="song">Song to add</param>
        private void AddSong(Song song)
        {
            SongList.Add(song);
            TotalRuntime += song.Duration;
        }

        /// <summary>
        /// This method is used to remove a <see cref="Song"/> from the playlist
        /// </summary>
        /// <param name="song">Song to remove</param>
        private void RemoveSong(Song song)
        {
            SongList.Remove(song);
            TotalRuntime -= song.Duration;
        }

    }
}