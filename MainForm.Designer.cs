namespace DS3EnemyEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_load = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.textBox_filename = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_duplicate = new System.Windows.Forms.Button();
            this.button_save_as = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button_load
            // 
            this.button_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_load.Location = new System.Drawing.Point(1506, 1096);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(60, 36);
            this.button_load.TabIndex = 0;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_save
            // 
            this.button_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save.Enabled = false;
            this.button_save.Location = new System.Drawing.Point(1440, 1096);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(60, 36);
            this.button_save.TabIndex = 7;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 44);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(1554, 1046);
            this.dataGridView.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // textBox_filename
            // 
            this.textBox_filename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_filename.Location = new System.Drawing.Point(12, 12);
            this.textBox_filename.Name = "textBox_filename";
            this.textBox_filename.ReadOnly = true;
            this.textBox_filename.Size = new System.Drawing.Size(1554, 26);
            this.textBox_filename.TabIndex = 1;
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_delete.Location = new System.Drawing.Point(12, 1096);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(70, 36);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_duplicate
            // 
            this.button_duplicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_duplicate.Location = new System.Drawing.Point(88, 1096);
            this.button_duplicate.Name = "button_duplicate";
            this.button_duplicate.Size = new System.Drawing.Size(90, 36);
            this.button_duplicate.TabIndex = 4;
            this.button_duplicate.Text = "Duplicate";
            this.button_duplicate.UseVisualStyleBackColor = true;
            this.button_duplicate.Click += new System.EventHandler(this.button_duplicate_Click);
            // 
            // button_save_as
            // 
            this.button_save_as.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_save_as.Enabled = false;
            this.button_save_as.Location = new System.Drawing.Point(1354, 1096);
            this.button_save_as.Name = "button_save_as";
            this.button_save_as.Size = new System.Drawing.Size(80, 36);
            this.button_save_as.TabIndex = 6;
            this.button_save_as.Text = "Save As";
            this.button_save_as.UseMnemonic = false;
            this.button_save_as.UseVisualStyleBackColor = true;
            this.button_save_as.Click += new System.EventHandler(this.button_save_as_Click);
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_search.Location = new System.Drawing.Point(184, 1096);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(70, 36);
            this.button_search.TabIndex = 5;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 1144);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_save_as);
            this.Controls.Add(this.button_duplicate);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textBox_filename);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_load);
            this.Name = "MainForm";
            this.Text = "DS3 Enemy Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox textBox_filename;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_duplicate;
        private System.Windows.Forms.Button button_save_as;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_search;
    }
}

