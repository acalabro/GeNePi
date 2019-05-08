using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoLeaf_WF.DbObjects
{
    public class Requirement
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Section { get; set; }

        public int? id_Directive { get; set; }

    }
}
