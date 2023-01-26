using Microsoft.AspNetCore.Components;
namespace BlazorApp1.Pages
{
    public partial class Count : ComponentBase
    {
        public int currentCount = 0;

        public void IncrementCount()
        {
            currentCount++;
        }

        public void DecrementCount()
        {
            currentCount--;
        }

        public void ResetCount()
        {
            currentCount = 0;
        }
    }
}
