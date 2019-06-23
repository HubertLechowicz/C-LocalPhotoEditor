namespace Images
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
            this.checkBoxFiliter4 = new System.Windows.Forms.CheckBox();
            this.checkBoxFilter3 = new System.Windows.Forms.CheckBox();
            this.checkBoxFilter2 = new System.Windows.Forms.CheckBox();
            this.checkBoxFilter1 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.buttonSelectImage = new System.Windows.Forms.Button();
            this.textBoxImagePath = new System.Windows.Forms.TextBox();
            this.panel1 = new Images.FileSelector();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxFiliter4
            // 
            this.checkBoxFiliter4.AutoSize = true;
            this.checkBoxFiliter4.Location = new System.Drawing.Point(1077, 193);
            this.checkBoxFiliter4.Name = "checkBoxFiliter4";
            this.checkBoxFiliter4.Size = new System.Drawing.Size(53, 17);
            this.checkBoxFiliter4.TabIndex = 19;
            this.checkBoxFiliter4.Text = "Sepia";
            this.checkBoxFiliter4.UseVisualStyleBackColor = true;
            this.checkBoxFiliter4.CheckedChanged += new System.EventHandler(this.checkBoxFiliter4_CheckedChanged);
            // 
            // checkBoxFilter3
            // 
            this.checkBoxFilter3.AutoSize = true;
            this.checkBoxFilter3.Location = new System.Drawing.Point(1077, 170);
            this.checkBoxFilter3.Name = "checkBoxFilter3";
            this.checkBoxFilter3.Size = new System.Drawing.Size(101, 17);
            this.checkBoxFilter3.TabIndex = 18;
            this.checkBoxFilter3.Text = "Odcień szarości";
            this.checkBoxFilter3.UseVisualStyleBackColor = true;
            this.checkBoxFilter3.CheckedChanged += new System.EventHandler(this.checkBoxFilter3_CheckedChanged);
            // 
            // checkBoxFilter2
            // 
            this.checkBoxFilter2.AutoSize = true;
            this.checkBoxFilter2.Location = new System.Drawing.Point(1077, 149);
            this.checkBoxFilter2.Name = "checkBoxFilter2";
            this.checkBoxFilter2.Size = new System.Drawing.Size(83, 17);
            this.checkBoxFilter2.TabIndex = 17;
            this.checkBoxFilter2.Text = "Odwrócenie";
            this.checkBoxFilter2.UseVisualStyleBackColor = true;
            this.checkBoxFilter2.CheckedChanged += new System.EventHandler(this.checkBoxFilter2_CheckedChanged);
            // 
            // checkBoxFilter1
            // 
            this.checkBoxFilter1.AutoSize = true;
            this.checkBoxFilter1.Location = new System.Drawing.Point(1077, 126);
            this.checkBoxFilter1.Name = "checkBoxFilter1";
            this.checkBoxFilter1.Size = new System.Drawing.Size(68, 17);
            this.checkBoxFilter1.TabIndex = 16;
            this.checkBoxFilter1.Text = "Negatyw";
            this.checkBoxFilter1.UseVisualStyleBackColor = true;
            this.checkBoxFilter1.CheckedChanged += new System.EventHandler(this.checkBoxFilter1_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(373, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 389F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(661, 389);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(333, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(325, 383);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 383);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Location = new System.Drawing.Point(944, 445);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveImage.TabIndex = 14;
            this.buttonSaveImage.Text = "SaveImage";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // buttonSelectImage
            // 
            this.buttonSelectImage.Location = new System.Drawing.Point(596, 443);
            this.buttonSelectImage.Name = "buttonSelectImage";
            this.buttonSelectImage.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectImage.TabIndex = 13;
            this.buttonSelectImage.Text = "SelectImage";
            this.buttonSelectImage.UseVisualStyleBackColor = true;
            this.buttonSelectImage.Click += new System.EventHandler(this.buttonSelectImage_Click);
            // 
            // textBoxImagePath
            // 
            this.textBoxImagePath.Location = new System.Drawing.Point(419, 445);
            this.textBoxImagePath.Name = "textBoxImagePath";
            this.textBoxImagePath.Size = new System.Drawing.Size(171, 20);
            this.textBoxImagePath.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Content = new string[0];
            this.panel1.CurrentDrive = null;
            this.panel1.Drives = new string[0];
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Path = "";
            this.panel1.Size = new System.Drawing.Size(365, 481);
            this.panel1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 498);
            this.Controls.Add(this.textBoxImagePath);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxFiliter4);
            this.Controls.Add(this.checkBoxFilter3);
            this.Controls.Add(this.checkBoxFilter2);
            this.Controls.Add(this.checkBoxFilter1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.buttonSelectImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxFiliter4;
        private System.Windows.Forms.CheckBox checkBoxFilter3;
        private System.Windows.Forms.CheckBox checkBoxFilter2;
        private System.Windows.Forms.CheckBox checkBoxFilter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.Button buttonSelectImage;
        private FileSelector panel1;
        private System.Windows.Forms.TextBox textBoxImagePath;
    }
}

