using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace ArchivesManagement.Pages
{
    public class IndexModel : ArchivesManagementPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}