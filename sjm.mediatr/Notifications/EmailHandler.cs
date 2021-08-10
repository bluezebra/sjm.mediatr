using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace sjm.mediatr.Notifications
{
    public class EmailHandler : INotificationHandler<ProductAddedNotification>
    {
        private readonly FakeDataStore _fakeDataStore;

        public EmailHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            await _fakeDataStore.EventOccurred(notification.Product, "Email sent");
            await Task.CompletedTask;
        }
    }
}
