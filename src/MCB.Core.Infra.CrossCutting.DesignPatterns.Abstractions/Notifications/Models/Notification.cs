using MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Notifications.Models.Enums;

namespace MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Notifications.Models;

public readonly record struct Notification
{
    // Properties
    public NotificationType NotificationType { get; }
    public string Code { get; }
    public string Description { get; }
    public IEnumerable<Notification>? NotificationCollection { get; }

    // Constructors
    public Notification(NotificationType notificationType, string code, string description)
    {
        NotificationType = notificationType;
        Code = code;
        Description = description;
    }
    public Notification(NotificationType notificationType, string code, string description, IEnumerable<Notification> notificationCollection)
    {
        NotificationType = notificationType;
        Code = code;
        Description = description;
        NotificationCollection = notificationCollection;
    }
}


