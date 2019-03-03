using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWeb.DTOs.JSON
{
    public class JsonResult<T> : JsonResultBase
    {
        public T Result { get; set; }
    }
}
