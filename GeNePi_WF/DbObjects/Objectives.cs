using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoLeaf_WF.DbObjects
{
    public class Objectives
    {
        public int ID { get; set; }

        public int id_Skill { get; set; }

        public int id_BehaviorsToBeTested { get; set; }

        public int id_TargetMetrics { get; set; }

        public string extraText { get; set; }

    }

}
