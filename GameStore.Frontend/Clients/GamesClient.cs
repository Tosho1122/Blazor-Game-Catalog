namespace GameStore.Frontend.Clients;
using GameStore.Frontend.Models;

public class GamesClient
{
     private readonly List<GameSummary> games =
    [
        new()
        {
            Id = 1,
            Name = "Noita",
            Genre = "Rougue Like",
            Price = 19.99M,
            ReleaseDate = new DateOnly(2018,7,15),
        },

        new()
        {
            Id = 2,
            Name = "Hollow Knight",
            Genre = "Metroidvania",
            Price = 14.99M,
            ReleaseDate = new DateOnly(2017, 2, 24),
        },

        new()
        {
            Id = 3,
            Name = "Stardew Valley",
            Genre = "Farming Simulator",
            Price = 14.99M,
            ReleaseDate = new DateOnly(2016, 2, 26),
        },

        new()
        {
            Id = 4,
            Name = "Cyberpunk 2077",
            Genre = "Action RPG",
            Price = 59.99M,
            ReleaseDate = new DateOnly(2020, 12, 10),
        },

        new()
        {
            Id = 5,
            Name = "Celeste",
            Genre = "Platformer",
            Price = 19.99M,
            ReleaseDate = new DateOnly(2018, 1, 25),
        },

        new()
        {
            Id = 6,
            Name = "The Witcher 3: Wild Hunt",
            Genre = "Action RPG",
            Price = 39.99M,
            ReleaseDate = new DateOnly(2015, 5, 18),
        },

        new()
        {
            Id = 7,
            Name = "Sekiro: Shadows Die Twice",
            Genre = "Action-Adventure",
            Price = 59.99M,
            ReleaseDate = new DateOnly(2019, 3, 22),
        },

        new()
        {
            Id = 8,
            Name = "Control",
            Genre = "Action-Adventure",
            Price = 29.99M,
            ReleaseDate = new DateOnly(2019, 8, 27),
        },

        new()
        {
            Id = 9,
            Name = "Death Stranding",
            Genre = "Action",
            Price = 59.99M,
            ReleaseDate = new DateOnly(2019, 11, 8),
        },

        new()
        {
            Id = 10,
            Name = "Ori and the Blind Forest",
            Genre = "Platformer",
            Price = 19.99M,
            ReleaseDate = new DateOnly(2015, 3, 11),
        },

        new()
        {
            Id = 11,
            Name = "Monster Hunter: World",
            Genre = "Action RPG",
            Price = 29.99M,
            ReleaseDate = new DateOnly(2018, 1, 26),
        }

    ];


    private readonly Genre[] genres = new GenresClient().GetGenres();

    public GameSummary[] GetGamesList() =>[.. games];

    public void AddNewgame(GameDetails game)
    {
        Genre genre = GetGenreById(game.GenreId);

        var gameSummary = new GameSummary
        {
            Id = games.Count + 1,
            Name = game.Name,
            Genre = genre.Name,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };

        games.Add(gameSummary);
    }

    public GameDetails GetGame(int id)
    {
        GameSummary game = GetGameSummaryById(id);

        var genre = genres.Single(genre => string.Equals(
         genre.Name,
         game.Genre,
         StringComparison.OrdinalIgnoreCase));

        return new GameDetails
        {
            Id = game.Id,
            Name = game.Name,
            GenreId = genre.Id.ToString(),
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
    }

    public void UpdateGame(GameDetails updatedGame)
    {
        var genre = GetGenreById(updatedGame.GenreId);
        GameSummary existingGame = GetGameSummaryById(updatedGame.Id);

        existingGame.Name = updatedGame.Name;
        existingGame.Genre = genre.Name;
        existingGame.Price = updatedGame.Price;
        existingGame.ReleaseDate = updatedGame.ReleaseDate;
    }

    public void DeleteGame(int id)
    {
        var game = GetGameSummaryById(id);
        games.Remove(game);
    }
    private GameSummary GetGameSummaryById(int id)
    {
        var game = games.Find(game => game.Id == id);
        ArgumentNullException.ThrowIfNull(game);
        return game;
    }

    private Genre GetGenreById(string? id)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(id);
        return genres.Single(genre => genre.Id == int.Parse(id));
    }
}
