using System;
using AutoMapper;
using VillaVibe.Dto.Dtos.BannersDtos;
using VillaVibe.Dto.Dtos.ContactDtos;
using VillaVibe.Dto.Dtos.CounterDtos;
using VillaVibe.Dto.Dtos.DealDtos;
using VillaVibe.Dto.Dtos.FeatureDtos;
using VillaVibe.Dto.Dtos.MessageDtos;
using VillaVibe.Dto.Dtos.ProductDtos;
using VillaVibe.Dto.Dtos.QuestDtos;
using VillaVibe.Dto.Dtos.SubHeaderDtos;
using VillaVibe.Dto.Dtos.VideoDtos;
using VillaVibe.Entity.Entities;

namespace VillaVibe.Web.Mapping;

public class GeneralMapping : Profile
{
    public GeneralMapping()
    {
        CreateMap<ResultBannerDto, Banner>().ReverseMap();
        CreateMap<UpdateBannerDto, Banner>().ReverseMap();
        CreateMap<CreateBannerDto, Banner>().ReverseMap();

        CreateMap<ResultContactDto, Contact>().ReverseMap();
        CreateMap<UpdateContactDto, Contact>().ReverseMap();
        CreateMap<CreateContactDto, Contact>().ReverseMap();

        CreateMap<ResultCounterDto, Counter>().ReverseMap();
        CreateMap<UpdateCounterDto, Counter>().ReverseMap();
        CreateMap<CreateCounterDto, Counter>().ReverseMap();

        CreateMap<ResultDealDto, Deal>().ReverseMap();
        CreateMap<UpdateDealDto, Deal>().ReverseMap();
        CreateMap<CreateDealDto, Deal>().ReverseMap();

        CreateMap<ResultFeatureDto, Feature>().ReverseMap();
        CreateMap<UpdateFeatureDto, Feature>().ReverseMap();
        CreateMap<CreateFeatureDto, Feature>().ReverseMap();

        CreateMap<ResultMessageDto, Message>().ReverseMap();
        CreateMap<UpdateMessageDto, Message>().ReverseMap();
        CreateMap<CreateMessageDto, Message>().ReverseMap();

        CreateMap<ResultProductDto, Product>().ReverseMap();
        CreateMap<UpdateProductDto, Product>().ReverseMap();
        CreateMap<CreateProductDto, Product>().ReverseMap();

        CreateMap<ResultQuestDto, Quest>().ReverseMap();
        CreateMap<UpdateQuestDto, Quest>().ReverseMap();
        CreateMap<CreateQuestDto, Quest>().ReverseMap();

        CreateMap<ResultVideoDto, Video>().ReverseMap();
        CreateMap<UpdateVideoDto, Video>().ReverseMap();
        CreateMap<CreateVideoDto, Video>().ReverseMap();

        CreateMap<ResultSubHeaderDto, SubHeader>().ReverseMap();
        CreateMap<UpdateSubHeaderDto, SubHeader>().ReverseMap();
        CreateMap<CreateSubHeaderDto, SubHeader>().ReverseMap();



    }

}
