//using AutoMapper;
//using DtoLayer.DTOs.AnnouncementDTOs;
//using DtoLayer.DTOs.AppUserDTOs;
//using DtoLayer.DTOs.ContactDTOs;
//using EntityLayer.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Traversal.Mapping.AutoMapperProfile
//{
//    public class MapProfile : Profile
//    {
//        public MapProfile()
//        {
//            CreateMap<AnnouncementAddDto, Haber>();
//            CreateMap<Haber, AnnouncementAddDto>();

//            CreateMap<AppUserRegisterDTOs, AppUser>();
//            CreateMap<AppUser, AppUserRegisterDTOs>();

//            CreateMap<AppUserLoginDTOs, AppUser>();
//            CreateMap<AppUser, AppUserLoginDTOs>();

//            CreateMap<AnnouncementListDto, Haber>();
//            CreateMap<Haber, AnnouncementListDto>();

//            CreateMap<AnnouncementUpdateDto, Haber>();
//            CreateMap<Haber, AnnouncementUpdateDto>();

//            CreateMap<SendMessageDto, ContactUs>().ReverseMap();
//        }
//    }
//}
