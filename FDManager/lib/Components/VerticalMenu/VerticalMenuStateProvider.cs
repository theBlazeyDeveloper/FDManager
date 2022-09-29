using System.Collections.Concurrent;
using System.Security.Claims;

namespace Components.VerticalMenu
{
    public delegate void OnStateChanged(object sender, VerticalStateChangedEventArgs args);

    public class VerticalMenuStateProvider
    {
        static readonly ConcurrentDictionary<string, VerticalMenuState> _states = new();        

        public VerticalMenuStateProvider()
        { }

        public void SelectPage(ClaimsPrincipal user, MenuPage page)
        {
            var currentState = new VerticalMenuState(user, page);

            _states.AddOrUpdate(user.GetUserId(), currentState, (k,v) => new(user, page));            
        }

        public VerticalMenuState? GetCurrentState(ClaimsPrincipal user)
        {
            if (user is not null && user.Identity is not null && user.Identity.IsAuthenticated)
            {
                if (_states.TryGetValue(user.GetUserId(), out var state))
                    return state;
                else
                    return null;
            }
            else
                return null;
        }
    }
}
