using Classes;
namespace SongLists
{
    public class Album : Songlist
    {
        public Album(string title) : base(title)
        {
        }

        public Album(string title, params Song[] songs) : base(title, songs)
        {
        }

        public Album(List<Song> songList, string title) : base(songList, title)
        {
        }
    }
}