using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public interface IEventScheduleService
    {
        EvenSchedule GetEvenSchedule(Guid id);
        Task<EvenSchedule> GetEvenScheduleAsync(Guid id);
    }
}
