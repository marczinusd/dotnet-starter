using FluentAssertions;
using Xunit;

namespace Starter.Tests;

public class Hello
{
    [Fact]
    public void GreetShouldReturnHello() => Starter.Hello.Greet().Should().Contain("hello");
}
