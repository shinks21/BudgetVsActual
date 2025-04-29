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

            set
            {
                switch (value)
                {
                    case null:
                        _categoryName = string.Empty;
                        break;
                    default:
                        if (value.Length > 50)
                        {
                            _categoryName = value[..50];
                        }
                        else
                        {
                            _categoryName = value;
                        }

                        break;
                }
            }
        }
    }
}
