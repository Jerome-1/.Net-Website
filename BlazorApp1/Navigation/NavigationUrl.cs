using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Navigation
{
    public class MockNavigationManager : NavigationManager
    {
        public string LastNavigatedUri { get; private set; } = string.Empty;

        public MockNavigationManager()
        {
            Initialize("https://unit-test.example/", "https://unit-test.example/");
        }

        protected override void NavigateToCore(string uri, bool forceLoad)
        {
            this.LastNavigatedUri = uri;

            NotifyLocationChanged(false);
        }
    }
}
