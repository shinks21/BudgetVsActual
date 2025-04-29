using Application.Abstractions;
using Domain.DatabaseEntities;
using Domain.ValueObjects;
using MediatR;

namespace Application.Categories.Create
{
    internal sealed class CreateCategoryCommandHandler(IApplicationDbContext context)
        : IRequestHandler<CreateCategoryCommand, IdGuid>
    {
        public async Task<IdGuid> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = new Category
            {
                Id = new IdGuid(Guid.CreateVersion7(TimeProvider.System.GetUtcNow())),
                Active = true,
                CategoryName = request.CategoryName,
                DateCreated = DateTime.UtcNow,
                //                UserId = 
            };

            context.Categories.Add(category);

            await context.SaveChangesAsync(cancellationToken);

            return category.Id;
        }
    }
}