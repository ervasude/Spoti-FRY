using System;
namespace assignment2.Entities
{
    public class Songs
    {
        public Songs(string title, string artist, string producer, string composer) : this()
        {
            Title = title;
            Artist = artist;
            Producer = producer;
            Composer = composer;
        }

        public Songs()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Artist { get; set; }

        public string Producer { get; set; }

        public string Composer { get; set; }
    }
}

