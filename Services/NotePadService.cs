using System;
using assignment2.Entities;

namespace assignment2.Services
{
    internal class NotePadService
    {
        public void PlaylistToNotePad(Playlist playlist)
        {
            //File.WriteAllText("/Users/ervasude/Belge/Playlist.txt", data);

            string directory = $@"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName}\Playlists";

            if (!File.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string saveFile = Path.Combine(directory, $"{playlist.Id}.text");

            File.WriteAllText(saveFile, playlist.GetSongs());

            Console.WriteLine("Data Successfully Saved to NotePad!");
        }


    }
}

