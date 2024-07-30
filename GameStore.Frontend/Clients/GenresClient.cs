using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GenresClient
{
    private readonly Genre[] genres = 
    [
        new()
        {
            Id = 1,
            Name = "Action"
        },
        
        new()
        {
            Id = 2,
            Name = "Adventure"
        },

        new()
        {
            Id = 3,
            Name = "RPG"
        },

        new()
        {
            Id = 4,
            Name = "Simulation"
        },

        new()
        {
            Id = 5,
            Name = "Strategy"
        },

        new()
        {
            Id = 6,
            Name = "Sports"
        },

        new()
        {
            Id = 7,
            Name = "Puzzle"
        },

        new()
        {
            Id = 8,
            Name = "Idle"
        },

        new()
        {
            Id = 9,
            Name = "Horror"
        },

        new()
        {
            Id = 10,
            Name = "Platformer"
        },

        new()
        {
            Id = 12,
            Name = "Rougue Like"
        },

        new()
        {
            Id = 13,
            Name = "Metroidvania"
        },

        new()
        {
            Id = 14,
            Name = "Farming Simulator"
        },

        new()
        {
            Id = 15,
            Name = "Action RPG"
        },

        new()
        {
            Id = 16,
            Name = "Action-Adventure"
        },
    ];

    public Genre[] GetGenres() => genres;
}
