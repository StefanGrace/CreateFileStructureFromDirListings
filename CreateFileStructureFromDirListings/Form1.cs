using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateFileStructureFromDirListings
{
    public partial class Form1 : Form
    {
        private string[] args;
        private DirListingsToFileStructure fsCreator = new DirListingsToFileStructure();

        public Form1(string[] args)
        {
            this.args = args;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (args.Length > 0)
            {
                textBox_dirListingPath.Text = args[0];
            }
            comboBox_sizeUnit.SelectedIndex = 0;
            comboBox_invalidCharReplacement.SelectedIndex = 0;
            comboBox_inputSizeUnit.SelectedIndex = 0;
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            if (textBox_dirListingPath.Text == "")
            {
                MessageBox.Show("Please enter a file path for the input dir listings TXT files.");
                return;
            }

            if (!System.IO.File.Exists(textBox_dirListingPath.Text.Replace("\"", "")))
            {
                MessageBox.Show("\"" + textBox_dirListingPath.Text.Replace("\"", "") + "\" does not exist.");
                return;
            }

            if (textBox_fsPath.Text == "") 
            {
                MessageBox.Show("Please enter a folder path for file structure to be created");
                return;
            }

            /*if (!System.IO.Directory.Exists(textBox_fsPath.Text))
            {
                System.IO.Directory.CreateDirectory(textBox_fsPath.Text);
            }*/

            BuildFileStruce();
        }

        private async void BuildFileStruce()
        {
            string[] dirListingLines = System.IO.File.ReadAllLines(textBox_dirListingPath.Text.Replace("\"", ""), Encoding.Default);
            progressBar.Maximum = dirListingLines.Length;
            IProgress<int> progress = new Progress<int>(count =>
            {
                progressBar.Value = count;
                label_progressPercent.Text = (((double)progressBar.Value / progressBar.Maximum) * 100).ToString("N0") + "%";
            });
            label_loading.Visible = true;
            progressBar.Visible = true;
            label_progressPercent.Visible = true;
            button_Create.Enabled = false;
            await Task.Run(() =>
            {
                fsCreator.CreateFileStructure(dirListingLines, textBox_fsPath.Text, checkBox_includeFiles.Checked, progress);
            });
            label_loading.Visible = false;
            progressBar.Visible = false;
            label_progressPercent.Visible = false;
            button_Create.Enabled = true;
        }

        private void checkBox_addFileSizeToName_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_fileSizeBeforeName.Enabled = checkBox_addFileSizeToName.Checked;
            radioButton_fileSizeAfterName.Enabled = checkBox_addFileSizeToName.Checked;
            label_sizeUnit.Enabled = checkBox_addFileSizeToName.Checked;
            comboBox_sizeUnit.Enabled = checkBox_addFileSizeToName.Checked;
            SetFileSizeInName();
        }

        private void radioButton_fileSizeBeforeName_CheckedChanged(object sender, EventArgs e)
        {
            SetFileSizeInName();
        }

        private void radioButton_fileSizeAfterName_CheckedChanged(object sender, EventArgs e)
        {
            SetFileSizeInName();
        }

        private void checkBox_includeFiles_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_fileSize.Enabled = checkBox_includeFiles.Checked;
        }

        private void comboBox_invalidCharReplacement_SelectedIndexChanged(object sender, EventArgs e)
        {
            fsCreator.InvalidCharReplacement = comboBox_invalidCharReplacement.SelectedItem.ToString()[0];
        }

        /*
        private void checkBox_addFolderSizeToName_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_folderSizeBeforeName.Enabled = checkBox_addFolderSizeToName.Checked;
            radioButton_folderSizeAfterName.Enabled = checkBox_addFolderSizeToName.Checked;
            SetFolderSizeInName();
        }

        private void radioButton_folderSizeBeforeName_CheckedChanged(object sender, EventArgs e)
        {
            SetFolderSizeInName();
        }

        private void radioButton_folderSizeAfterName_CheckedChanged(object sender, EventArgs e)
        {
            SetFolderSizeInName();
        }
        */

        private void comboBox_sizeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            fsCreator.SizeUnit = comboBox_sizeUnit.SelectedItem.ToString();
        }

        private void SetFileSizeInName()
        {
            if (!checkBox_addFileSizeToName.Checked)
            {
                fsCreator.AddFileSizeToName = 0;
            }
            else if (radioButton_fileSizeBeforeName.Checked)
            {
                fsCreator.AddFileSizeToName = 1;
            }
            else
            {
                fsCreator.AddFileSizeToName = 2;
            }
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program takes the TXT file that Karen's Directory Printer outputs, and creates the original file structure, either with just the folders, or with the folder and empty versions of the files. It will also set the correct date modified and date created for the folders and files if they are present in the dir listing TXT. It can also add the file size to the start or end of the file names. ", "About");
        }

        private void comboBox_inputSizeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] sizeUnits = { 1000, 1024 };
            fsCreator.InputBytesInKB = sizeUnits[comboBox_inputSizeUnit.SelectedIndex];
        }


        /*
        private void SetFolderSizeInName()
        {
            if (!checkBox_addFolderSizeToName.Checked)
            {
                fsCreator.AddFolderSizeToName = 0;
            }
            else if (radioButton_folderSizeBeforeName.Checked)
            {
                fsCreator.AddFolderSizeToName = 1;
            }
            else
            {
                fsCreator.AddFolderSizeToName = 2;
            }
        }
        */
    }
}
