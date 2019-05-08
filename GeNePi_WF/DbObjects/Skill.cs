using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoLeaf_WF.DbObjects
{
    public class Skill
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Short_Description { get; set; }

        public string Definition { get; set; }

        public int? id_AbstractTargetMetrics { get; set; }

    }
}
