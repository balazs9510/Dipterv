using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Image
    {
        public Guid Id { get; set; }
        public byte[] Content { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
    }
}
