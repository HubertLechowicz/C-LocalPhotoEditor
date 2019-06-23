namespace Images
{
    partial class FileSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contentListBox = new System.Windows.Forms.ListBox();
            this.drivesComboBox = new System.Windows.Forms.ComboBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(52, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zawartosc pliku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(238, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Dysk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(149, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sciezka Pliku";
            // 
            // contentListBox
            // 
            this.contentListBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.contentListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contentListBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.contentListBox.FormattingEnabled = true;
            this.contentListBox.ItemHeight = 16;
            this.contentListBox.Location = new System.Drawing.Point(52, 95);
            this.contentListBox.Name = "contentListBox";
            this.contentListBox.Size = new System.Drawing.Size(297, 356);
            this.contentListBox.TabIndex = 8;
            this.contentListBox.Click += new System.EventHandler(this.ContentLB_DoubleClick);
            this.contentListBox.SelectedIndexChanged += new System.EventHandler(this.ContentLB_SelectedIndexChanged);
            this.contentListBox.DoubleClick += new System.EventHandler(this.ContentLB_DoubleClick);
            // 
            // drivesComboBox
            // 
            this.drivesComboBox.BackColor = System.Drawing.Color.LightGray;
            this.drivesComboBox.FormattingEnabled = true;
            this.drivesComboBox.Location = new System.Drawing.Point(289, 66);
            this.drivesComboBox.Name = "drivesComboBox";
            this.drivesComboBox.Size = new System.Drawing.Size(56, 21);
            this.drivesComboBox.TabIndex = 7;
            this.drivesComboBox.DropDown += new System.EventHandler(this.drivesComboBox_DropDown);
            this.drivesComboBox.SelectedIndexChanged += new System.EventHandler(this.DrivesCB_SelectedIndexChanged);
            this.drivesComboBox.Click += new System.EventHandler(this.DrivesCB_Click_1);
            this.drivesComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DrivesCB_KeyPress);
            // 
            // pathTextBox
            // 
            this.pathTextBox.BackColor = System.Drawing.Color.LightGray;
            this.pathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pathTextBox.Location = new System.Drawing.Point(52, 36);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(293, 20);
            this.pathTextBox.TabIndex = 6;
            // 
            // FileSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contentListBox);
            this.Controls.Add(this.drivesComboBox);
            this.Controls.Add(this.pathTextBox);
            this.Name = "FileSelector";
            this.Size = new System.Drawing.Size(454, 481);
            this.Load += new System.EventHandler(this.TCPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox contentListBox;
        private System.Windows.Forms.ComboBox drivesComboBox;
        private System.Windows.Forms.TextBox pathTextBox;
    }
}
