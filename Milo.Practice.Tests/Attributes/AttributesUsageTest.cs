using System;
using Xunit;
using Xunit.Abstractions;

public class AttributeUsageTest
{
    private readonly ITestOutputHelper output;

    public AttributeUsageTest(ITestOutputHelper output)
    {

    }
    [Fact]
    public void shouldOutputCustomAttributes()
    {
        //Given
        var attributeUsage = new MiloAttributeUsage();
        //When
        var result = attributeUsage.TestAttributes();
        //Then
    }
}