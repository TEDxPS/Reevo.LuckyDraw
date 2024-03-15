using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Reevo.LuckyDraw.Blazor.Menus;

public class LuckyDrawMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(LuckyDrawMenus.Prefix, displayName: "LuckyDraw", "/LuckyDraw", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
