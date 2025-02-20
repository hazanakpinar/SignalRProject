using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.Business.Abstract;
using SignalR.Dto.Feature_Dto;
using SignalR.Entities.Entities;

namespace SignalR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IFeatureService _featureService;

        public FeatureController(IMapper mapper, IFeatureService FeatureService)
        {
            _mapper = mapper;
            _featureService = FeatureService;
        }
        [HttpGet]
        public IActionResult FeatureList()
        {
            var value = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            _featureService.TAdd(new Feature()
            {
                Content = createFeatureDto.Content,
                Description = createFeatureDto.Description, 
                Content2 = createFeatureDto.Content2,
                Description2 = createFeatureDto.Description2,
                Content3 = createFeatureDto.Content3,
                Description3 = createFeatureDto.Description3,
                  
            });
            return Ok("Öne Çıkan Alan Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.TGetByID(id);
            _featureService.TDelete(value);
            return Ok("Öne Çıkan Alan Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetFeature(int id)
        {
            var value = _featureService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            _featureService.TUpdate(new Feature()
            {
                Id = updateFeatureDto.Id,
                Content = updateFeatureDto.Content,
                Description = updateFeatureDto.Description,
                Content2 = updateFeatureDto.Content2,
                Description2 = updateFeatureDto.Description2,
                Content3 = updateFeatureDto.Content3,
                Description3 = updateFeatureDto.Description3,
            });
            return Ok("Öne Çıkan Alan Güncellendi");
        }
    }
}
