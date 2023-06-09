﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.WinForms;

namespace TomogramVisualizer
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.glControl1 = new OpenTK.WinForms.GLControl();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.trackBar2 = new System.Windows.Forms.TrackBar();
      this.trackBar3 = new System.Windows.Forms.TrackBar();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
      this.menuStrip1.Size = new System.Drawing.Size(1166, 35);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // открытьToolStripMenuItem
      // 
      this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
      this.открытьToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
      this.открытьToolStripMenuItem.Text = "Открыть";
      this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
      // 
      // glControl1
      // 
      this.glControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.glControl1.API = OpenTK.Windowing.Common.ContextAPI.OpenGL;
      this.glControl1.APIVersion = new System.Version(3, 3, 0, 0);
      this.glControl1.Flags = OpenTK.Windowing.Common.ContextFlags.Default;
      this.glControl1.IsEventDriven = true;
      this.glControl1.Location = new System.Drawing.Point(14, 33);
      this.glControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.glControl1.Name = "glControl1";
      this.glControl1.Profile = OpenTK.Windowing.Common.ContextProfile.Compatability;
      this.glControl1.Size = new System.Drawing.Size(780, 632);
      this.glControl1.TabIndex = 2;
      this.glControl1.Text = "glControl1";
      this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
      // 
      // trackBar1
      // 
      this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBar1.LargeChange = 1;
      this.trackBar1.Location = new System.Drawing.Point(14, 672);
      this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.trackBar1.Maximum = 0;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(1136, 69);
      this.trackBar1.TabIndex = 3;
      this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new System.Drawing.Point(839, 45);
      this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(89, 29);
      this.radioButton1.TabIndex = 4;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "Quads";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new System.Drawing.Point(936, 45);
      this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(92, 29);
      this.radioButton2.TabIndex = 5;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "Texture";
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
      // 
      // trackBar2
      // 
      this.trackBar2.Location = new System.Drawing.Point(839, 176);
      this.trackBar2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.trackBar2.Name = "trackBar2";
      this.trackBar2.Size = new System.Drawing.Size(274, 69);
      this.trackBar2.TabIndex = 6;
      this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
      // 
      // trackBar3
      // 
      this.trackBar3.Location = new System.Drawing.Point(839, 329);
      this.trackBar3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.trackBar3.Name = "trackBar3";
      this.trackBar3.Size = new System.Drawing.Size(274, 69);
      this.trackBar3.TabIndex = 7;
      this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(839, 122);
      this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(141, 31);
      this.textBox1.TabIndex = 8;
      this.textBox1.Text = "Minimum";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(839, 271);
      this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(141, 31);
      this.textBox2.TabIndex = 9;
      this.textBox2.Text = "Width TF";
      // 
      // radioButton3
      // 
      this.radioButton3.AutoSize = true;
      this.radioButton3.Location = new System.Drawing.Point(1036, 45);
      this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(117, 29);
      this.radioButton3.TabIndex = 10;
      this.radioButton3.TabStop = true;
      this.radioButton3.Text = "QuadStrip";
      this.radioButton3.UseVisualStyleBackColor = true;
      this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1166, 758);
      this.Controls.Add(this.radioButton3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.trackBar3);
      this.Controls.Add(this.trackBar2);
      this.Controls.Add(this.radioButton2);
      this.Controls.Add(this.radioButton1);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.glControl1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private GLControl glControl1;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private TrackBar trackBar1;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private TrackBar trackBar2;
    private TrackBar trackBar3;
    private TextBox textBox1;
    private TextBox textBox2;
    private RadioButton radioButton3;
  }
}