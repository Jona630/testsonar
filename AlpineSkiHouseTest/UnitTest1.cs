using System;
using Xunit;

namespace AlpineSkiHouseTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, 1);
        }

        [Fact]
        public void Test2()
        {
            AlpineSkiHouse.Pages.IndexModel model = new AlpineSkiHouse.Pages.IndexModel(null);

            int output = model.testmethod(12);

            Assert.Equal(24, output);
        }
    }
}
