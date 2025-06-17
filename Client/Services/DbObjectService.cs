using System.Net.Http.Json;
using TestApp2.Shared.DbTracking;

namespace TestApp2.Client.Services;

public class DbObjectService
{
    private readonly HttpClient _http;
    private readonly string _baseUrl;
    private readonly string _apiKey;

    public DbObjectService(HttpClient http, IConfiguration config)
    {
        _http = http;
        _baseUrl = config["Supabase:Url"] ?? string.Empty;
        _apiKey = config["Supabase:Key"] ?? string.Empty;
    }

    private HttpRequestMessage CreateRequest(HttpMethod method, string path)
    {
        var req = new HttpRequestMessage(method, $"{_baseUrl}/rest/v1/{path}");
        req.Headers.Add("apikey", _apiKey);
        req.Headers.Add("Authorization", $"Bearer {_apiKey}");
        return req;
    }

    public async Task<List<DbObjectRecord>?> GetRecordsAsync()
    {
        var req = CreateRequest(HttpMethod.Get, "db_objects?select=*");
        var res = await _http.SendAsync(req);
        if (res.IsSuccessStatusCode)
        {
            return await res.Content.ReadFromJsonAsync<List<DbObjectRecord>>();
        }
        return null;
    }

    public async Task<bool> AddRecordAsync(DbObjectRecord record)
    {
        var req = CreateRequest(HttpMethod.Post, "db_objects");
        req.Content = JsonContent.Create(record);
        var res = await _http.SendAsync(req);
        return res.IsSuccessStatusCode;
    }
}
