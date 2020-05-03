using System;
using System.Collections.Generic;
using System.Text;

namespace Seven.BaseEntity
{
    public class User : BaseGuidEntity
    {
        public string ID { get; set; }

        public string LonginID { get; set; }

        public string Account { get; set; }

        public int Type { get; set; }

    }
}
