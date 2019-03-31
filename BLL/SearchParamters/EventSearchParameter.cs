using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.SearchParamters
{
    public class EventSearchParameter
    {
        public string Name { get; set; }
        public Guid? ServiceId { get; set; }
        public DateTime? BeginDate { get; set; }
    }
}
