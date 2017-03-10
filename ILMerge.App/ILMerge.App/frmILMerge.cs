using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using System.Diagnostics;
using Microsoft.VisualBasic;
namespace ILMerge.App
{
    public partial class frmILMerge : MetroFramework.Forms.MetroForm
    {

        #region ClassVariable
        #endregion

        #region Property
        #endregion

        #region Constructor
        public frmILMerge()
        {
            InitializeComponent();
        }
        #endregion

        #region Built-in Events
        private void btnInputFile_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open your Application";
            openFileDialog1.Filter = "|*.exe";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                       this.txtInputPath.Text = openFileDialog1.FileName;
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Error: Could not read file from disk. Original error: " + ex.Message, "ILMerge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOutputFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select location of your new Application";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                
                this.txtOutputPath.Text = fbd.SelectedPath;
                x:
                string value = Interaction.InputBox("Enter the Output file name.", "ILMerge", "");

                if (value == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Enter the Output file name.", "ILMerge", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    goto x;
                }
                else
                {
                    if (value.Contains(".exe"))
                        this.txtOutputPath.Text += @"\" + value;
                    else
                        this.txtOutputPath.Text += @"\" + value + ".exe";
                }
 
            }
                

        }

        private void btnAddLibraries_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Select Virtual DLL Library";
            openFileDialog1.Filter = "|*.dll";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            string ApplicationName = string.Empty;
            string DirectoryName = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (string file in openFileDialog1.FileNames)
                    {
                        ApplicationName = file.Split('\\').Last();
                        DirectoryName = Path.GetDirectoryName(file);
                        this.AdvanceGridView.Rows.Add(false,ApplicationName, DirectoryName);
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Error: Could not read file from disk. Original error: " + ex.Message, "ILMerge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemoveLibrary_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.AdvanceGridView.Rows.Count; i++)
            {
                if ((bool)this.AdvanceGridView.Rows[i].Cells[0].FormattedValue)
                    this.AdvanceGridView.Rows.RemoveAt(i);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            this.AdvanceGridView.Rows.Clear();
        }

        private void btnCompressFile_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region User-Defined Methods
        private void Validation()
        {

        }
        #endregion


    }
}
