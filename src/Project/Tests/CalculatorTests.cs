using FluentAssertions;

namespace Project.Tests;

public class CalculatorTests
{
    public class Add
    {
        [Fact]
        public void Ok() => Calculator.Add(1, 2).Should().Be(3);
    }
}