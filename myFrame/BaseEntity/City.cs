using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEntity
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AreaCode { get; set; }

        public int ProviceId { get; set; }

        public Province Province { get; set; }
    }
}
