using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace sjm.mediatr.Queries
{
    public record GetProductsQuery : IRequest<IEnumerable<Product>>;
}
