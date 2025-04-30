using Mediateca.Domain.Model;

namespace Mediateca.Domain.Data;

public static class DataSeeder
{
    public static readonly List<Musician> Musicians =
    [
        new Musician { Id = 1, Name = "Alice Rivers", Description = "Талантливая автор-исполнительница из Австралии." },
        new Musician { Id = 2, Name = "Carlos Mendoza", Description = "Знаменитый мексиканский гитарист." },
        new Musician { Id = 3, Name = "Sophie Laurent", Description = "Французская поп-дива." },
        new Musician { Id = 4, Name = "Ivan Orlov", Description = "Российский неоклассический пианист." },
        new Musician { Id = 5, Name = "Hana Kobayashi", Description = "Японская инди-рок певица и композитор." },
        new Musician { Id = 6, Name = "Miles Parker", Description = "Американский джазовый саксофонист." },
        new Musician { Id = 7, Name = "Lea Dubois", Description = "Швейцарская певица фолк и кантри жанра." },
        new Musician { Id = 8, Name = "Victor Reyes", Description = "Испанский продюсер электронной музыки." },
        new Musician { Id = 9, Name = "Ayanda Ndlovu", Description = "Южноафриканская этно-джаз вокалистка." },
        new Musician { Id = 10, Name = "Jasper Collins", Description = "Британский экспериментальный барабанщик." }
    ];

    public static readonly List<Album> Albums =
    [
        new Album { Id = 1, Name = "Ocean's Lullaby", Year = 2017, MusicianId = 1 },
        new Album { Id = 2, Name = "Reflections", Year = 2021, MusicianId = 1 },
        new Album { Id = 3, Name = "Desert Wind", Year = 2015, MusicianId = 2 },
        new Album { Id = 4, Name = "Guitar Colors", Year = 2023, MusicianId = 2 },
        new Album { Id = 5, Name = "Paris by Night", Year = 2018, MusicianId = 3 },
        new Album { Id = 6, Name = "Étoile", Year = 2020, MusicianId = 3 },
        new Album { Id = 7, Name = "Northern Lights", Year = 2019, MusicianId = 4 },
        new Album { Id = 8, Name = "Winter Sonata", Year = 2022, MusicianId = 4 },
        new Album { Id = 9, Name = "The Butterfly Dream", Year = 2016, MusicianId = 5 },
        new Album { Id = 10, Name = "Tokyo Neon", Year = 2022, MusicianId = 5 },
        new Album { Id = 11, Name = "Blue Moon Jazz", Year = 2013, MusicianId = 6 },
        new Album { Id = 12, Name = "Soulful Street", Year = 2019, MusicianId = 6 },
        new Album { Id = 13, Name = "Mountain Song", Year = 2017, MusicianId = 7 },
        new Album { Id = 14, Name = "Wildflowers", Year = 2020, MusicianId = 7 },
        new Album { Id = 15, Name = "Digital Mirage", Year = 2018, MusicianId = 8 },
        new Album { Id = 16, Name = "Analog Age", Year = 2023, MusicianId = 8 },
        new Album { Id = 17, Name = "Ubuntu Spirit", Year = 2019, MusicianId = 9 },
        new Album { Id = 18, Name = "Lights of Durban", Year = 2022, MusicianId = 9 },
        new Album { Id = 19, Name = "Drumscapes", Year = 2014, MusicianId = 10 },
        new Album { Id = 20, Name = "Percussive Mind", Year = 2021, MusicianId = 10 }
    ];

    public static readonly List<Track> Tracks =
    [
        new Track { Id = 1, Name = "Seaglass Eyes", TrackNumber = 1, Time = "4:09", AlbumId = 1 },
        new Track { Id = 2, Name = "Moonlit Road", TrackNumber = 2, Time = "3:40", AlbumId = 1 },
        new Track { Id = 3, Name = "Echoes of Dawn", TrackNumber = 1, Time = "4:19", AlbumId = 2 },
        new Track { Id = 4, Name = "Paper Ships", TrackNumber = 2, Time = "3:55", AlbumId = 2 },
        new Track { Id = 5, Name = "Desert Waltz", TrackNumber = 1, Time = "5:22", AlbumId = 3 },
        new Track { Id = 6, Name = "Cactus Flower", TrackNumber = 2, Time = "4:15", AlbumId = 3 },
        new Track { Id = 7, Name = "Midnight in Oaxaca", TrackNumber = 1, Time = "4:47", AlbumId = 4 },
        new Track { Id = 8, Name = "Sunrise Samba", TrackNumber = 2, Time = "3:59", AlbumId = 4 },
        new Track { Id = 9, Name = "Montmartre Lights", TrackNumber = 1, Time = "3:33", AlbumId = 5 },
        new Track { Id = 10, Name = "Rouge Amour", TrackNumber = 2, Time = "4:22", AlbumId = 5 },
        new Track { Id = 11, Name = "Belle Nuit", TrackNumber = 1, Time = "4:03", AlbumId = 6 },
        new Track { Id = 12, Name = "Rêverie", TrackNumber = 2, Time = "3:42", AlbumId = 6 },
        new Track { Id = 13, Name = "Snow Path", TrackNumber = 1, Time = "4:59", AlbumId = 7 },
        new Track { Id = 14, Name = "Misty Lake", TrackNumber = 2, Time = "5:17", AlbumId = 7 },
        new Track { Id = 15, Name = "Frost Sonata", TrackNumber = 1, Time = "4:40", AlbumId = 8 },
        new Track { Id = 16, Name = "Crystal Forest", TrackNumber = 2, Time = "3:51", AlbumId = 8 },
        new Track { Id = 17, Name = "Cicada City", TrackNumber = 1, Time = "4:18", AlbumId = 9 },
        new Track { Id = 18, Name = "Whispering Wind", TrackNumber = 2, Time = "3:49", AlbumId = 9 },
        new Track { Id = 19, Name = "Shibuya Nights", TrackNumber = 1, Time = "4:07", AlbumId = 10 },
        new Track { Id = 20, Name = "Rainy Day Manga", TrackNumber = 2, Time = "3:45", AlbumId = 10 }
    ];
}
