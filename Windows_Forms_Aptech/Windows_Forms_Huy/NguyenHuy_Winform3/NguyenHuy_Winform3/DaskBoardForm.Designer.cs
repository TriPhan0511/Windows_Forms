namespace NguyenHuy_Winform3
{
    partial class DaskBoardForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSdtudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAttendanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBatchName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.listStudentToolStripMenuItem,
            this.listBatchToolStripMenuItem,
            this.attendanceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.editSdtudentToolStripMenuItem,
            this.deleteStudentToolStripMenuItem,
            this.manageUserToolStripMenuItem,
            this.manageAttendanceToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.addStudentToolStripMenuItem.Text = "Manage Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // editSdtudentToolStripMenuItem
            // 
            this.editSdtudentToolStripMenuItem.Name = "editSdtudentToolStripMenuItem";
            this.editSdtudentToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.editSdtudentToolStripMenuItem.Text = "Manage Teacher";
            this.editSdtudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.deleteStudentToolStripMenuItem.Text = "Manage Batch";
            this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.manageUserToolStripMenuItem.Text = "Manage User";
            // 
            // manageAttendanceToolStripMenuItem
            // 
            this.manageAttendanceToolStripMenuItem.Name = "manageAttendanceToolStripMenuItem";
            this.manageAttendanceToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.manageAttendanceToolStripMenuItem.Text = "Manage Attendance";
            // 
            // listStudentToolStripMenuItem
            // 
            this.listStudentToolStripMenuItem.Name = "listStudentToolStripMenuItem";
            this.listStudentToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.listStudentToolStripMenuItem.Text = "Lession";
            // 
            // listBatchToolStripMenuItem
            // 
            this.listBatchToolStripMenuItem.Name = "listBatchToolStripMenuItem";
            this.listBatchToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            this.attendanceToolStripMenuItem.Click += new System.EventHandler(this.attendanceToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem1,
            this.editStudentToolStripMenuItem,
            this.deleteStudentToolStripMenuItem1,
            this.manageUserToolStripMenuItem1,
            this.manageAttendanceToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 124);
            this.contextMenuStrip1.Text = "Manage User";
            // 
            // addStudentToolStripMenuItem1
            // 
            this.addStudentToolStripMenuItem1.Name = "addStudentToolStripMenuItem1";
            this.addStudentToolStripMenuItem1.Size = new System.Drawing.Size(212, 24);
            this.addStudentToolStripMenuItem1.Text = "Manage Student";
            this.addStudentToolStripMenuItem1.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // editStudentToolStripMenuItem
            // 
            this.editStudentToolStripMenuItem.Name = "editStudentToolStripMenuItem";
            this.editStudentToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.editStudentToolStripMenuItem.Text = "Manage Teacher";
            this.editStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // deleteStudentToolStripMenuItem1
            // 
            this.deleteStudentToolStripMenuItem1.Name = "deleteStudentToolStripMenuItem1";
            this.deleteStudentToolStripMenuItem1.Size = new System.Drawing.Size(212, 24);
            this.deleteStudentToolStripMenuItem1.Text = "Manage Batch";
            this.deleteStudentToolStripMenuItem1.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // manageUserToolStripMenuItem1
            // 
            this.manageUserToolStripMenuItem1.Name = "manageUserToolStripMenuItem1";
            this.manageUserToolStripMenuItem1.Size = new System.Drawing.Size(212, 24);
            this.manageUserToolStripMenuItem1.Text = "Manage User";
            // 
            // manageAttendanceToolStripMenuItem1
            // 
            this.manageAttendanceToolStripMenuItem1.Name = "manageAttendanceToolStripMenuItem1";
            this.manageAttendanceToolStripMenuItem1.Size = new System.Drawing.Size(212, 24);
            this.manageAttendanceToolStripMenuItem1.Text = "Manage Attendance";
            // 
            // labelBatchName
            // 
            this.labelBatchName.AutoSize = true;
            this.labelBatchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBatchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelBatchName.Location = new System.Drawing.Point(891, 9);
            this.labelBatchName.Name = "labelBatchName";
            this.labelBatchName.Size = new System.Drawing.Size(0, 25);
            this.labelBatchName.TabIndex = 1;
            // 
            // DaskBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.labelBatchName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DaskBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dask Board";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSdtudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBatchToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageAttendanceToolStripMenuItem1;
        private System.Windows.Forms.Label labelBatchName;
    }
}