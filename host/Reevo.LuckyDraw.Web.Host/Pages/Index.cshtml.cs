using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Reevo.LuckyDraw.Pages;

public class IndexModel : LuckyDrawPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
