﻿namespace hetedikgyak
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btn_Browse = new System.Windows.Forms.Button();
			this.btn_Start = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Záróév:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(233, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Népesség fájl:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(333, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(159, 20);
			this.textBox1.TabIndex = 2;
			// 
			// btn_Browse
			// 
			this.btn_Browse.Location = new System.Drawing.Point(499, 11);
			this.btn_Browse.Name = "btn_Browse";
			this.btn_Browse.Size = new System.Drawing.Size(96, 23);
			this.btn_Browse.TabIndex = 3;
			this.btn_Browse.Text = "Browse";
			this.btn_Browse.UseVisualStyleBackColor = true;
			this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
			// 
			// btn_Start
			// 
			this.btn_Start.Location = new System.Drawing.Point(601, 11);
			this.btn_Start.Name = "btn_Start";
			this.btn_Start.Size = new System.Drawing.Size(96, 23);
			this.btn_Start.TabIndex = 4;
			this.btn_Start.Text = "Start";
			this.btn_Start.UseVisualStyleBackColor = true;
			this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(77, 13);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 5;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(15, 84);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(682, 280);
			this.richTextBox1.TabIndex = 6;
			this.richTextBox1.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.btn_Start);
			this.Controls.Add(this.btn_Browse);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btn_Browse;
		private System.Windows.Forms.Button btn_Start;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}

