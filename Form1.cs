using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessFormatCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void htmlEditControl1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.D1 && e.Control)
            {
                ((ToolStripComboBox)this.htmlEditControl1.ToolStripItems["FormatSelectionCombo"]).Text = "Heading 1";
                ((ToolStripComboBox)this.htmlEditControl1.ToolStripItems["FormatSelectionCombo"]).PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
