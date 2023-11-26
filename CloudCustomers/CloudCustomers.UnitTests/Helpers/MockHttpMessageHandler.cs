using Moq;
using Moq.Protected;
using Newtonsoft.Json;

namespace CloudCustomers.UnitTests.Helpers;
internal static class MockHttpMessageHandler<T>
{
    internal static Mock<HttpMessageHandler> SetupBasicGetRequestList(List<T> expectedResponse, string endpoints = null)
    {
        var mockResponse = new HttpResponseMessage(System.Net.HttpStatusCode.OK)
        {
            Content = new StringContent(JsonConvert.SerializeObject(expectedResponse))
        };

        mockResponse.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
        
        var handlerMock = new Mock<HttpMessageHandler>();

        handlerMock
            .Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>()
            ).ReturnsAsync(mockResponse);

        return handlerMock;
    }
    //internal static Mock<HttpMessageHandler> SetupBasicGetRequestList(List<T> expectedResponse, string endpoints)
    //{
    //    var mockResponse = new HttpResponseMessage(System.Net.HttpStatusCode.OK)
    //    {
    //        Content = new StringContent(JsonConvert.SerializeObject(expectedResponse))
    //    };

    //    mockResponse.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
        
    //    var handlerMock = new Mock<HttpMessageHandler>();

    //    var httpRequest = new HttpRequestMessage
    //    {
    //        RequestUri = new Uri(endpoints),
    //        Method = HttpMethod.Get,
            
    //    };

    //    handlerMock
    //        .Protected()
    //        .Setup<Task<HttpResponseMessage>>(
    //            "SendAsync",
    //            httpRequest,
    //            ItExpr.IsAny<CancellationToken>()
    //        ).ReturnsAsync(mockResponse);

    //    return handlerMock;
    //}

    internal static Mock<HttpMessageHandler> SetupReturn404()
    {
        var mockResponse = new HttpResponseMessage(System.Net.HttpStatusCode.NotFound)
        {
            Content = new StringContent("")
        };

        mockResponse.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

        var handlerMock = new Mock<HttpMessageHandler>();

        handlerMock
            .Protected()
            .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>()
            ).ReturnsAsync(mockResponse);

        return handlerMock;
    }
}
