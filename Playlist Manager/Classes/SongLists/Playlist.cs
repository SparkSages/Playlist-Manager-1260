using Classes;
namespace SongLists
{
    public class Playlist : Songlist
    {
        public Playlist(string title) : base(title)
        {

        }

        public Playlist(string title, params Song[] songs) : base(title, songs)
        {

        }

        public Playlist(List<Song> songList, string title) : base(songList, title)
        {

        }




        /////////////////////////////////////////////////
        ///
        /// not sure what this method is meant to do yet.
        ///
        /////////////////////////////////////////////////
        public Song RetrieveSong(int index)
        {
            return SongList[index];
        }

        /// <summary>
        /// This method is used to display the playlist to the console
        /// </summary>
        public void DisplayPlaylist()
        {
            Console.WriteLine($"Playlist: {Title}");
            Console.WriteLine($"Total Runtime: {TotalRuntime}");
            foreach (Song song in SongList)
            {
                Console.WriteLine(song);
            }
        }

        /// <summary>
        /// This method is used to shuffle the playlist as a shallow copy
        /// </summary>
        /// <returns>A shuffled list of songs</returns>
        public List<Song> ShufflePlaylist()
        {
            DistinctRandom rand = new DistinctRandom(0, SongList.Count);
            List<Song> shuffledPlaylist = new List<Song>();
            foreach(Song song in SongList)
            {
                shuffledPlaylist.Add(SongList[rand.Next()]);
            }
            return shuffledPlaylist;
        }
    }
}