using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3EnemyEditor
{
    public partial class SearchDialog : Form
    {
        public string text
        {
            get { return textBox.Text; }
        }

        public SearchDialog()
        {
            InitializeComponent();
            Shown += ShownHandler;
        }

        private void ShownHandler(Object sender, EventArgs e)
        {
            textBox.SelectAll();
            textBox.Focus();
        }


        private void button_accept_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Ctrl-F : Search\n" +
                "F3 : Search Next",
                "Info", MessageBoxButtons.OK);
        }
    }
}
