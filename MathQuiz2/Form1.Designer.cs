namespace MathQuiz2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.quizTimer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plusRight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.minusRight = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minusLeft = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.timesRight = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timesLeft = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.dividedRight = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dividedLeft = new System.Windows.Forms.Label();
            this.todayDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // quizTimer
            // 
            this.quizTimer.Interval = 1000;
            this.quizTimer.Tick += new System.EventHandler(this.quizTimer_Tick);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(669, 490);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(199, 64);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.SystemColors.Window;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(609, 22);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(260, 48);
            this.timeLabel.TabIndex = 20;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 48);
            this.label1.TabIndex = 21;
            this.label1.Text = "Time Left";
            // 
            // plusLeft
            // 
            this.plusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeft.Location = new System.Drawing.Point(61, 115);
            this.plusLeft.Name = "plusLeft";
            this.plusLeft.Size = new System.Drawing.Size(133, 50);
            this.plusLeft.TabIndex = 22;
            this.plusLeft.Text = "?";
            this.plusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(543, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 23;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRight
            // 
            this.plusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRight.Location = new System.Drawing.Point(364, 115);
            this.plusRight.Name = "plusRight";
            this.plusRight.Size = new System.Drawing.Size(143, 50);
            this.plusRight.TabIndex = 24;
            this.plusRight.Text = "?";
            this.plusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 25;
            this.label4.Text = "+";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(669, 103);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(200, 62);
            this.sum.TabIndex = 1;
            this.sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.Location = new System.Drawing.Point(669, 199);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(200, 62);
            this.difference.TabIndex = 2;
            this.difference.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.difference.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 30;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRight
            // 
            this.minusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRight.Location = new System.Drawing.Point(364, 211);
            this.minusRight.Name = "minusRight";
            this.minusRight.Size = new System.Drawing.Size(143, 50);
            this.minusRight.TabIndex = 29;
            this.minusRight.Text = "?";
            this.minusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(543, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 28;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeft
            // 
            this.minusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeft.Location = new System.Drawing.Point(61, 211);
            this.minusLeft.Name = "minusLeft";
            this.minusLeft.Size = new System.Drawing.Size(133, 50);
            this.minusLeft.TabIndex = 27;
            this.minusLeft.Text = "?";
            this.minusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(669, 295);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(200, 62);
            this.product.TabIndex = 3;
            this.product.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(259, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 35;
            this.label9.Text = "×";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRight
            // 
            this.timesRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRight.Location = new System.Drawing.Point(364, 307);
            this.timesRight.Name = "timesRight";
            this.timesRight.Size = new System.Drawing.Size(143, 50);
            this.timesRight.TabIndex = 34;
            this.timesRight.Text = "?";
            this.timesRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(543, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 33;
            this.label11.Text = "=";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeft
            // 
            this.timesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeft.Location = new System.Drawing.Point(61, 307);
            this.timesLeft.Name = "timesLeft";
            this.timesLeft.Size = new System.Drawing.Size(133, 50);
            this.timesLeft.TabIndex = 32;
            this.timesLeft.Text = "?";
            this.timesLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(669, 387);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(200, 62);
            this.quotient.TabIndex = 4;
            this.quotient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quotient.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(259, 399);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 50);
            this.label13.TabIndex = 40;
            this.label13.Text = "÷";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRight
            // 
            this.dividedRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedRight.Location = new System.Drawing.Point(364, 399);
            this.dividedRight.Name = "dividedRight";
            this.dividedRight.Size = new System.Drawing.Size(143, 50);
            this.dividedRight.TabIndex = 39;
            this.dividedRight.Text = "?";
            this.dividedRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(543, 399);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 50);
            this.label15.TabIndex = 38;
            this.label15.Text = "=";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeft
            // 
            this.dividedLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedLeft.Location = new System.Drawing.Point(61, 399);
            this.dividedLeft.Name = "dividedLeft";
            this.dividedLeft.Size = new System.Drawing.Size(133, 50);
            this.dividedLeft.TabIndex = 37;
            this.dividedLeft.Text = "?";
            this.dividedLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // todayDate
            // 
            this.todayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.todayDate.Location = new System.Drawing.Point(669, 774);
            this.todayDate.Name = "todayDate";
            this.todayDate.Padding = new System.Windows.Forms.Padding(2);
            this.todayDate.Size = new System.Drawing.Size(215, 55);
            this.todayDate.TabIndex = 41;
            this.todayDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(895, 852);
            this.Controls.Add(this.todayDate);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dividedRight);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dividedLeft);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.timesRight);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.timesLeft);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minusRight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minusLeft);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plusRight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plusLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marc Williamson\'s Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer quizTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label plusRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minusRight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label minusLeft;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label timesRight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label timesLeft;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label dividedRight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label dividedLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label todayDate;
    }
}

