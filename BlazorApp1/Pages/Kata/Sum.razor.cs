using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages.Kata
{
    public class Summation : ComponentBase
    {
        public Summation() { }

        public int SumOfArray(List<int> numbers)
        {            
            int summation = 0;

            for (int i = 0; i < numbers.Count(); i++)
            {
                summation = summation + numbers[i];
            }
            return summation;

        }
    }
}
