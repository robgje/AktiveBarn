using Microsoft.JSInterop;

namespace AktiveBarn.Web.Client.Services;

public static class HotReloadService
{
    [JSInvokable("ApplyHotReloadDeltas")]
    public static void ApplyHotReloadDeltas()
    {
        // Implementation for applying hot reload deltas
    }
}

