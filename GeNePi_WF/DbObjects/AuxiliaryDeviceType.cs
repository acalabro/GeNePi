using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoLeaf_WF.DbObjects
{
    public class AuxiliaryDeviceType
    {
        public int ID { get; set; }

        public int id_DeviceType { get; set; }

        public int? id_Environment { get; set; }

    }
}
