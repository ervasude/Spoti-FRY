using assignment2.Entities;
using assignment2.Services;

Console.WriteLine("Spotifry");

var song1 = new Songs("Into the Night", "Kohta Yamamato", "Kohta Yamamato", null);
var song2 = new Songs("Sonata No.6 in F Major", "L.Bethoveen", "Bethoveen", "Fazıl Say");
var song3 = new Songs("Anti Hero", "Taylor Swift", "Taylor Swift", null);
var song4 = new Songs("Day Is Done", "Peter, Paul and Mommy", "Warner Bros.-Seven Arts", "Peter Yarrow");
var song5 = new Songs("Angel Eyes", "ABBA", "Benny Andersson - Björn Ulvaeus", "Benny Andersson - Björn Ulvaeus");


var playlist1 = new Playlist(song1);
playlist1.AddSong(song2);
playlist1.AddSong(song3);
playlist1.AddSong(song4);
playlist1.AddSong(song5);

Console.WriteLine("Before Shuffle");
Console.WriteLine(playlist1.GetSongs());

playlist1.ShuffleSongs();

Console.WriteLine("\n\nAfter Shuffle");
Console.WriteLine(playlist1.GetSongs());


NotePadService notePadService = new();
notePadService.PlaylistToNotePad(playlist1);
