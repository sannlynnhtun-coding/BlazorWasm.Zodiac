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
    }
}
