using AutoMapper;
using DAL.Entities;
using PrivateWeb.ViewModels;

namespace PrivateWeb.Helpers
{
    public static class MapperHelper
    {
        public static void InitializeMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Service, ServiceViewModel>()
                    .ForMember(dest => dest.Image, opt => opt.Ignore());
                cfg.CreateMap<ServiceViewModel, Service>()
                    .ForMember(dest => dest.Image, opt => opt.Ignore())
                    .ForMember(dest => dest.Id, opt => opt.Ignore());

                cfg.CreateMap<Event, EventViewModel>()
                    .ForMember(dest => dest.Image, opt => opt.Ignore());
                cfg.CreateMap<EventViewModel, Event>()
                    .ForMember(dest => dest.Image, opt => opt.Ignore())
                    .ForMember(dest => dest.Id, opt => opt.Ignore());

                cfg.CreateMap<ServicePlace, ServicePlaceViewModel>()
                    .ForMember(dest => dest.LayoutImage, opt => opt.Ignore())
                    .ForMember(dest => dest.ServiceName, opt => opt.MapFrom(x => x.Service.Name));
                cfg.CreateMap<ServicePlaceViewModel, ServicePlace>()
                    .ForMember(dest => dest.LayoutImage, opt => opt.Ignore())
                    .ForMember(dest => dest.Id, opt => opt.Ignore());

                cfg.CreateMap<ServiceEvent, ServiceEventViewModel>();
                cfg.CreateMap<ServiceEventViewModel, ServiceEvent>();
            });
        }
    }
}
