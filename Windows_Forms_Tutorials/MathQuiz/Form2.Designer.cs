namespace MathQuiz
{
    partial class Form2
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addLeftLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addRightLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addResult = new System.Windows.Forms.NumericUpDown();
            this.subtractResult = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.subtractRightLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.subtractLeftLabel = new System.Windows.Forms.Label();
            this.multiplicationResult = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.multiplicationRightLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.multiplicationLeftLabel = new System.Windows.Forms.Label();
            this.divisionResult = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.divisionRightLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.divisionLeftLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtractResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplicationResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionResult)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(245, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(227, 39);
            this.timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time remaining";
            // 
            // addLeftLabel
            // 
            this.addLeftLabel.AutoSize = true;
            this.addLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLeftLabel.Location = new System.Drawing.Point(83, 84);
            this.addLeftLabel.Name = "addLeftLabel";
            this.addLeftLabel.Size = new System.Drawing.Size(23, 25);
            this.addLeftLabel.TabIndex = 2;
            this.addLeftLabel.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            // 
            // addRightLabel
            // 
            this.addRightLabel.AutoSize = true;
            this.addRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRightLabel.Location = new System.Drawing.Point(171, 84);
            this.addRightLabel.Name = "addRightLabel";
            this.addRightLabel.Size = new System.Drawing.Size(23, 25);
            this.addRightLabel.TabIndex = 4;
            this.addRightLabel.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            // 
            // addResult
            // 
            this.addResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addResult.Location = new System.Drawing.Point(274, 82);
            this.addResult.Name = "addResult";
            this.addResult.Size = new System.Drawing.Size(120, 30);
            this.addResult.TabIndex = 0;
            // 
            // subtractResult
            // 
            this.subtractResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractResult.Location = new System.Drawing.Point(274, 137);
            this.subtractResult.Name = "subtractResult";
            this.subtractResult.Size = new System.Drawing.Size(120, 30);
            this.subtractResult.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "=";
            // 
            // subtractRightLabel
            // 
            this.subtractRightLabel.AutoSize = true;
            this.subtractRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractRightLabel.Location = new System.Drawing.Point(171, 139);
            this.subtractRightLabel.Name = "subtractRightLabel";
            this.subtractRightLabel.Size = new System.Drawing.Size(23, 25);
            this.subtractRightLabel.TabIndex = 9;
            this.subtractRightLabel.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "-";
            // 
            // subtractLeftLabel
            // 
            this.subtractLeftLabel.AutoSize = true;
            this.subtractLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractLeftLabel.Location = new System.Drawing.Point(83, 139);
            this.subtractLeftLabel.Name = "subtractLeftLabel";
            this.subtractLeftLabel.Size = new System.Drawing.Size(23, 25);
            this.subtractLeftLabel.TabIndex = 7;
            this.subtractLeftLabel.Text = "?";
            // 
            // multiplicationResult
            // 
            this.multiplicationResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationResult.Location = new System.Drawing.Point(274, 192);
            this.multiplicationResult.Name = "multiplicationResult";
            this.multiplicationResult.Size = new System.Drawing.Size(120, 30);
            this.multiplicationResult.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(224, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "=";
            // 
            // multiplicationRightLabel
            // 
            this.multiplicationRightLabel.AutoSize = true;
            this.multiplicationRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationRightLabel.Location = new System.Drawing.Point(171, 194);
            this.multiplicationRightLabel.Name = "multiplicationRightLabel";
            this.multiplicationRightLabel.Size = new System.Drawing.Size(23, 25);
            this.multiplicationRightLabel.TabIndex = 14;
            this.multiplicationRightLabel.Text = "?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(130, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "x";
            // 
            // multiplicationLeftLabel
            // 
            this.multiplicationLeftLabel.AutoSize = true;
            this.multiplicationLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationLeftLabel.Location = new System.Drawing.Point(83, 194);
            this.multiplicationLeftLabel.Name = "multiplicationLeftLabel";
            this.multiplicationLeftLabel.Size = new System.Drawing.Size(23, 25);
            this.multiplicationLeftLabel.TabIndex = 12;
            this.multiplicationLeftLabel.Text = "?";
            // 
            // divisionResult
            // 
            this.divisionResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionResult.Location = new System.Drawing.Point(274, 250);
            this.divisionResult.Name = "divisionResult";
            this.divisionResult.Size = new System.Drawing.Size(120, 30);
            this.divisionResult.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(224, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "=";
            // 
            // divisionRightLabel
            // 
            this.divisionRightLabel.AutoSize = true;
            this.divisionRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionRightLabel.Location = new System.Drawing.Point(171, 252);
            this.divisionRightLabel.Name = "divisionRightLabel";
            this.divisionRightLabel.Size = new System.Drawing.Size(23, 25);
            this.divisionRightLabel.TabIndex = 19;
            this.divisionRightLabel.Text = "?";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(130, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 25);
            this.label14.TabIndex = 18;
            this.label14.Text = "/";
            // 
            // divisionLeftLabel
            // 
            this.divisionLeftLabel.AutoSize = true;
            this.divisionLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionLeftLabel.Location = new System.Drawing.Point(83, 252);
            this.divisionLeftLabel.Name = "divisionLeftLabel";
            this.divisionLeftLabel.Size = new System.Drawing.Size(23, 25);
            this.divisionLeftLabel.TabIndex = 17;
            this.divisionLeftLabel.Text = "?";
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(167, 305);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(136, 35);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start the quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.divisionResult);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.divisionRightLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.divisionLeftLabel);
            this.Controls.Add(this.multiplicationResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.multiplicationRightLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.multiplicationLeftLabel);
            this.Controls.Add(this.subtractResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subtractRightLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.subtractLeftLabel);
            this.Controls.Add(this.addResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addRightLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.addResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtractResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.multiplicationResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addLeftLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label addRightLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown addResult;
        private System.Windows.Forms.NumericUpDown subtractResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label subtractRightLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label subtractLeftLabel;
        private System.Windows.Forms.NumericUpDown multiplicationResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label multiplicationRightLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label multiplicationLeftLabel;
        private System.Windows.Forms.NumericUpDown divisionResult;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label divisionRightLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label divisionLeftLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}