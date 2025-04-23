using Domain.ValueObjects;
using MediatR;

namespace Application.Categories.Create
{
    public sealed class CreateCategoryCommand : IRequest<IdGuid>
    {
        public IdGuid Id { get; set; } = null!;

        public DateCreated DateCreated { get; set; }

        private string _categoryName = default!;

        public required string CategoryName
        {
            get => _categoryName;

            set => _categoryName = value[..50];
        }
    }
}
