﻿using FluentAssertions;
using MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Notifications.Models;
using MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Notifications.Models.Enums;
using System;
using Xunit;

namespace MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Tests.NotificationsTests.ModelsTests;

public class NotificationTest
{
    [Fact]
    public void NotificationTest_Should_Be_Initialized_With_Default_Values()
    {
        // Arrange and Act
        var notification = new Notification();

        // Assert
        notification.NotificationType.Should().Be(default);
        notification.Code.Should().BeNull();
        notification.Description.Should().BeNull();
    }

    [Fact]
    public void NotificationTest_Should_Be_Correctly_Initialized()
    {
        // Arrange
        var notificationType = NotificationType.Information;
        var code = Guid.NewGuid().ToString();
        var description = Guid.NewGuid().ToString();

        // Act
        var notification = new Notification(notificationType, code, description);

        // Assert
        notification.NotificationType.Should().Be(notificationType);
        notification.Code.Should().Be(code);
        notification.Description.Should().Be(description);
    }
}