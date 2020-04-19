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
                try
                {
                    dataManager.LoadMSB3(openFileDialog.FileName);
                    textBox_filename.Text = openFileDialog.FileName;
                    button_save.Enabled = true;
                    button_save_as.Enabled = true;
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error loading file",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    dataManager.Reset();
                    textBox_filename.Text = "";
                    button_save.Enabled = false;
                    button_save_as.Enabled = false;
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveTo(textBox_filename.Text);
        }

        private void button_save_as_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = textBox_filename.Text;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveTo(saveFileDialog.FileName);
            }
        }

        private void SaveTo(string location)
        {
            try
            {
                dataManager.SaveMSB3(location);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error saving file",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
