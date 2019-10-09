using MediatR;
using Moq;
using Nexawo.Application.Tenants.Commands.CreateTenant;
using Nexawo.Application.UnitTests.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace Application.UnitTests.Tenants.Commands.CreateTenant
{
    public class CreateTenantCommandTest : CommandTestBase
    {
        [Fact]
        public void Handle_GivenValidRequest_ShouldRaiseTenantCreatedNotification()
        {
            // Arrange
            var mediatorMock = new Mock<IMediator>();
            var sut = new CreateTenantCommandHandler(_context, mediatorMock.Object);
            var newTenantId = "100001";

            // Act
            var result = sut.Handle(new CreateTenantCommand { TenantId = newTenantId }, CancellationToken.None);

            // Assert
            mediatorMock.Verify(m => m.Publish(It.Is<TenantCreated>(cc => cc.TenantId == newTenantId), It.IsAny<CancellationToken>()), Times.Once);
        }
    }
}
