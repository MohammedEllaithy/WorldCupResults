using FIFAWorldCupResults.Dtos;
using System.Net.Http.Json;

namespace FIFAWorldCupResults.Services
{
    public class MatchService : IMatchService
    {
        private readonly HttpClient _httpClient;

        public MatchService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.Add("X-Auth-Token", "Add your Key");
        }

        private readonly string _baseUrl = "https://api.football-data.org/v4";
        public async Task<StandingsResponseDto?> GetStandings()
        {
            return await _httpClient.GetFromJsonAsync<StandingsResponseDto?>($"{_baseUrl}/competitions/WC/standings");
        }

        public async Task<MatchesResponseDto?> GetTodayMatches()
        {
            var date = DateTime.Now.ToString("yyyy-MM-dd");
            return await _httpClient.GetFromJsonAsync<MatchesResponseDto?>($"{_baseUrl}/competitions/WC/matches?dateFrom={date}&dateTo={date}");

        }
    }
}
