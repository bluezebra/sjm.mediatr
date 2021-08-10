using MediatR;

namespace sjm.mediatr.Commands
{
    public record AddProductCommand(Product Product) : IRequest;
}
