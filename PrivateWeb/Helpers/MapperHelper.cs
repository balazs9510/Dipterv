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
                    .ForMember(dest => dest.Image, opt => opt.Ignore());
            });
        }

        //public static IMappingExpression<TSource, TDestination>
        //    IgnoreAllNonExisting<TSource, TDestination>(this IMappingExpression<TSource, TDestination> expression)
        //{
        //    var sourceType = typeof(TSource);
        //    var destinationType = typeof(TDestination);
        //    var existingMaps = Mapper.Configuration.GetAllTypeMaps()
        //        .First(x => x.SourceType.Equals(sourceType) && x.DestinationType.Equals(destinationType));
        //    foreach (var property in existingMaps.GetUnmappedPropertyNames())
        //    {
        //        expression.ForMember(property, opt => opt.Ignore());
        //    }
        //    return expression;
        //}
    }
}
