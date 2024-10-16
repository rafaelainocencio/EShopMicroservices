using MediatR;

namespace Catalog_API.Products.CreateProduct
{
    public record class CreateProductCommand(string Name, List<string> Categories, string Description, string ImageFile, decimal Price)
    : IRequest<CreateProductResult>;
    public record class CreateProductResult(Guid Id);

    internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            // Busniess Logic to create a product
            throw new NotImplementedException();
        }
    }
}
