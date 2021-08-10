using MediatR;

namespace sjm.mediatr.Notifications
{
    public record ProductAddedNotification(Product Product) : INotification;
}
