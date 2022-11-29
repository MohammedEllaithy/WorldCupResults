using FIFAWorldCupResults.Dtos;

namespace FIFAWorldCupResults.Services
{
    public interface IMatchService
    {
        Task<StandingsResponseDto?> GetStandings();
        Task<MatchesResponseDto?> GetTodayMatches();
    }
}
