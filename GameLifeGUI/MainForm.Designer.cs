﻿namespace GameLifeGUI
{
    partial class MainForm
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
            this.picGame = new System.Windows.Forms.PictureBox();
            this.btnNextGen = new System.Windows.Forms.Button();
            this.groupGameRun = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.backworkerRun = new System.ComponentModel.BackgroundWorker();
            this.groupFigure = new System.Windows.Forms.GroupBox();
            this.btnAddFigure = new System.Windows.Forms.Button();
            this.groupField = new System.Windows.Forms.GroupBox();
            this.btnFieldClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).BeginInit();
            this.groupGameRun.SuspendLayout();
            this.groupFigure.SuspendLayout();
            this.groupField.SuspendLayout();
            this.SuspendLayout();
            // 
            // picGame
            // 
            this.picGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGame.Location = new System.Drawing.Point(12, 99);
            this.picGame.Name = "picGame";
            this.picGame.Size = new System.Drawing.Size(460, 299);
            this.picGame.TabIndex = 0;
            this.picGame.TabStop = false;
            // 
            // btnNextGen
            // 
            this.btnNextGen.Location = new System.Drawing.Point(6, 19);
            this.btnNextGen.Name = "btnNextGen";
            this.btnNextGen.Size = new System.Drawing.Size(77, 23);
            this.btnNextGen.TabIndex = 1;
            this.btnNextGen.Text = "Next";
            this.btnNextGen.UseVisualStyleBackColor = true;
            this.btnNextGen.Click += new System.EventHandler(this.btnNextGen_Click);
            // 
            // groupGameRun
            // 
            this.groupGameRun.Controls.Add(this.btnStop);
            this.groupGameRun.Controls.Add(this.btnRun);
            this.groupGameRun.Controls.Add(this.btnNextGen);
            this.groupGameRun.Location = new System.Drawing.Point(12, 12);
            this.groupGameRun.Name = "groupGameRun";
            this.groupGameRun.Size = new System.Drawing.Size(173, 81);
            this.groupGameRun.TabIndex = 2;
            this.groupGameRun.TabStop = false;
            this.groupGameRun.Text = "Game";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(89, 49);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(77, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(6, 49);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(77, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // backworkerRun
            // 
            this.backworkerRun.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backworkerRun_DoWork);
            // 
            // groupFigure
            // 
            this.groupFigure.Controls.Add(this.btnAddFigure);
            this.groupFigure.Location = new System.Drawing.Point(284, 12);
            this.groupFigure.Name = "groupFigure";
            this.groupFigure.Size = new System.Drawing.Size(88, 81);
            this.groupFigure.TabIndex = 3;
            this.groupFigure.TabStop = false;
            this.groupFigure.Text = "Figures";
            // 
            // btnAddFigure
            // 
            this.btnAddFigure.Location = new System.Drawing.Point(6, 19);
            this.btnAddFigure.Name = "btnAddFigure";
            this.btnAddFigure.Size = new System.Drawing.Size(77, 23);
            this.btnAddFigure.TabIndex = 4;
            this.btnAddFigure.Text = "Add";
            this.btnAddFigure.UseVisualStyleBackColor = true;
            this.btnAddFigure.Click += new System.EventHandler(this.btnAddFigure_Click);
            // 
            // groupField
            // 
            this.groupField.Controls.Add(this.btnFieldClear);
            this.groupField.Location = new System.Drawing.Point(191, 12);
            this.groupField.Name = "groupField";
            this.groupField.Size = new System.Drawing.Size(87, 81);
            this.groupField.TabIndex = 4;
            this.groupField.TabStop = false;
            this.groupField.Text = "Field";
            // 
            // btnFieldClear
            // 
            this.btnFieldClear.Location = new System.Drawing.Point(6, 19);
            this.btnFieldClear.Name = "btnFieldClear";
            this.btnFieldClear.Size = new System.Drawing.Size(76, 23);
            this.btnFieldClear.TabIndex = 5;
            this.btnFieldClear.Text = "Clear";
            this.btnFieldClear.UseVisualStyleBackColor = true;
            this.btnFieldClear.Click += new System.EventHandler(this.btnFieldClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 410);
            this.Controls.Add(this.groupField);
            this.Controls.Add(this.groupFigure);
            this.Controls.Add(this.groupGameRun);
            this.Controls.Add(this.picGame);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).EndInit();
            this.groupGameRun.ResumeLayout(false);
            this.groupFigure.ResumeLayout(false);
            this.groupField.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picGame;
        private System.Windows.Forms.Button btnNextGen;
        private System.Windows.Forms.GroupBox groupGameRun;
        private System.Windows.Forms.Button btnRun;
        private System.ComponentModel.BackgroundWorker backworkerRun;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupFigure;
        private System.Windows.Forms.Button btnAddFigure;
        private System.Windows.Forms.GroupBox groupField;
        private System.Windows.Forms.Button btnFieldClear;
    }
}