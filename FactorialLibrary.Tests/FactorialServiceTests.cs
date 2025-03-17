namespace FactorialLibrary.Tests;

using FactorialLibrary;


public class FactorialServiceTests //dotnet add FactorialLibrary.Tests/FactorialLibrary.Tests.csproj reference FactorialLibrary/FactorialLibrary.csproj
{
    [Fact]
    public void Test1()
    {
        var result = FactorialService.Factorial(0); //calling the factorial function
        Assert.Equal(1, result);
    }

    [Fact]
    public void Test_negative()
    {
        Assert.Throws<InvalidOperationException>(()=>{
            var result = FactorialService.Factorial(-1);//throw error if negative number is passed to function
        });     
        
    }
}