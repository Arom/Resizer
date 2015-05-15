namespace Resizer
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
            this.btnSelectImages = new System.Windows.Forms.Button();
            this.fileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.radioPercent = new System.Windows.Forms.RadioButton();
            this.radioPixels = new System.Windows.Forms.RadioButton();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.savePathBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.img2greyscale1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectImages
            // 
            this.btnSelectImages.Location = new System.Drawing.Point(117, 168);
            this.btnSelectImages.Name = "btnSelectImages";
            this.btnSelectImages.Size = new System.Drawing.Size(98, 23);
            this.btnSelectImages.TabIndex = 5;
            this.btnSelectImages.Text = "Select Images";
            this.btnSelectImages.UseVisualStyleBackColor = true;
            this.btnSelectImages.Click += new System.EventHandler(this.btnSelectImages_Click);
            // 
            // fileBrowser
            // 
            this.fileBrowser.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPercent);
            this.groupBox1.Controls.Add(this.txtHeight);
            this.groupBox1.Controls.Add(this.txtWidth);
            this.groupBox1.Controls.Add(this.radioPercent);
            this.groupBox1.Controls.Add(this.radioPixels);
            this.groupBox1.Location = new System.Drawing.Point(55, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "%";
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(74, 77);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(23, 20);
            this.txtPercent.TabIndex = 4;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(136, 19);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(35, 20);
            this.txtHeight.TabIndex = 3;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(65, 19);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(39, 20);
            this.txtWidth.TabIndex = 2;
            // 
            // radioPercent
            // 
            this.radioPercent.AutoSize = true;
            this.radioPercent.Location = new System.Drawing.Point(7, 77);
            this.radioPercent.Name = "radioPercent";
            this.radioPercent.Size = new System.Drawing.Size(62, 17);
            this.radioPercent.TabIndex = 1;
            this.radioPercent.Text = "Percent";
            this.radioPercent.UseVisualStyleBackColor = true;
            // 
            // radioPixels
            // 
            this.radioPixels.AutoSize = true;
            this.radioPixels.Checked = true;
            this.radioPixels.Location = new System.Drawing.Point(7, 20);
            this.radioPixels.Name = "radioPixels";
            this.radioPixels.Size = new System.Drawing.Size(52, 17);
            this.radioPixels.TabIndex = 0;
            this.radioPixels.TabStop = true;
            this.radioPixels.Text = "Pixels";
            this.radioPixels.UseVisualStyleBackColor = true;
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(26, 31);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(272, 20);
            this.txtSavePath.TabIndex = 3;
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(84, 2);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(154, 23);
            this.btnSavePath.TabIndex = 1;
            this.btnSavePath.Text = "Select Save Location";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(308, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 479);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(278, 2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(98, 23);
            this.loadButton.TabIndex = 7;
            this.loadButton.Text = "Load..";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadImageButton);
            // 
            // img2greyscale1
            // 
            this.img2greyscale1.Location = new System.Drawing.Point(382, 2);
            this.img2greyscale1.Name = "img2greyscale1";
            this.img2greyscale1.Size = new System.Drawing.Size(98, 23);
            this.img2greyscale1.TabIndex = 8;
            this.img2greyscale1.Text = "img2grey1";
            this.img2greyscale1.UseVisualStyleBackColor = true;
            this.img2greyscale1.Click += new System.EventHandler(this.img2GreyscaleButton);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 532);
            this.Controls.Add(this.img2greyscale1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSavePath);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelectImages);
            this.Name = "MainForm";
            this.Text = "Resizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectImages;
        private System.Windows.Forms.OpenFileDialog fileBrowser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.RadioButton radioPercent;
        private System.Windows.Forms.RadioButton radioPixels;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.FolderBrowserDialog savePathBrowser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button img2greyscale1;
    }
}

