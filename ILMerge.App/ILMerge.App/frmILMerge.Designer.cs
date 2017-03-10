namespace ILMerge.App
{
    partial class frmILMerge
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmILMerge));
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.txtInputPath = new MetroFramework.Controls.MetroTextBox();
            this.btnInputFile = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupOutput = new System.Windows.Forms.GroupBox();
            this.txtOutputPath = new MetroFramework.Controls.MetroTextBox();
            this.btnOutputFile = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCompressFile = new MetroFramework.Controls.MetroButton();
            this.AdvanceGridView = new MetroFramework.Controls.MetroGrid();
            this.btnRemoveAll = new MetroFramework.Controls.MetroButton();
            this.btnRemoveLibrary = new MetroFramework.Controls.MetroButton();
            this.btnAddLibraries = new MetroFramework.Controls.MetroButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.chkValue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdvanceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupInput
            // 
            this.groupInput.Controls.Add(this.txtInputPath);
            this.groupInput.Controls.Add(this.btnInputFile);
            this.groupInput.Controls.Add(this.pictureBox1);
            this.groupInput.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInput.Location = new System.Drawing.Point(23, 77);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(501, 57);
            this.groupInput.TabIndex = 1;
            this.groupInput.TabStop = false;
            this.groupInput.Text = "Input file";
            // 
            // txtInputPath
            // 
            // 
            // 
            // 
            this.txtInputPath.CustomButton.Image = null;
            this.txtInputPath.CustomButton.Location = new System.Drawing.Point(341, 1);
            this.txtInputPath.CustomButton.Name = "";
            this.txtInputPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInputPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInputPath.CustomButton.TabIndex = 1;
            this.txtInputPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInputPath.CustomButton.UseSelectable = true;
            this.txtInputPath.CustomButton.Visible = false;
            this.txtInputPath.Lines = new string[0];
            this.txtInputPath.Location = new System.Drawing.Point(37, 21);
            this.txtInputPath.MaxLength = 32767;
            this.txtInputPath.Name = "txtInputPath";
            this.txtInputPath.PasswordChar = '\0';
            this.txtInputPath.PromptText = "C:\\MyApp\\YouCrackedMeUp.exe";
            this.txtInputPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInputPath.SelectedText = "";
            this.txtInputPath.SelectionLength = 0;
            this.txtInputPath.SelectionStart = 0;
            this.txtInputPath.ShortcutsEnabled = true;
            this.txtInputPath.Size = new System.Drawing.Size(363, 23);
            this.txtInputPath.TabIndex = 6;
            this.txtInputPath.UseSelectable = true;
            this.txtInputPath.WaterMark = "C:\\MyApp\\YouCrackedMeUp.exe";
            this.txtInputPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInputPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnInputFile
            // 
            this.btnInputFile.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnInputFile.Location = new System.Drawing.Point(406, 21);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(85, 22);
            this.btnInputFile.TabIndex = 5;
            this.btnInputFile.Text = "Select file";
            this.btnInputFile.UseSelectable = true;
            this.btnInputFile.Click += new System.EventHandler(this.btnInputFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ILMerge.App.Properties.Resources.folder;
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupOutput
            // 
            this.groupOutput.Controls.Add(this.txtOutputPath);
            this.groupOutput.Controls.Add(this.btnOutputFile);
            this.groupOutput.Controls.Add(this.pictureBox2);
            this.groupOutput.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupOutput.Location = new System.Drawing.Point(23, 140);
            this.groupOutput.Name = "groupOutput";
            this.groupOutput.Size = new System.Drawing.Size(501, 57);
            this.groupOutput.TabIndex = 7;
            this.groupOutput.TabStop = false;
            this.groupOutput.Text = "Output file";
            // 
            // txtOutputPath
            // 
            // 
            // 
            // 
            this.txtOutputPath.CustomButton.Image = null;
            this.txtOutputPath.CustomButton.Location = new System.Drawing.Point(341, 1);
            this.txtOutputPath.CustomButton.Name = "";
            this.txtOutputPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOutputPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOutputPath.CustomButton.TabIndex = 1;
            this.txtOutputPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOutputPath.CustomButton.UseSelectable = true;
            this.txtOutputPath.CustomButton.Visible = false;
            this.txtOutputPath.Lines = new string[0];
            this.txtOutputPath.Location = new System.Drawing.Point(37, 21);
            this.txtOutputPath.MaxLength = 32767;
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.PasswordChar = '\0';
            this.txtOutputPath.PromptText = "C:\\MyApp\\Merged\\ComeAndGetMe.exe";
            this.txtOutputPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOutputPath.SelectedText = "";
            this.txtOutputPath.SelectionLength = 0;
            this.txtOutputPath.SelectionStart = 0;
            this.txtOutputPath.ShortcutsEnabled = true;
            this.txtOutputPath.Size = new System.Drawing.Size(363, 23);
            this.txtOutputPath.TabIndex = 6;
            this.txtOutputPath.UseSelectable = true;
            this.txtOutputPath.WaterMark = "C:\\MyApp\\Merged\\ComeAndGetMe.exe";
            this.txtOutputPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOutputPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnOutputFile
            // 
            this.btnOutputFile.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnOutputFile.Location = new System.Drawing.Point(406, 21);
            this.btnOutputFile.Name = "btnOutputFile";
            this.btnOutputFile.Size = new System.Drawing.Size(85, 22);
            this.btnOutputFile.TabIndex = 5;
            this.btnOutputFile.Text = "Select file";
            this.btnOutputFile.UseSelectable = true;
            this.btnOutputFile.Click += new System.EventHandler(this.btnOutputFile_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ILMerge.App.Properties.Resources.save;
            this.pictureBox2.Location = new System.Drawing.Point(6, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCompressFile);
            this.groupBox1.Controls.Add(this.AdvanceGridView);
            this.groupBox1.Controls.Add(this.btnRemoveAll);
            this.groupBox1.Controls.Add(this.btnRemoveLibrary);
            this.groupBox1.Controls.Add(this.btnAddLibraries);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 205);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bind virtual DLL libraries";
            // 
            // btnCompressFile
            // 
            this.btnCompressFile.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCompressFile.Location = new System.Drawing.Point(406, 105);
            this.btnCompressFile.Name = "btnCompressFile";
            this.btnCompressFile.Size = new System.Drawing.Size(89, 94);
            this.btnCompressFile.TabIndex = 15;
            this.btnCompressFile.Text = "Compress file";
            this.btnCompressFile.UseSelectable = true;
            this.btnCompressFile.Click += new System.EventHandler(this.btnCompressFile_Click);
            // 
            // AdvanceGridView
            // 
            this.AdvanceGridView.AllowUserToAddRows = false;
            this.AdvanceGridView.AllowUserToDeleteRows = false;
            this.AdvanceGridView.AllowUserToResizeColumns = false;
            this.AdvanceGridView.AllowUserToResizeRows = false;
            this.AdvanceGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdvanceGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdvanceGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.AdvanceGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AdvanceGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AdvanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdvanceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkValue,
            this.FileName,
            this.FilePath});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AdvanceGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.AdvanceGridView.EnableHeadersVisualStyles = false;
            this.AdvanceGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AdvanceGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdvanceGridView.Location = new System.Drawing.Point(44, 21);
            this.AdvanceGridView.MultiSelect = false;
            this.AdvanceGridView.Name = "AdvanceGridView";
            this.AdvanceGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AdvanceGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.AdvanceGridView.RowHeadersVisible = false;
            this.AdvanceGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AdvanceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AdvanceGridView.Size = new System.Drawing.Size(356, 178);
            this.AdvanceGridView.Style = MetroFramework.MetroColorStyle.Blue;
            this.AdvanceGridView.TabIndex = 14;
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRemoveAll.Location = new System.Drawing.Point(406, 77);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(85, 22);
            this.btnRemoveAll.TabIndex = 8;
            this.btnRemoveAll.Text = "Remove all";
            this.btnRemoveAll.UseSelectable = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemoveLibrary
            // 
            this.btnRemoveLibrary.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnRemoveLibrary.Location = new System.Drawing.Point(406, 49);
            this.btnRemoveLibrary.Name = "btnRemoveLibrary";
            this.btnRemoveLibrary.Size = new System.Drawing.Size(85, 22);
            this.btnRemoveLibrary.TabIndex = 7;
            this.btnRemoveLibrary.Text = "Remove Library";
            this.btnRemoveLibrary.UseSelectable = true;
            this.btnRemoveLibrary.Click += new System.EventHandler(this.btnRemoveLibrary_Click);
            // 
            // btnAddLibraries
            // 
            this.btnAddLibraries.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnAddLibraries.Location = new System.Drawing.Point(406, 21);
            this.btnAddLibraries.Name = "btnAddLibraries";
            this.btnAddLibraries.Size = new System.Drawing.Size(85, 22);
            this.btnAddLibraries.TabIndex = 5;
            this.btnAddLibraries.Text = "Add Libraries";
            this.btnAddLibraries.UseSelectable = true;
            this.btnAddLibraries.Click += new System.EventHandler(this.btnAddLibraries_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ILMerge.App.Properties.Resources.bookshelf;
            this.pictureBox3.Location = new System.Drawing.Point(6, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // chkValue
            // 
            this.chkValue.DataPropertyName = "chkValue";
            this.chkValue.HeaderText = "";
            this.chkValue.Name = "chkValue";
            this.chkValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chkValue.Width = 20;
            // 
            // FileName
            // 
            this.FileName.DataPropertyName = "FileName";
            this.FileName.HeaderText = "File name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FileName.ToolTipText = "File name";
            this.FileName.Width = 190;
            // 
            // FilePath
            // 
            this.FilePath.DataPropertyName = "FilePath";
            this.FilePath.HeaderText = "File Path";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FilePath.Width = 1000;
            // 
            // frmILMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::ILMerge.App.Properties.Resources.triple_arrow_merging_to_one__1_;
            this.BackImagePadding = new System.Windows.Forms.Padding(8, 15, 0, 0);
            this.BackMaxSize = 35;
            this.ClientSize = new System.Drawing.Size(547, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupOutput);
            this.Controls.Add(this.groupInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(547, 438);
            this.MinimumSize = new System.Drawing.Size(547, 438);
            this.Name = "frmILMerge";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "   ILMerge";
            this.groupInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdvanceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnInputFile;
        private MetroFramework.Controls.MetroTextBox txtInputPath;
        private System.Windows.Forms.GroupBox groupOutput;
        private MetroFramework.Controls.MetroTextBox txtOutputPath;
        private MetroFramework.Controls.MetroButton btnOutputFile;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnAddLibraries;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroButton btnRemoveLibrary;
        private MetroFramework.Controls.MetroButton btnRemoveAll;
        private MetroFramework.Controls.MetroGrid AdvanceGridView;
        private MetroFramework.Controls.MetroButton btnCompressFile;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
    }
}

