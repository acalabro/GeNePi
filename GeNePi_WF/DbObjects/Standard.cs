using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoLeaf_WF.DbObjects
{
    public class Standard
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Version { get; set; }

        public string Type { get; set; }

        public string Publisher { get; set; }

        public DateTime? Publisher_date { get; set; }

        public string Country { get; set; }

        public int id_Domain { get; set; }

    }
}
