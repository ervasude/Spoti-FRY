using System;
namespace assignment2.Entities
{
    internal class Playlist
    {
        public Guid Id { get; set; }

        private List<Songs> Songs { get; set; }

        private Random random;


        public Playlist(Songs firstSong)
        {
            Id = Guid.NewGuid();
            Songs = new List<Songs>();
            random = new();
            AddSong(firstSong);
        }

        public void AddSong(Songs songs)
        {
            if (songs != null)
            {
                Songs.Add(songs);
            }
        }

        public string GetSongs()
        {

            return string.Join("\n", Songs.Select(Songs => $" Title: {Songs.Title}"));

        }


        public void ShuffleSongs()
        {
            int shuffle = Songs.Count();

            while (shuffle > 0)
            {
                shuffle--;

                Songs songs = Songs[shuffle];

                int randomIndex = random.Next(shuffle);

                Songs swapSong = Songs[random.Next(shuffle)];

                Songs[shuffle] = swapSong;

                Songs[randomIndex] = songs;


            }

        }


    }
}

