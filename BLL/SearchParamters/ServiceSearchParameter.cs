using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.SearchParamters
{
    public class ServiceSearchParameter
    {
        public Guid? ServiceTypeId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
