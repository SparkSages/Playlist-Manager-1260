
using Classes;
namespace SongLists
{
    public abstract class Songlist
    {
        public List<Song> songList { get; protected set; } = new List<Song>();
    }
}