using CloudCustomers.API.Models;
using CloudCustomers.API.Services;
using CloudCustomers.UnitTests.Fixtures;
using CloudCustomers.UnitTests.Helpers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Moq.Protected;
using System.Collections.Generic;
using Xunit;

namespace CloudCustomers.UnitTests.Systems.Services;
public class TestUsersService
{
    [Fact]
    public async Task GET_AllUsers_WhenCalled_Invokes_HttpGetRequest()
    {
        // Arrange
        var expectedResponse = UserFixture.GetTestUsers();
        var mockHandlerHttp = MockHttpMessageHandler<User>.SetupBasicGetRequestList(expectedResponse);
        var httpClient = new HttpClient(mockHandlerHttp.Object);
        var sut = new UsersService(httpClient);

        // Act
        await sut.GetAllUsers();

        // Assert
        mockHandlerHttp
            .Protected()
            .Verify(
                "SendAsync",
                Times.Exactly(1), 
                ItExpr.Is<HttpRequestMessage>(req => req.Method == HttpMethod.Get),
                ItExpr.IsAny<CancellationToken>()
            );
    }

    [Fact]
    public async Task GET_AllUsers_WhenCalled_Returns_ListOfUsers()
    {
        // Arrange
        var expectedResponse = UserFixture.GetTestUsers();
        var mockHandlerHttp = MockHttpMessageHandler<User>.SetupBasicGetRequestList(expectedResponse);
        var httpClient = new HttpClient(mockHandlerHttp.Object);
        var sut = new UsersService(httpClient);

        // Act
        var result = await sut.GetAllUsers();

        // Assert
        result.Should().BeOfType<List<User>>();

        result.Should().NotBeNull();
    }

    [Fact]
    public async Task GET_AllUsers_WhenHits404_Returns_EmptyListOfUsers()
    {
        // Arrange
        var mockHandlerHttp = MockHttpMessageHandler<User>.SetupReturn404();
        var httpClient = new HttpClient(mockHandlerHttp.Object);
        var sut = new UsersService(httpClient);

        // Act
        var result = await sut.GetAllUsers();

        // Assert
        result.Count().Should().Be(0);
    }

    [Fact]
    public async Task GET_AllUsers_WhenCalled_Returns_ListOfUsersOFExpectSize()
    {
        // Arrange
        var expectedResponse = UserFixture.GetTestUsers();
        var mockHandlerHttp = MockHttpMessageHandler<User>.SetupBasicGetRequestList(expectedResponse);
        var httpClient = new HttpClient(mockHandlerHttp.Object);
        var sut = new UsersService(httpClient);

        // Act
        var result = await sut.GetAllUsers();

        // Assert
        result.Count().Should().Be(expectedResponse.Count);
    }
}
