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
    public partial class MainWindow : Form
    {

        public MainWindow(int width, int heigth)
        {
            
            SplashScreen loader = new SplashScreen();
            this.Size = new Size(648, 492);
            loader.ShowDialog();

            this.Width = width;
            this.Height = heigth;
            
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form asd = new Form
            {
                MdiParent = this
            };
            asd.Show();

        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*"
            };
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Skill skill = new Skill {
                MdiParent = this};
            skill.Show();
        }

        private void wordStripMenuItem1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordAPP = new Microsoft.Office.Interop.Word.Application();
            wordAPP.Visible = true;
            object missing = System.Reflection.Missing.Value;

            //Create a new document
            Microsoft.Office.Interop.Word.Document document = wordAPP.Documents.Add(ref missing, ref missing, ref missing, ref missing);
        }

        private void openBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OfficeForm browser = new OfficeForm{
                MdiParent = this};
            browser.Show();

        }
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            ProtocolCreation protocolCreate = new ProtocolCreation
            {
                MdiParent = this
            };
            protocolCreate.Show();
        }
    }
}
