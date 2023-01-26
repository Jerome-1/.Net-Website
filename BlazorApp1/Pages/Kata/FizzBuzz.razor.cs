using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages
{
    public class KataFizzBuzz : ComponentBase
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();
        }
        public class Fizzy
        {
            public string Value { get; set; }
            public string Term { get; set; }
        }
        public List<Fizzy> fizzy = new List<Fizzy>();

        public int FizzValue = 3;
        public int BuzzValue = 5;

        public bool Fizz = false;
        public bool Buzz = false;

        public void DoIt()
        {
            for (int i = 0; i <= 100; i++)
            {
                if(i%FizzValue==0 && i%BuzzValue==0)
                {
                    Fizz = true;
                    Buzz=true;
                    fizzy.Add(new Fizzy { Value = "Fizzbuzzz", Term = "Fizzbuzz" });
                } else if (i%FizzValue==0)
                {
                    Fizz = true;
                    fizzy.Add(new Fizzy { Value = "Fizz", Term = "Buzz" });
                } else if (i%BuzzValue==0)
                {
                    Buzz= true;
                    fizzy.Add(new Fizzy { Value = "Buzz", Term = "Buzz" });
                } else
                {
                    fizzy.Add(new Fizzy { Value = i.ToString(), Term = " " });
                }
            }
        }

    }
}
