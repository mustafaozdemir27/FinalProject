using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        // Interface methodları default olarak public'tir ama kendisi değil.
        List<ProductDetailDto> GetProductDetails();

    }
}

// Code Refactoring