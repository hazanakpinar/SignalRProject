using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.Business.Abstract;
using SignalR.Dto.Product_Dto;
using SignalR.Entities.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public ProductController(IMapper mapper, IProductService ProductService)
        {
            _mapper = mapper;
            _productService = ProductService;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(value);
        }

        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var value = _mapper.Map<List<ResultProductWithCategory>>(_productService.TGetProductWithCategories());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
                Description = createProductDto.Description,
                 Image = createProductDto.Image,
                   Name = createProductDto.Name,
                    Price = createProductDto.Price,
                     Status = createProductDto.Status
            });
            return Ok("Ürün Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Ürün Silindi");
        }
        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                Id = updateProductDto.Id,
                Description = updateProductDto.Description,
                Image = updateProductDto.Image,
                Name = updateProductDto.Name,
                Price = updateProductDto.Price,
                Status = updateProductDto.Status
            });
            return Ok("Ürün Güncellendi");
        }
    }
}
