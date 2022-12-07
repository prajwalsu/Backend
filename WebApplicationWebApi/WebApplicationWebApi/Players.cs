using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationWebApi
{
    public class Players
    {
        [key]
        public int Id { get; set; }
        public int? ShirtNo { get; set; }
        public string Name { get; set; }
        public int? Appearances { get; set; }
        public int? Goals { get; set; }
    }
}
