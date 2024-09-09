using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components.Pages.Divided;

public partial class MiComponente : ComponentBase
{
    private int count = 0;

    private void IncrementCount()
    {
        count++;
    }
}
