using System.Net;

namespace Tests;

public class CityBikeApi
{
    [Fact]
    public async Task CallBikeApi()
    {
        //Arrange - instantiate the class of the method being tested
        
        var apiClient = new CityBikeApi();

        //Act - call the method being tested 

        var result = apiClient.CallBikeApi();

        //Assert - compare results of data

        Assert.NotNull(result);
        Assert.Equal(HttpStatusCode.OK, result.AsyncState);
    }
}
