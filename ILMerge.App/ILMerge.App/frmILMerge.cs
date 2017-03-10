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
                this.txtOutputPath.Text = fbd.SelectedPath;

        }

        private void btnAddLibraries_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Select Virtual DLL Library";
            openFileDialog1.Filter = "|*.dll";
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


                    //Read the files
                    foreach (string file in openFileDialog1.FileNames)
                    {
                        this.txtInputPath.Text = file;
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

        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {

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
