using FluentValidation;

namespace bestallningsportal.Application.Product.Commands.UpdateProduct
{
    /// This code is used to validate the requests to command based on rules specified
    /// <param name="UpdateProductCommand">The UpdateProductCommand instance being validated.</param>
    /// <returns>An error message if validation fails, based on the specified rules.</returns>
    /// </summary>
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Namn krävs.")
                .MaximumLength(200);
            RuleFor(x => x.Unit).NotEmpty().WithMessage("Enhet krävs");
            RuleFor(x => x.ProductCategoryId).NotEmpty().WithMessage("Produktkategori krävs");
        }
    }
}
