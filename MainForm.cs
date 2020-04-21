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
        private SearchDialog searchDialog;

        private EnemyDataManager dataManager;

        public MainForm()
        {
            InitializeComponent();
            searchDialog = new SearchDialog();
            this.KeyPreview = true;
            Load += new EventHandler(LoadHandler);

            dataManager = new EnemyDataManager(dataGridView);
        }

        private void LoadHandler(object sender, EventArgs e)
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

        private void button_search_Click(object sender, EventArgs e)
        {
            StartSearch();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                StartSearch();
                return true;
            }
            if (keyData == Keys.F3)
            {
                DoSearch();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void StartSearch()
        {
            if (searchDialog.ShowDialog(this) == DialogResult.OK)
            {
                DoSearch();
            }
        }

        private void DoSearch()
        {
            if (searchDialog.text != "" &&
                !dataManager.SearchString(searchDialog.text))
            {
                MessageBox.Show("No match found", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
