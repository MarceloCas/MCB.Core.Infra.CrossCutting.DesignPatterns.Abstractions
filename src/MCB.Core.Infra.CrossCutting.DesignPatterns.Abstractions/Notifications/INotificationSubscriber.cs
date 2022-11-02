﻿using MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Notifications.Models;
using MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Observer;

namespace MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Notifications;

public interface INotificationSubscriber
    : ISubscriber<Notification>
{
    IEnumerable<Notification> NotificationCollection { get; }
}
