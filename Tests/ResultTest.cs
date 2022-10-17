using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        var a = new List<int>(){1, 2, 3, 4, 3, 2, 1};
        int expected = 4;

        int actual = Result.lonelyinteger(a);

        Assert.Equal(expected, actual);
    }
}