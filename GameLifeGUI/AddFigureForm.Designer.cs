namespace GameLifeGUI
{
    partial class AddFigureForm
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
            this.picSampleFigure = new System.Windows.Forms.PictureBox();
            this.listFigures = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupAdd = new System.Windows.Forms.GroupBox();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.txtInputY = new System.Windows.Forms.TextBox();
            this.txtInputX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSampleFigure)).BeginInit();
            this.groupAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSampleFigure
            // 
            this.picSampleFigure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSampleFigure.Location = new System.Drawing.Point(289, 12);
            this.picSampleFigure.Name = "picSampleFigure";
            this.picSampleFigure.Size = new System.Drawing.Size(283, 328);
            this.picSampleFigure.TabIndex = 0;
            this.picSampleFigure.TabStop = false;
            // 
            // listFigures
            // 
            this.listFigures.FormattingEnabled = true;
            this.listFigures.Location = new System.Drawing.Point(13, 44);
            this.listFigures.Name = "listFigures";
            this.listFigures.Size = new System.Drawing.Size(270, 212);
            this.listFigures.TabIndex = 1;
            this.listFigures.SelectedIndexChanged += new System.EventHandler(this.listFigures_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(9, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 26);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(208, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 26);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // groupAdd
            // 
            this.groupAdd.Controls.Add(this.labelY);
            this.groupAdd.Controls.Add(this.labelX);
            this.groupAdd.Controls.Add(this.btnAdd);
            this.groupAdd.Controls.Add(this.txtInputY);
            this.groupAdd.Controls.Add(this.txtInputX);
            this.groupAdd.Location = new System.Drawing.Point(13, 262);
            this.groupAdd.Name = "groupAdd";
            this.groupAdd.Size = new System.Drawing.Size(130, 78);
            this.groupAdd.TabIndex = 4;
            this.groupAdd.TabStop = false;
            this.groupAdd.Text = "Add figure";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(67, 23);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 15);
            this.labelY.TabIndex = 6;
            this.labelY.Text = "Y";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(6, 23);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(15, 15);
            this.labelX.TabIndex = 5;
            this.labelX.Text = "X";
            // 
            // txtInputY
            // 
            this.txtInputY.Location = new System.Drawing.Point(87, 20);
            this.txtInputY.Name = "txtInputY";
            this.txtInputY.Size = new System.Drawing.Size(34, 20);
            this.txtInputY.TabIndex = 1;
            this.txtInputY.TextChanged += new System.EventHandler(this.txtInputXY_TextChanged);
            // 
            // txtInputX
            // 
            this.txtInputX.Location = new System.Drawing.Point(27, 20);
            this.txtInputX.Name = "txtInputX";
            this.txtInputX.Size = new System.Drawing.Size(34, 20);
            this.txtInputX.TabIndex = 0;
            this.txtInputX.TextChanged += new System.EventHandler(this.txtInputXY_TextChanged);
            // 
            // AddFigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 350);
            this.Controls.Add(this.groupAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.listFigures);
            this.Controls.Add(this.picSampleFigure);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFigureForm";
            this.Text = "AddFigureForm";
            ((System.ComponentModel.ISupportInitialize)(this.picSampleFigure)).EndInit();
            this.groupAdd.ResumeLayout(false);
            this.groupAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSampleFigure;
        private System.Windows.Forms.ListBox listFigures;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupAdd;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox txtInputY;
        private System.Windows.Forms.TextBox txtInputX;
    }
}