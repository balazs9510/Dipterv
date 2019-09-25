using Microsoft.AspNetCore.SignalR;
using Moq;
using PublicWeb.DTOs;
using PublicWeb.Hubs;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Test.Hubs
{
    public class BookingHubTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(10)]
        public async Task HubClientsCalledWithBookingPositons(int bookingSeatCount)
        {
            // arrange
            Mock<IHubCallerClients<IBookingHub>> mockClients = new Mock<IHubCallerClients<IBookingHub>>();
            Mock<IBookingHub> mockClientProxy = new Mock<IBookingHub>();
            mockClients.Setup(clients => clients.All).Returns(mockClientProxy.Object);
            BookingHub bookingHub = new BookingHub()
            {
                Clients = mockClients.Object
            };
            var bookingDto = new BookingDTO
            {
                Date = DateTime.Now,
                Id = Guid.NewGuid().ToString(),
                Email = "",
                Positions = new List<ServicePlacePositionDTO>()
            };
            for (int i = 0; i < bookingSeatCount; i++)
            {
                bookingDto.Positions.Add(new ServicePlacePositionDTO { });
            }

            // act
            await bookingHub.SendBooking(bookingDto);


            // assert
            mockClients.Verify(clients => clients.All, Times.Once);

            mockClientProxy.Verify(
                clientProxy => clientProxy.RecieveNewBooking(
                    It.Is<BookingDTO>(x => x.Email == "" && x.Positions.Count == bookingSeatCount)
                   ),
                Times.Once);
        }
    }
}
