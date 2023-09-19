using Classes;
using SongLists;

Song song = new Song("Hero", "Skillet", new TimeSpan(0, 3, 23), Genre.Rock);
Song song1 = new Song("Wrecking ball", "Some girl", new TimeSpan(0, 3, 0), Genre.Pop);
Song song2 = new Song("Atomic", "Blondie", new TimeSpan(0, 3, 0), Genre.Pop);
Song song3 = new Song("Still Stranding", "Slimecicle", new TimeSpan(0, 3, 0), Genre.Other);

Playlist playlist = new Playlist("Playlist Title", song, song1, song2);

System.Console.WriteLine("This is the playlist before adding a song");

Console.ForegroundColor = ConsoleColor.Green;
playlist.DisplayPlaylist();

Console.ResetColor();
Console.ReadKey();
Console.Clear();

playlist.AddSong(song3);

System.Console.WriteLine("This is the first playlist after adding a song");
Console.ForegroundColor = ConsoleColor.Green;
playlist.DisplayPlaylist();

Console.ResetColor();
Console.ReadKey();


playlist.ShufflePlaylist();
System.Console.WriteLine("\n\n\nThis is the playlist after shuffling");
Console.ForegroundColor = ConsoleColor.Green;
Playlist shuffledPlaylist = new(playlist.ShufflePlaylist(), "Shuffled Playlist");
shuffledPlaylist.DisplayPlaylist();


Console.ResetColor();
Console.ReadKey();
Console.Clear();

System.Console.WriteLine("This is the song's album");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(song.ListAlbum());

Console.ResetColor();
Console.ReadKey();
Console.Clear();

System.Console.WriteLine("This is the song's album after setting the album");
Console.ForegroundColor = ConsoleColor.Green;

Album album = new Album("Album Title", "Artist", new DateTime(2020, 1, 1), new string[] { "Band Member 1", "Band Member 2" }, song, song1, song2, song3);

Console.WriteLine(song.ListAlbum());
Console.ResetColor();
Console.ReadKey();


Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine("Displaying information about a song");
System.Console.WriteLine(song1);
Console.WriteLine(song.ListAlbum());
Console.ResetColor();
Console.ReadKey();
Console.Clear();


Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine("Displaying information about an album");
System.Console.WriteLine(album);
Console.ResetColor();
Console.ReadKey();
Console.Clear();
