using System;
using Shouldly;
using Xunit;


namespace Bolt.Common.Extensions.UnitTests
{
    public static class DateTimeExtensionsTests
    {
        [Fact]
        public static void ToDateTimeTests()
        {
            var dateStr = "2015-04-04";
            var date = dateStr.ToDateTime();
            date.ShouldBe(new DateTime(2015, 4, 4));

            dateStr = "04/03/2015";
            date = dateStr.ToDateTime();
            date.ShouldBe(new DateTime(2015, 4, 3));

            dateStr = "04/03/2015";
            date = dateStr.ToDateTime("dd/MM/yyyy");
            date.ShouldBe(new DateTime(2015,3,4));
        }
    }
}