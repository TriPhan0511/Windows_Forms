using System;
using System.Windows.Forms;

namespace NguyenHuy_Winform1
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
            this.lbxEmployee = new System.Windows.Forms.ListBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxEmployee
            // 
            this.lbxEmployee.FormattingEnabled = true;
            this.lbxEmployee.ItemHeight = 16;
            this.lbxEmployee.Location = new System.Drawing.Point(12, 28);
            this.lbxEmployee.Name = "lbxEmployee";
            this.lbxEmployee.Size = new System.Drawing.Size(776, 340);
            this.lbxEmployee.TabIndex = 21;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(480, 397);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 41);
            this.SubmitButton.TabIndex = 22;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(587, 397);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 41);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(713, 397);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 41);
            this.ExitButton.TabIndex = 24;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.lbxEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ListBox lbxEmployee;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button ExitButton;
    }
}

