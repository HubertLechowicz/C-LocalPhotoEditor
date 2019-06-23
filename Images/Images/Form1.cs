using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
            ActivePanel = null;
          
            this.PanelLeft = this.panel1;
            ;
            PanelLeft.ChangeActive += ChangeActive;
           
        }
        public event Action Image;
   
        public event Action Open;       //otwieranie pliku
        public event Action Save;              //event do zapisu

        public event Action Filter1;
        public event Action Filter2;
        public event Action Filter3;
        public event Action Filter4;

        public IFileSelector PanelLeft { get; set; }
        public IFileSelector PanelRight { get; set; }
        public IFileSelector ActivePanel { get; set; }
        public string ImagePath
        {
            set
            {
                textBoxImagePath.Text = value;
            }
            get
            {
                return textBoxImagePath.Text;
            }
        }
        public PictureBox PictureBox
        {
            get
            {
                return pictureBox1;
            }
            set
            {
                pictureBox1 = value;
            }
        }
        public PictureBox PictureBoxFilter
        {
            get
            {
                return pictureBox2;
            }
            set
            {
                pictureBox2 = value;
            }
        }
        public string Response
        {
            set
            {
                MessageBox.Show(this, value, "Komunikat");
            }
        }



        

        public void ChangeActive(object sender, EventArgs e)
        {
            
            ActivePanel = (IFileSelector)sender;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            Open?.Invoke();
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            Save?.Invoke();
        }
        #region Nakladanie filtrow
        private void checkBoxFilter1_CheckedChanged(object sender, EventArgs e)
        {
            Filter1?.Invoke();
        }

        private void checkBoxFilter2_CheckedChanged(object sender, EventArgs e)
        {
            Filter2?.Invoke();
        }

        private void checkBoxFilter3_CheckedChanged(object sender, EventArgs e)
        {
            Filter3?.Invoke();
        }

        private void checkBoxFiliter4_CheckedChanged(object sender, EventArgs e)
        {
            Filter4?.Invoke();
        }
        #endregion
    }
}
