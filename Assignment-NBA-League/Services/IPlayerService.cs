using HoopMetrics.Models;

namespace HoopMetrics.Services
{
    public interface IPlayerService
    {
        Task<List<Player>> GetAllPlayersAsync();
        Task<List<Player>> GetPlayersByPositionAsync(string position);
        Task<Player> GetPlayerByIdAsync(int id);

        List<string> GetAvailablePositions();
    }
}