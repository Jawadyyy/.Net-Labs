using HoopMetrics.Models;

namespace HoopMetrics.Services;

public class PlayerService : IPlayerService
{
    private List<Player> _players = new()
    {
        new Player {
            Id = 1,
            Name = "LeBron James",
            Age = 38,
            Position = "SmallForward",
            Nationality = "USA",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/2544.png",
            PerformanceStats = new PerformanceStats { PointsScored = 28, Assists = 7, Rebounds = 8 },
            FitnessStats = new FitnessStats { MinutesPlayed = 35, SprintCount = 45 },
            InjuryStats = new InjuryStats { GamesMissed = 5, InjuryType = "Ankle Sprain", InjuryDate = DateTime.Now.AddDays(-30) }
        },
        new Player {
            Id = 2,
            Name = "Stephen Curry",
            Age = 35,
            Position = "PointGuard",
            Nationality = "USA",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/201939.png",
            PerformanceStats = new PerformanceStats { PointsScored = 32, Assists = 6, Rebounds = 5 },
            FitnessStats = new FitnessStats { MinutesPlayed = 34, SprintCount = 52 },
            InjuryStats = new InjuryStats { GamesMissed = 2, InjuryType = "Knee Soreness", InjuryDate = DateTime.Now.AddDays(-15) }
        },
        new Player {
            Id = 3,
            Name = "Giannis Antetokounmpo",
            Age = 28,
            Position = "PowerForward",
            Nationality = "Greece",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/203507.png",
            PerformanceStats = new PerformanceStats { PointsScored = 31, Assists = 5, Rebounds = 12 },
            FitnessStats = new FitnessStats { MinutesPlayed = 33, SprintCount = 48 },
            InjuryStats = new InjuryStats { GamesMissed = 0, InjuryType = "None", InjuryDate = DateTime.Now.AddDays(-365) }
        },
        new Player {
            Id = 4,
            Name = "Luka Dončić",
            Age = 24,
            Position = "PointGuard",
            Nationality = "Slovenia",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/1629029.png",
            PerformanceStats = new PerformanceStats { PointsScored = 27, Assists = 8, Rebounds = 9 },
            FitnessStats = new FitnessStats { MinutesPlayed = 37, SprintCount = 43 },
            InjuryStats = new InjuryStats { GamesMissed = 3, InjuryType = "Hamstring Strain", InjuryDate = DateTime.Now.AddDays(-45) }
        },
        new Player {
            Id = 5,
            Name = "Joel Embiid",
            Age = 29,
            Position = "Center",
            Nationality = "Cameroon",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/203954.png",
            PerformanceStats = new PerformanceStats { PointsScored = 33, Assists = 4, Rebounds = 10 },
            FitnessStats = new FitnessStats { MinutesPlayed = 34, SprintCount = 38 },
            InjuryStats = new InjuryStats { GamesMissed = 8, InjuryType = "Foot Sprain", InjuryDate = DateTime.Now.AddDays(-60) }
        },
        new Player {
            Id = 6,
            Name = "Kevin Durant",
            Age = 34,
            Position = "SmallForward",
            Nationality = "USA",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/201142.png",
            PerformanceStats = new PerformanceStats { PointsScored = 29, Assists = 5, Rebounds = 7 },
            FitnessStats = new FitnessStats { MinutesPlayed = 36, SprintCount = 42 },
            InjuryStats = new InjuryStats { GamesMissed = 4, InjuryType = "Knee Contusion", InjuryDate = DateTime.Now.AddDays(-25) }
        },
        new Player {
            Id = 7,
            Name = "Devin Booker",
            Age = 26,
            Position = "ShootingGuard",
            Nationality = "USA",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/1626164.png",
            PerformanceStats = new PerformanceStats { PointsScored = 27, Assists = 5, Rebounds = 4 },
            FitnessStats = new FitnessStats { MinutesPlayed = 35, SprintCount = 47 },
            InjuryStats = new InjuryStats { GamesMissed = 6, InjuryType = "Groin Strain", InjuryDate = DateTime.Now.AddDays(-40) }
        },
        new Player {
            Id = 8,
            Name = "Nikola Jokić",
            Age = 28,
            Position = "Center",
            Nationality = "Serbia",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/203999.png",
            PerformanceStats = new PerformanceStats { PointsScored = 25, Assists = 10, Rebounds = 12 },
            FitnessStats = new FitnessStats { MinutesPlayed = 34, SprintCount = 35 },
            InjuryStats = new InjuryStats { GamesMissed = 1, InjuryType = "Wrist Sprain", InjuryDate = DateTime.Now.AddDays(-10) }
        },

        new Player {
            Id = 9,
            Name = "Jayson Tatum",
            Age = 25,
            Position = "SmallForward",
            Nationality = "USA",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/1628369.png",
            PerformanceStats = new PerformanceStats { PointsScored = 30, Assists = 5, Rebounds = 8 },
            FitnessStats = new FitnessStats { MinutesPlayed = 37, SprintCount = 50 },
            InjuryStats = new InjuryStats { GamesMissed = 1, InjuryType = "Wrist Soreness", InjuryDate = DateTime.Now.AddDays(-20) }
        },
        new Player {
            Id = 10,
            Name = "Ja Morant",
            Age = 23,
            Position = "PointGuard",
            Nationality = "USA",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/1629630.png",
            PerformanceStats = new PerformanceStats { PointsScored = 26, Assists = 8, Rebounds = 6 },
            FitnessStats = new FitnessStats { MinutesPlayed = 33, SprintCount = 55 },
            InjuryStats = new InjuryStats { GamesMissed = 12, InjuryType = "Shoulder Strain", InjuryDate = DateTime.Now.AddDays(-90) }
        },
        new Player {
            Id = 11,
            Name = "Anthony Davis",
            Age = 30,
            Position = "PowerForward",
            Nationality = "USA",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/203076.png",
            PerformanceStats = new PerformanceStats { PointsScored = 26, Assists = 3, Rebounds = 12 },
            FitnessStats = new FitnessStats { MinutesPlayed = 34, SprintCount = 40 },
            InjuryStats = new InjuryStats { GamesMissed = 10, InjuryType = "Foot Stress Reaction", InjuryDate = DateTime.Now.AddDays(-75) }
        },
        new Player {
            Id = 12,
            Name = "Damian Lillard",
            Age = 32,
            Position = "PointGuard",
            Nationality = "USA",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/203081.png",
            PerformanceStats = new PerformanceStats { PointsScored = 28, Assists = 7, Rebounds = 4 },
            FitnessStats = new FitnessStats { MinutesPlayed = 36, SprintCount = 48 },
            InjuryStats = new InjuryStats { GamesMissed = 7, InjuryType = "Calf Strain", InjuryDate = DateTime.Now.AddDays(-50) }
        },
        new Player {
            Id = 13,
            Name = "Jimmy Butler",
            Age = 33,
            Position = "SmallForward",
            Nationality = "USA",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/202710.png",
            PerformanceStats = new PerformanceStats { PointsScored = 22, Assists = 5, Rebounds = 6 },
            FitnessStats = new FitnessStats { MinutesPlayed = 35, SprintCount = 45 },
            InjuryStats = new InjuryStats { GamesMissed = 9, InjuryType = "Knee Inflammation", InjuryDate = DateTime.Now.AddDays(-65) }
        },
        new Player {
            Id = 14,
            Name = "Bam Adebayo",
            Age = 25,
            Position = "Center",
            Nationality = "USA",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/1628389.png",
            PerformanceStats = new PerformanceStats { PointsScored = 20, Assists = 4, Rebounds = 10 },
            FitnessStats = new FitnessStats { MinutesPlayed = 34, SprintCount = 42 },
            InjuryStats = new InjuryStats { GamesMissed = 3, InjuryType = "Hip Contusion", InjuryDate = DateTime.Now.AddDays(-35) }
        },
        new Player {
            Id = 15,
            Name = "Zion Williamson",
            Age = 22,
            Position = "PowerForward",
            Nationality = "USA",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/1629627.png",
            PerformanceStats = new PerformanceStats { PointsScored = 26, Assists = 4, Rebounds = 7 },
            FitnessStats = new FitnessStats { MinutesPlayed = 32, SprintCount = 46 },
            InjuryStats = new InjuryStats { GamesMissed = 15, InjuryType = "Hamstring Tear", InjuryDate = DateTime.Now.AddDays(-120) }
        },
        new Player {
            Id = 16,
            Name = "Trae Young",
            Age = 24,
            Position = "PointGuard",
            Nationality = "USA",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/1629027.png",
            PerformanceStats = new PerformanceStats { PointsScored = 26, Assists = 10, Rebounds = 3 },
            FitnessStats = new FitnessStats { MinutesPlayed = 35, SprintCount = 52 },
            InjuryStats = new InjuryStats { GamesMissed = 4, InjuryType = "Ankle Sprain", InjuryDate = DateTime.Now.AddDays(-30) }
        },
        new Player {
            Id = 17,
            Name = "Donovan Mitchell",
            Age = 26,
            Position = "ShootingGuard",
            Nationality = "USA",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/1628378.png",
            PerformanceStats = new PerformanceStats { PointsScored = 28, Assists = 5, Rebounds = 4 },
            FitnessStats = new FitnessStats { MinutesPlayed = 36, SprintCount = 49 },
            InjuryStats = new InjuryStats { GamesMissed = 2, InjuryType = "Groin Tightness", InjuryDate = DateTime.Now.AddDays(-18) }
        },
        new Player {
            Id = 18,
            Name = "Karl-Anthony Towns",
            Age = 27,
            Position = "Center",
            Nationality = "USA",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/1626157.png",
            PerformanceStats = new PerformanceStats { PointsScored = 24, Assists = 3, Rebounds = 10 },
            FitnessStats = new FitnessStats { MinutesPlayed = 34, SprintCount = 38 },
            InjuryStats = new InjuryStats { GamesMissed = 20, InjuryType = "Calf Strain", InjuryDate = DateTime.Now.AddDays(-150) }
        },
        new Player {
            Id = 19,
            Name = "Shai Gilgeous-Alexander",
            Age = 24,
            Position = "ShootingGuard",
            Nationality = "Canada",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/1628983.png",
            PerformanceStats = new PerformanceStats { PointsScored = 31, Assists = 5, Rebounds = 5 },
            FitnessStats = new FitnessStats { MinutesPlayed = 36, SprintCount = 51 },
            InjuryStats = new InjuryStats { GamesMissed = 3, InjuryType = "Abdominal Strain", InjuryDate = DateTime.Now.AddDays(-42) }
        },
        new Player {
            Id = 20,
            Name = "Pascal Siakam",
            Age = 28,
            Position = "PowerForward",
            Nationality = "Cameroon",
            ImageUrl = "https://cdn.nba.com/headshots/nba/latest/1040x760/1627783.png",
            PerformanceStats = new PerformanceStats { PointsScored = 24, Assists = 5, Rebounds = 8 },
            FitnessStats = new FitnessStats { MinutesPlayed = 35, SprintCount = 44 },
            InjuryStats = new InjuryStats { GamesMissed = 6, InjuryType = "Shoulder Impingement", InjuryDate = DateTime.Now.AddDays(-55) }
        }
    };
    public Task<List<Player>> GetAllPlayersAsync() => Task.FromResult(_players);
    public List<string> GetAvailablePositions()
    {
        return new List<string>
    {
        "PointGuard",
        "ShootingGuard",
        "SmallForward",
        "PowerForward",
        "Center"
    };
    }
    public List<string> AvailablePositions => new List<string>
    {
        "PointGuard",
        "ShootingGuard",
        "SmallForward",
        "PowerForward",
        "Center"
    };

    public Task<List<Player>> GetPlayersByPositionAsync(string position)
    {
        if (string.IsNullOrWhiteSpace(position))
            return GetAllPlayersAsync();

        var filteredPlayers = _players
            .Where(p => p.Position.Equals(position, StringComparison.OrdinalIgnoreCase))
            .ToList();

        return Task.FromResult(filteredPlayers);
    }

    public Task<Player> GetPlayerByIdAsync(int id)
    {
        var player = _players.FirstOrDefault(p => p.Id == id);
        return Task.FromResult(player);
    }
}