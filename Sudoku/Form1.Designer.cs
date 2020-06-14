namespace Sudoku
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.InputData = new System.Windows.Forms.DataGridView();
            this.Executebtn = new System.Windows.Forms.Button();
            this.OutputData = new System.Windows.Forms.DataGridView();
            this.Changebtn = new System.Windows.Forms.Button();
            this.Prebtn = new System.Windows.Forms.Button();
            this.Checkbtn = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // InputData
            // 
            this.InputData.AllowUserToAddRows = false;
            this.InputData.AllowUserToResizeColumns = false;
            this.InputData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.InputData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputData.ColumnHeadersVisible = false;
            this.InputData.Location = new System.Drawing.Point(30, 30);
            this.InputData.Name = "InputData";
            this.InputData.ReadOnly = true;
            this.InputData.RowHeadersVisible = false;
            this.InputData.Size = new System.Drawing.Size(192, 184);
            this.InputData.TabIndex = 1;
            this.InputData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.InputData_EndEdit);
            // 
            // Executebtn
            // 
            this.Executebtn.Location = new System.Drawing.Point(250, 100);
            this.Executebtn.Name = "Executebtn";
            this.Executebtn.Size = new System.Drawing.Size(120, 40);
            this.Executebtn.TabIndex = 2;
            this.Executebtn.Text = "Thực thi";
            this.Executebtn.UseVisualStyleBackColor = true;
            this.Executebtn.Click += new System.EventHandler(this.Executebtn_Click);
            // 
            // OutputData
            // 
            this.OutputData.AllowUserToAddRows = false;
            this.OutputData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.OutputData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OutputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputData.ColumnHeadersVisible = false;
            this.OutputData.Enabled = false;
            this.OutputData.Location = new System.Drawing.Point(400, 30);
            this.OutputData.Name = "OutputData";
            this.OutputData.ReadOnly = true;
            this.OutputData.RowHeadersVisible = false;
            this.OutputData.Size = new System.Drawing.Size(192, 184);
            this.OutputData.TabIndex = 1;
            // 
            // Changebtn
            // 
            this.Changebtn.Location = new System.Drawing.Point(30, 220);
            this.Changebtn.Name = "Changebtn";
            this.Changebtn.Size = new System.Drawing.Size(94, 30);
            this.Changebtn.TabIndex = 3;
            this.Changebtn.Text = "Chỉnh giá trị";
            this.Changebtn.UseVisualStyleBackColor = true;
            this.Changebtn.Click += new System.EventHandler(this.Changebtn_Click);
            // 
            // Prebtn
            // 
            this.Prebtn.Enabled = false;
            this.Prebtn.Location = new System.Drawing.Point(228, 220);
            this.Prebtn.Name = "Prebtn";
            this.Prebtn.Size = new System.Drawing.Size(85, 29);
            this.Prebtn.TabIndex = 4;
            this.Prebtn.Text = "Tiền xử lý";
            this.Prebtn.UseVisualStyleBackColor = true;
            this.Prebtn.Click += new System.EventHandler(this.Prebtn_Click);
            // 
            // Checkbtn
            // 
            this.Checkbtn.Enabled = false;
            this.Checkbtn.Location = new System.Drawing.Point(130, 220);
            this.Checkbtn.Name = "Checkbtn";
            this.Checkbtn.Size = new System.Drawing.Size(92, 29);
            this.Checkbtn.TabIndex = 4;
            this.Checkbtn.Text = "Kiểm tra";
            this.Checkbtn.UseVisualStyleBackColor = true;
            this.Checkbtn.Click += new System.EventHandler(this.Checkbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 261);
            this.Controls.Add(this.Checkbtn);
            this.Controls.Add(this.Prebtn);
            this.Controls.Add(this.Changebtn);
            this.Controls.Add(this.Executebtn);
            this.Controls.Add(this.OutputData);
            this.Controls.Add(this.InputData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SudokuSolve";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView InputData;
        private System.Windows.Forms.Button Executebtn;
        private System.Windows.Forms.DataGridView OutputData;
        private System.Windows.Forms.Button Changebtn;
        private System.Windows.Forms.Button Prebtn;
        private System.Windows.Forms.Button Checkbtn;

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

