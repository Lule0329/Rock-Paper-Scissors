﻿namespace Rock_Paper_Scissors
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 85);
            button1.Name = "button1";
            button1.Size = new Size(119, 61);
            button1.TabIndex = 0;
            button1.Text = "Rock";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(137, 85);
            button2.Name = "button2";
            button2.Size = new Size(119, 61);
            button2.TabIndex = 1;
            button2.Text = "Paper";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(262, 85);
            button3.Name = "button3";
            button3.Size = new Size(119, 61);
            button3.TabIndex = 2;
            button3.Text = "Scissors";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 173);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 3;
            label1.Text = "Wins:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 198);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 4;
            label2.Text = "Losses:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 223);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 5;
            label3.Text = "Ties:";
            // 
            // button4
            // 
            button4.Location = new Point(262, 180);
            button4.Name = "button4";
            button4.Size = new Size(119, 61);
            button4.TabIndex = 6;
            button4.Text = "Start";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.Location = new Point(137, 30);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 7;
            label4.Text = "n/a";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 264);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button4;
        private Label label4;
    }
}
