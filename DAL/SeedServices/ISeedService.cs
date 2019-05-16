using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.SeedServices
{
    public interface ISeedService
    {
        IDictionary<string, IdentityRole> Roles { get; }
        IDictionary<string, User> Users { get; }
        IList<IdentityUserRole<string>> UserRoles { get; }
        Dictionary<string, Image> Images { get; }
        Dictionary<string, ServiceType> ServiceTypes { get; }
        Dictionary<string, Service> Services { get; }
        Dictionary<string, Event> Events { get; }
        Dictionary<string, ServicePlace> ServicePlaces { get; }
        IList<ServiceEvent> ServiceEvents { get; }
        IList<ServicePlacePosition> ServicePlacePositions { get; }
        IList<EvenSchedule> EvenSchedules { get; }
    }
}
