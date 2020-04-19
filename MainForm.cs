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
    public partial class MainForm : Form
    {
        EnemyDataManager dataManager;

        public MainForm()
        {
            InitializeComponent();
            dataManager = new EnemyDataManager(dataGridView);
            Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataManager.InitializeTable();
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = textBox_filename.Text;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_filename.Text = openFileDialog.FileName;
                dataManager.LoadMSB3(openFileDialog.FileName);
                button_save.Enabled = true;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = textBox_filename.Text;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataManager.SaveMSB3(saveFileDialog.FileName);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            dataManager.DeleteSelected();
        }

        private void button_duplicate_Click(object sender, EventArgs e)
        {
            dataManager.DuplicateSelected();
        }
    }
}
