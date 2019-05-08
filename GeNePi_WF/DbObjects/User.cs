using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoLeaf_WF.DbObjects
{
    public class User
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string loginName { get; set; }

        public int? id_Role { get; set; }

    }
}
