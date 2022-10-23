using Avalonia;
using Avalonia.ReactiveUI;
using Avalonia.Web.Blazor;

namespace BehaviorsTestApplication.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        AppBuilder.Configure<BehaviorsTestApplication.App>()
            .UseBlazor()
            .UseReactiveUI()
            .SetupWithSingleViewLifetime();
    }
}