using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Random random = new Random(37);

        public Form1()
        {
            InitializeComponent();
            lvDummy.Columns.Add("Name");
            lvDummy.Columns.Add("Depth");
        }

        private void grpFont_Enter(object sender, EventArgs e)
        {

        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var Fonts = FontFamily.Families;
            foreach (FontFamily font in Fonts)
            {
                cboFont.Items.Add(font.Name);
            }
        }
        void ChangeFont()
        {
            if (cboFont.SelectedIndex < 0) return;
            FontStyle Style = FontStyle.Regular;
            if (chkBold.Checked) Style |= FontStyle.Bold;
            if (chkItalic.Checked) Style |= FontStyle.Italic;
            txtSampleText.Font = new Font((string)cboFont.SelectedItem, 10, Style);
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void tbDummy_Scroll(object sender, EventArgs e)
        {
            pgDummy.Value = tbDummy.Value;  // 슬라이더의 위치에 따라 프로그레스바의 내용도 변경
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Modal Form";
            form.Width = 300;
            form.Height = 100;
            form.BackColor = Color.Red;
            form.ShowDialog();  // 모달 창 띄움
        }

        private void btnModaless_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Text = "Modaless Form";
            form.Width = 300;
            form.Height = 300;
            form.BackColor = Color.Green;
            form.Show();  // 모달리스 창 띄움
        }

        private void btnMsgBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSampleText.Text, "MessageBox Test", MessageBoxButtons.OK);
        }

        private void btnAddRoot_Click(object sender, EventArgs e)
        {
            tvDummy.Nodes.Add(random.Next().ToString());
            TreeToList();
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if (tvDummy.SelectedNode == null)
            {
                MessageBox.Show(
                    "선택된 노드가 없습니다.", "TreeView Test", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tvDummy.SelectedNode.Nodes.Add(random.Next().ToString());
            tvDummy.SelectedNode.Expand();
            TreeToList();
        }

        void TreeToList()
        {
            lvDummy.Items.Clear();
            foreach (TreeNode node in tvDummy.Nodes) TreeToList(node);
        }

        void TreeToList(TreeNode Node)
        {
            lvDummy.Items.Add(
                new ListViewItem(
                    new string[] { Node.Text, Node.FullPath.Count(f => f == '\\').ToString() }));
            foreach (TreeNode node in Node.Nodes) TreeToList(node);
        }
    }
}
