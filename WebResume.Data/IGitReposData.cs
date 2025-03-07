using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebResume.Domain;

namespace WebResume.Data;

public interface IGitReposData
{
    Task<IEnumerable<GitRepos>> GetAllRepos();
}

public class GitReposData : IGitReposData
{
    private readonly IHttpClientFactory _clientFactory;

    public GitReposData(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }

    public async Task<IEnumerable<GitRepos>> GetAllRepos()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, "https://api.github.com/users/kris-doidge/repos");
        request.Headers.Add("Accept", "application/json");
        request.Headers.Add("Accept", "text/html");
        request.Headers.Add("User-Agent", "WebResume");

        var client = _clientFactory.CreateClient();

        var response = await client.SendAsync(request).ConfigureAwait(false);
        if (response != null)
        {
            var jsonString = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<GitRepos>>(jsonString);
        }

        return new List<GitRepos> { new() { name = "name" } };
    }
}