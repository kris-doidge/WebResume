using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebResume.Data;
using WebResume.Domain;

namespace WebResume.Pages
{
    public class PortfolioModel : PageModel
    {
        private readonly IGitReposData _gitReposData;
        public Task<IEnumerable<GitRepos>> GitReposDatas { get; set; }
        public IEnumerable<GitRepos> GitReposes { get; set; }

        public PortfolioModel(IGitReposData gitReposData)
        {
            _gitReposData = gitReposData;
        }
        public async Task OnGet()
        {
            GitReposDatas = _gitReposData.GetAllRepos();
            GitReposes = await _gitReposData.GetAllRepos();
        }
    }
}