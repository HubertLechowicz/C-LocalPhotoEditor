using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images
{
    class FileSelectorPresenter
    {
        IFileSelector Panel;
        Model Model;
        public FileSelectorPresenter(IFileSelector Panel, Model Model)
        {
            this.Panel = Panel;
            this.Model = Model;

            this.Panel.LoadDrive += ListDrives;
            this.Panel.SelectDrive += SelectDrive;
            this.Panel.SelectDrive += GetContent;
            this.Panel.SelectDirectory += UpdatePath;
        }

        public void ListDrives()
        {
            Panel.Drives = Model.ListDrives();
        }

        public void SelectDrive()
        {
            Panel.Path = Panel.CurrentDrive;
        }

        public void GetContent()
        {
            Panel.Content = Model.ListContent(Panel.Path);
        }

        public void UpdatePath()
        {
            if (Panel.CurrentItem.Contains("<D>") || Panel.CurrentItem.Equals("..."))
            {
                Panel.Path = Model.CreateNewPath(Panel.Path, Panel.CurrentItem);
                 GetContent();

            }

        }
    
    }
}
