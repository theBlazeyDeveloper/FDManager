using Microsoft.JSInterop;

namespace WebClient.Interops
{
    public class MapJsInterop : IAsyncDisposable
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public MapJsInterop(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./js/MapInterop.js").AsTask());
        }

        public async ValueTask LoadMap()
        {
            var module = await moduleTask.Value;
            await module.InvokeVoidAsync("GetMap");
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}
