using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace Spotifried.Services;

public class SpotifyService(HttpClient client)
{
    private readonly HttpClient _client = client;

    private readonly string? _clientId = Environment.GetEnvironmentVariable("CLIENT_ID");
    private readonly string? _clientSecret = Environment.GetEnvironmentVariable("CLIENT_SECRET");
    private Dictionary<string, dynamic>? _accessToken = null;

    public async Task<string> Search(string query, string type)
    {
        if (_accessToken == null || DateTime.UtcNow >= _accessToken!["_expiration"])
        {
            await RefreshToken();
        }

        string url = $"https://api.spotify.com/v1/search?q={Uri.EscapeDataString(query)}&type={Uri.EscapeDataString(type)}";
        var request = new HttpRequestMessage(HttpMethod.Get, url);
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken!["_token"]);

        var response = await _client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            return responseBody;
        }
        else
        {
            Console.WriteLine($"Erro na requisição: {response.StatusCode} - {response.ReasonPhrase}");
            throw new HttpRequestException($"Erro na requisição: {response.StatusCode} - {response.ReasonPhrase}");
        }
    }


    private async Task RefreshToken()
    {
        var request = new HttpRequestMessage(HttpMethod.Post, "https://accounts.spotify.com/api/token");

        var collection = new List<KeyValuePair<string, string>>
        {
            new("grant_type", "client_credentials"),
            new("client_id", _clientId!),
            new("client_secret", _clientSecret!)
        };
        var content = new FormUrlEncodedContent(collection);
        request.Content = content;
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

        var response = await _client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            var responseContent = await response.Content.ReadAsStringAsync();
            var tokenData = JObject.Parse(responseContent);

            _accessToken = new Dictionary<string, dynamic>
            {
                {"_token", tokenData["access_token"]!.ToString()},
                {"_expiration", DateTime.UtcNow.AddSeconds(tokenData["expires_in"]?.ToObject<int>() ?? 3600)}
            };
        }
        else
        {
            Console.WriteLine($"Erro na requisição: {response.StatusCode} - {response.ReasonPhrase}");
            throw new HttpRequestException($"Erro na requisição: {response.StatusCode} - {response.ReasonPhrase}");
        }


    }

}