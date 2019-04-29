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
    public partial class Skill : Form
    {
        public Skill()
        {
            InitializeComponent();
        }

        private void Skill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'skillAndStandardDataSet.Skill_Standards' table. You can move, or remove it, as needed.
            this.skill_StandardsTableAdapter.Fill(this.skillAndStandardDataSet.Skill_Standards);
        }
    }
}
