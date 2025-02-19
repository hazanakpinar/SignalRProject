using AutoMapper;
using SignalR.Dto.About_Dto;
using SignalR.Dto.Booking_Dto;
using SignalR.Dto.Category_Dto;
using SignalR.Dto.Discount_Dto;
using SignalR.Dto.Info_Dto;
using SignalR.Dto.Product_Dto;
using SignalR.Dto.SocialMedia_Dto;
using SignalR.Dto.Testimonial_Dto;
using SignalR.Dto.Feature_Dto;
using SignalR.Entities.Entities;


namespace SignalR.API.Mapping
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            //About
            CreateMap<About,ResultAboutDto>().ReverseMap();
            CreateMap<About,CreateAboutDto>().ReverseMap();
            CreateMap<About,UpdateAboutDto>().ReverseMap();
            CreateMap<About,GetAboutDto>().ReverseMap();
            //Booking
            CreateMap<Booking, ResultBookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
            CreateMap<Booking, GetBookingDto>().ReverseMap();
            //Category
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            //Discount
            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
            CreateMap<Discount, GetDiscountDto>().ReverseMap();
            //Feature
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetFeatureDto>().ReverseMap();
            //Info
            CreateMap<Info, ResultInfoDto>().ReverseMap();
            CreateMap<Info, CreateInfoDto>().ReverseMap();
            CreateMap<Info, UpdateInfoDto>().ReverseMap();
            CreateMap<Info, GetInfoDto>().ReverseMap();
            //Product
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, ResultProductWithCategory>().ReverseMap();
            //SocialMedia
            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, GetSocialMediaDto>().ReverseMap();
            // Testimonial
            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();

           

        }
    }
}
