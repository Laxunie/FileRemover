
namespace FileRemover
{
    partial class Form1
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lviewFiles = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(139, 13);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Please choose a folder path";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(14, 29);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(23, 13);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "File";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(43, 26);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(452, 20);
            this.txtPath.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(501, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 22);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lviewFiles
            // 
            this.lviewFiles.AllowColumnReorder = true;
            this.lviewFiles.CheckBoxes = true;
            this.lviewFiles.HideSelection = false;
            this.lviewFiles.Location = new System.Drawing.Point(43, 70);
            this.lviewFiles.Name = "lviewFiles";
            this.lviewFiles.Size = new System.Drawing.Size(717, 351);
            this.lviewFiles.TabIndex = 4;
            this.lviewFiles.UseCompatibleStateImageBehavior = false;
            this.lviewFiles.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lviewFiles_ItemChecked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(685, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lviewFiles);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblInstructions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lviewFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDelete;
    }
}

