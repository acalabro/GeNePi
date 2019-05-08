using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoLeaf_WF.DbObjects
{
    public class Password
    {
        public int ID { get; set; }

        public int id_User { get; set; }

        public string userPassword { get; set; }

    }
}
