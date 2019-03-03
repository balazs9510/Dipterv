using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWeb.DTOs.JSON
{
    public class JsonResultBase
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
