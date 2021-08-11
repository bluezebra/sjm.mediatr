using System.Threading;
using System.Threading.Tasks;
using MediatR;
using sjm.mediatr.Commands;
using sjm.mediatr.Notifications;

namespace sjm.mediatr.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly FakeDataStore _fakeDataStore;
        private readonly IMediator _mediator;


        public AddProductHandler(FakeDataStore fakeDataStore, IMediator mediator)
        {
            _fakeDataStore = fakeDataStore;
            _mediator = mediator;
        }

        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _fakeDataStore.AddProduct(request.Product);
            
            await _mediator.Publish(new ProductAddedNotification(request.Product));

            return request.Product;
        }
    }
}
