using BlazorWasm.Zodiac.Data;
using BlazorWasm.Zodiac.Models;
using Microsoft.JSInterop;

namespace BlazorWasm.Zodiac.Pages
{
    public partial class Index
    {
        private bool _isLoading = true;

        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(500);
            _isLoading = false;
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if(firstRender)
            {
                var sign = JsonData.ZodiacSigns[0];
                var data = sign.Traits.Select(x => new ChartModel
                {
                    data = x.Percentage,
                    label = x.Name,
                }).ToList();
                await _jsRuntime.InvokeVoidAsync
                (
                    "radarChart", 
                    "#chart", 
                    "Personality Traits", 
                    data
                );
            }
        }
    }
}
