using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace sjm.mediatr.Notifications
{
    public class CacheInvalidationHandler : INotificationHandler<ProductAddedNotification>
    {
        private readonly FakeDataStore _fakeDataStore;

        public CacheInvalidationHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task Handle(ProductAddedNotification notification, CancellationToken cancellationToken)
        {
            await _fakeDataStore.EventOccurred(notification.Product, "Cache Invalidated");
            await Task.CompletedTask;
        }
    }
}
