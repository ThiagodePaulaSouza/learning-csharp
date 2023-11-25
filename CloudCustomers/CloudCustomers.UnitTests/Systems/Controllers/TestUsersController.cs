using CloudCustomers.API.Controllers;
using CloudCustomers.API.Models;
using CloudCustomers.API.Services;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace CloudCustomers.UnitTests.Systems.Controllers;

public class TestUsersController
{
    [Fact]
    public async Task GET_OnSuccess_Returns_StatusCode200()
    {
        // Arrange
        var mockUsersService = new Mock<IUserService>();
        mockUsersService
            .Setup(service => service.GetAllUsers())
            .ReturnsAsync(new List<User>());
        var sut = new UsersController(mockUsersService.Object);

        // Act
        var result = (OkObjectResult)await sut.GetUsers();

        // Assert
        result.StatusCode.Should().Be(200);
    }

    [Fact]
    public async Task GET_OnSuccess_InvokesUserService_ExactlyOne()
    {
        // Arrange
        var mockUsersService = new Mock<IUserService>();
        mockUsersService
            .Setup(service => service.GetAllUsers())
            .ReturnsAsync(new List<User>());
        var sut = new UsersController(mockUsersService.Object);

        // Act
        var result = (OkObjectResult)await sut.GetUsers();

        // Assert
        mockUsersService.Verify(service => service.GetAllUsers(), Times.Once());
    }

    [Fact]
    public async Task GET_OnSuccess_ReturnsListOfUsers()
    {
        // Arrange
        var expectedResult = new List<User>()
        {
            new User(1, "João", "joao@gmail.com", new Address("", "", "")),
            new User(2, "Mario", "Mario@gmail.com", new Address("", "", "")),
            new User(3, "José", "José@gmail.com", new Address("", "", "")),
            new User(4, "Mariana", "Mariana@gmail.com", new Address("", "", "")),
            new User(5, "Gabriele", "Gabriele@gmail.com", new Address("", "", ""))
        };

        var mockUsersService = new Mock<IUserService>();
        mockUsersService
            .Setup(service => service.GetAllUsers())
            .ReturnsAsync(expectedResult);
        var sut = new UsersController(mockUsersService.Object);

        // Act
        var result = (OkObjectResult)await sut.GetUsers();

        // Assert
        

        result.Value.Should().Be(expectedResult);
    }
}