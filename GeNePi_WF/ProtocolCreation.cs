using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtoLeaf_WF
{
    public partial class ProtocolCreation : Form
    {
        public ProtocolCreation()
        {
            InitializeComponent();
        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProtocolCreation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sftwDataSet.Domain' table. You can move, or remove it, as needed.
            this.domainTableAdapter.Fill(this.domainDataSet.Domain);
            // TODO: This line of code loads data into the 'environmentDataSet.Environment' table. You can move, or remove it, as needed.
            this.environmentTableAdapter.Fill(this.environmentDataSet.Environment);
            // TODO: This line of code loads data into the 'deviceTypeDataSet.DeviceType' table. You can move, or remove it, as needed.
            this.deviceTypeTableAdapter.Fill(this.deviceTypeDataSet.DeviceType);
            // TODO: This line of code loads data into the 'skillDataSet.Skill' table. You can move, or remove it, as needed.
            this.skillTableAdapter.Fill(this.skillDataSet.Skill);

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Message
        }
    }
}
