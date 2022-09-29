using System.Security.Claims;

namespace Components.VerticalMenu
{
    public struct VerticalMenuState
    {
        public VerticalMenuState(ClaimsPrincipal user, MenuPage currentPage)
        {
            User = user;
            CurrentPage = currentPage;
        }

        public ClaimsPrincipal User { get; }

        public MenuPage CurrentPage { get; }
    }
}
