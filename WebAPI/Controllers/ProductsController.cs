using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // <-- ATTRIBUTE BIR CLASS ILE ILGILI BILGI VERME IMZA VERME YONTEMIDIR

    public class ProductsController : ControllerBase
    {
        // Loosely coupled
        // naming convention
        // IoC Container -- Inversion of Control
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public List<Product> Get()
        {

            // Dependency chain --
            //IProductService productService = new ProductManager(new EfProductDal());
            var result = _productService.GetAll();
            return _productService.GetAll().Data;
 
        }
    }
}
