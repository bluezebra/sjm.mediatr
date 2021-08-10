﻿using System.Threading;
using System.Threading.Tasks;
using MediatR;
using sjm.mediatr.Commands;

namespace sjm.mediatr.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly FakeDataStore _fakeDataStore;

        public AddProductHandler(FakeDataStore fakeDataStore) => _fakeDataStore = fakeDataStore;

        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _fakeDataStore.AddProduct(request.Product);
            
            return request.Product;
        }
    }
}
