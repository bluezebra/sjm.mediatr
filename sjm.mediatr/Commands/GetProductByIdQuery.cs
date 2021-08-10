using MediatR;

namespace sjm.mediatr.Commands
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;
}
