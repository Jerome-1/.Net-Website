using BlazorApp1.Pages;
using Bunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.UnitTest
{
    public class ComponentsTest
    {
        [Fact]

        public void TestCounterMethod()
        {
            //ARRANGE
            using var srm = new TestContext();
            var mrs = srm.RenderComponent<Counter>();
            var rsm = srm.RenderComponent<Counter>();
            var msr = srm.RenderComponent<Counter>();
            //ACT
            mrs.Find(".btn-primary").Click();
            rsm.Find(".btn-secondary").Click();
            msr.Find(".btn-third").Click();
            //ASSERT
            mrs.Find("p").MarkupMatches("<p role=\"status\">Current count: 1</p>");
            rsm.Find("p").MarkupMatches("<p role=\"status\">Current count: 0</p>");
            msr.Find("p").MarkupMatches("<p role=\"status\">Current count: -1</p>");
        }
    }
}
