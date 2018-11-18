namespace RedBallTracker
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
            this.tlpOuter = new System.Windows.Forms.TableLayoutPanel();
            this.tlpInner = new System.Windows.Forms.TableLayoutPanel();
            this.btnPauseOrResume = new System.Windows.Forms.Button();
            this.txtXYRadius = new System.Windows.Forms.TextBox();
            this.ibThresh = new Emgu.CV.UI.ImageBox();
            this.ibHSV = new Emgu.CV.UI.ImageBox();
            this.ibThreshlow = new Emgu.CV.UI.ImageBox();
            this.ibThreshhigh = new Emgu.CV.UI.ImageBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.triangleRectangleImageBox = new Emgu.CV.UI.ImageBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ibGussian = new Emgu.CV.UI.ImageBox();
            this.AfterDilation = new System.Windows.Forms.Label();
            this.ibAfterDilation = new Emgu.CV.UI.ImageBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ibAfterDandErosion = new Emgu.CV.UI.ImageBox();
            this.textBox_imageSize = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ibOriginal = new Emgu.CV.UI.ImageBox();
            this.tlpOuter.SuspendLayout();
            this.tlpInner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibThresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibHSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibThreshlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibThreshhigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleRectangleImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibGussian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibAfterDilation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibAfterDandErosion)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpOuter
            // 
            this.tlpOuter.ColumnCount = 2;
            this.tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.83569F));
            this.tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.16431F));
            this.tlpOuter.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpOuter.Controls.Add(this.tlpInner, 0, 1);
            this.tlpOuter.Controls.Add(this.ibThresh, 1, 0);
            this.tlpOuter.Location = new System.Drawing.Point(0, 0);
            this.tlpOuter.Name = "tlpOuter";
            this.tlpOuter.RowCount = 2;
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.36536F));
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.63464F));
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOuter.Size = new System.Drawing.Size(1412, 947);
            this.tlpOuter.TabIndex = 0;
            // 
            // tlpInner
            // 
            this.tlpInner.ColumnCount = 3;
            this.tlpOuter.SetColumnSpan(this.tlpInner, 2);
            this.tlpInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpInner.Controls.Add(this.btnPauseOrResume, 0, 0);
            this.tlpInner.Controls.Add(this.textBox_imageSize, 2, 0);
            this.tlpInner.Controls.Add(this.txtXYRadius, 1, 0);
            this.tlpInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInner.Location = new System.Drawing.Point(3, 782);
            this.tlpInner.Name = "tlpInner";
            this.tlpInner.RowCount = 2;
            this.tlpInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInner.Size = new System.Drawing.Size(1406, 162);
            this.tlpInner.TabIndex = 0;
            // 
            // btnPauseOrResume
            // 
            this.btnPauseOrResume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPauseOrResume.AutoSize = true;
            this.btnPauseOrResume.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPauseOrResume.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPauseOrResume.Location = new System.Drawing.Point(3, 47);
            this.btnPauseOrResume.Name = "btnPauseOrResume";
            this.btnPauseOrResume.Size = new System.Drawing.Size(275, 47);
            this.btnPauseOrResume.TabIndex = 3;
            this.btnPauseOrResume.Text = "Pause";
            this.btnPauseOrResume.UseVisualStyleBackColor = true;
            this.btnPauseOrResume.Click += new System.EventHandler(this.btnPauseOrResume_Click);
            // 
            // txtXYRadius
            // 
            this.txtXYRadius.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtXYRadius.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXYRadius.Location = new System.Drawing.Point(284, 3);
            this.txtXYRadius.Multiline = true;
            this.txtXYRadius.Name = "txtXYRadius";
            this.txtXYRadius.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtXYRadius.Size = new System.Drawing.Size(556, 136);
            this.txtXYRadius.TabIndex = 4;
            this.txtXYRadius.WordWrap = false;
            // 
            // ibThresh
            // 
            this.ibThresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibThresh.Enabled = false;
            this.ibThresh.Location = new System.Drawing.Point(508, 3);
            this.ibThresh.Name = "ibThresh";
            this.ibThresh.Size = new System.Drawing.Size(901, 758);
            this.ibThresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibThresh.TabIndex = 2;
            this.ibThresh.TabStop = false;
            // 
            // ibHSV
            // 
            this.ibHSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibHSV.Enabled = false;
            this.ibHSV.Location = new System.Drawing.Point(3, 389);
            this.ibHSV.Name = "ibHSV";
            this.ibHSV.Size = new System.Drawing.Size(493, 369);
            this.ibHSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibHSV.TabIndex = 3;
            this.ibHSV.TabStop = false;
            // 
            // ibThreshlow
            // 
            this.ibThreshlow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibThreshlow.Enabled = false;
            this.ibThreshlow.Location = new System.Drawing.Point(1458, 1025);
            this.ibThreshlow.Name = "ibThreshlow";
            this.ibThreshlow.Size = new System.Drawing.Size(540, 313);
            this.ibThreshlow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibThreshlow.TabIndex = 4;
            this.ibThreshlow.TabStop = false;
            // 
            // ibThreshhigh
            // 
            this.ibThreshhigh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibThreshhigh.Enabled = false;
            this.ibThreshhigh.Location = new System.Drawing.Point(2004, 1025);
            this.ibThreshhigh.Name = "ibThreshhigh";
            this.ibThreshhigh.Size = new System.Drawing.Size(540, 313);
            this.ibThreshhigh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibThreshhigh.TabIndex = 5;
            this.ibThreshhigh.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1678, 965);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 43);
            this.label2.TabIndex = 7;
            this.label2.Text = "TLOW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2214, 965);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 43);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thigh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1753, 843);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(459, 43);
            this.label4.TabIndex = 10;
            this.label4.Text = "triangleRectangleImage";
            // 
            // triangleRectangleImageBox
            // 
            this.triangleRectangleImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.triangleRectangleImageBox.Enabled = false;
            this.triangleRectangleImageBox.Location = new System.Drawing.Point(1429, 6);
            this.triangleRectangleImageBox.Name = "triangleRectangleImageBox";
            this.triangleRectangleImageBox.Size = new System.Drawing.Size(901, 758);
            this.triangleRectangleImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.triangleRectangleImageBox.TabIndex = 9;
            this.triangleRectangleImageBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1189, 969);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 43);
            this.label5.TabIndex = 12;
            this.label5.Text = "ibGussian";
            // 
            // ibGussian
            // 
            this.ibGussian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibGussian.Enabled = false;
            this.ibGussian.Location = new System.Drawing.Point(1126, 1025);
            this.ibGussian.Name = "ibGussian";
            this.ibGussian.Size = new System.Drawing.Size(323, 313);
            this.ibGussian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibGussian.TabIndex = 11;
            this.ibGussian.TabStop = false;
            // 
            // AfterDilation
            // 
            this.AfterDilation.AutoSize = true;
            this.AfterDilation.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfterDilation.Location = new System.Drawing.Point(101, 969);
            this.AfterDilation.Name = "AfterDilation";
            this.AfterDilation.Size = new System.Drawing.Size(279, 43);
            this.AfterDilation.TabIndex = 16;
            this.AfterDilation.Text = "AfterDilation";
            // 
            // ibAfterDilation
            // 
            this.ibAfterDilation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibAfterDilation.Enabled = false;
            this.ibAfterDilation.Location = new System.Drawing.Point(21, 1025);
            this.ibAfterDilation.Name = "ibAfterDilation";
            this.ibAfterDilation.Size = new System.Drawing.Size(540, 313);
            this.ibAfterDilation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibAfterDilation.TabIndex = 15;
            this.ibAfterDilation.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(660, 969);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 43);
            this.label8.TabIndex = 18;
            this.label8.Text = "AfterErosion";
            // 
            // ibAfterDandErosion
            // 
            this.ibAfterDandErosion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibAfterDandErosion.Enabled = false;
            this.ibAfterDandErosion.Location = new System.Drawing.Point(580, 1025);
            this.ibAfterDandErosion.Name = "ibAfterDandErosion";
            this.ibAfterDandErosion.Size = new System.Drawing.Size(540, 313);
            this.ibAfterDandErosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibAfterDandErosion.TabIndex = 17;
            this.ibAfterDandErosion.TabStop = false;
            // 
            // textBox_imageSize
            // 
            this.textBox_imageSize.Location = new System.Drawing.Point(846, 3);
            this.textBox_imageSize.Multiline = true;
            this.textBox_imageSize.Name = "textBox_imageSize";
            this.textBox_imageSize.Size = new System.Drawing.Size(247, 120);
            this.textBox_imageSize.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ibOriginal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ibHSV, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(499, 773);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // ibOriginal
            // 
            this.ibOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibOriginal.Enabled = false;
            this.ibOriginal.Location = new System.Drawing.Point(3, 3);
            this.ibOriginal.Name = "ibOriginal";
            this.ibOriginal.Size = new System.Drawing.Size(493, 380);
            this.ibOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibOriginal.TabIndex = 3;
            this.ibOriginal.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2544, 1370);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ibAfterDandErosion);
            this.Controls.Add(this.AfterDilation);
            this.Controls.Add(this.ibAfterDilation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ibGussian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.triangleRectangleImageBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ibThreshhigh);
            this.Controls.Add(this.ibThreshlow);
            this.Controls.Add(this.tlpOuter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpOuter.ResumeLayout(false);
            this.tlpInner.ResumeLayout(false);
            this.tlpInner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibThresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibHSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibThreshlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibThreshhigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triangleRectangleImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibGussian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibAfterDilation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibAfterDandErosion)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpOuter;
        private System.Windows.Forms.TableLayoutPanel tlpInner;
        private System.Windows.Forms.Button btnPauseOrResume;
        private System.Windows.Forms.TextBox txtXYRadius;
        private Emgu.CV.UI.ImageBox ibThresh;
        private Emgu.CV.UI.ImageBox ibHSV;
        private Emgu.CV.UI.ImageBox ibThreshlow;
        private Emgu.CV.UI.ImageBox ibThreshhigh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Emgu.CV.UI.ImageBox triangleRectangleImageBox;
        private System.Windows.Forms.Label label5;
        private Emgu.CV.UI.ImageBox ibGussian;
        private System.Windows.Forms.Label AfterDilation;
        private Emgu.CV.UI.ImageBox ibAfterDilation;
        private System.Windows.Forms.Label label8;
        private Emgu.CV.UI.ImageBox ibAfterDandErosion;
        private System.Windows.Forms.TextBox textBox_imageSize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Emgu.CV.UI.ImageBox ibOriginal;
    }
}

