using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images
{
    public partial class FileSelector : UserControl,IFileSelector
    {
        public FileSelector()
        {
            InitializeComponent();
        }
        public string Path
        {
            get
            {
                return pathTextBox.Text;
            }
            set
            {
                pathTextBox.Text = value;
            }
        }
        public string[] Drives
        {
            get
            {
                String[] temp = new string[drivesComboBox.Items.Count];
                for (int i = 0; i < drivesComboBox.Items.Count; i++)
                {
                    temp[i] = (String)drivesComboBox.Items[i];
                }
                return temp;
            }
            set
            {
                drivesComboBox.Items.Clear();
                foreach (var Drive in value)
                {
                    drivesComboBox.Items.Add(Drive);
                }
            }
        }

        public string[] Content
        {
            get
            {
                String[] temp = new string[contentListBox.Items.Count];
                for (int i = 0; i < contentListBox.Items.Count; i++)
                {
                    temp[i] = (String)contentListBox.Items[i];
                }
                return temp;
            }
            set
            {
                contentListBox.Items.Clear();
                foreach (var item in value)
                {
                    contentListBox.Items.Add(item);
                }
            }
        }

        public string CurrentItem
        {
            get
            {
                return contentListBox.SelectedIndex == -1 ? "" : (String)contentListBox.SelectedItem;
            }
        }


        public string CurrentDrive { get; set; }

        public event Action SelectDrive;
        public event Action LoadDrive;
        public event Action SelectDirectory;
        public event EventHandler ChangeActive;

        private void DrivesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drivesComboBox.SelectedIndex > -1)
            {
                CurrentDrive = (String)drivesComboBox.Items[drivesComboBox.SelectedIndex];
                ChangeActive?.Invoke(this, e); // THIS!
                SelectDrive?.Invoke();

            }
        }

        private void ContentLB_DoubleClick(object sender, EventArgs e)
        {

            SelectDirectory?.Invoke();
        }

        private void DrivesCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DrivesCB_Click_1(object sender, EventArgs e)
        {
            LoadDrive?.Invoke();
        }

        private void ContentLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeActive?.Invoke(this, e);
        }

        private void TCPanel_Load(object sender, EventArgs e)
        {

        }

        private void drivesComboBox_DropDown(object sender, EventArgs e)
        {
            LoadDrive?.Invoke();
        }
    }

}
