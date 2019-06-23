using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images
{
    class Presenter
    {
        IView View;
        Model Model;
        FileSelectorPresenter FilePresenter;

        public Presenter(IView View, Model Model)
        {
            this.View = View;
            this.Model = Model;
            FilePresenter = new FileSelectorPresenter(this.View.PanelLeft, this.Model);
        
            View.Open += Open;
            View.Save += Save;

            View.Filter1 += Filter1;
            View.Filter2 += Filter2;
            View.Filter3 += Filter3;
            View.Filter4 += Filter4;

            this.View.PanelLeft.SelectDirectory += PanelLeft_SelectDirectory;

        }

        private void PanelLeft_SelectDirectory()
        {

            if ((this.View.PanelLeft.CurrentItem.Contains(".jpg") || this.View.PanelLeft.CurrentItem.Contains(".png"))  && this.View.PanelLeft.CurrentItem.Contains("<F>"))
            {
                this.View.ImagePath = (this.View.PanelLeft.Path + "\\" + this.View.PanelLeft.CurrentItem.Remove(0, 4)).Replace(@"\\", @"\");

            }
        }

       
        public void Open()
        {
            IView From2;

            From2 = View; // czy działa?

            if (From2.ImagePath == null || ((!From2.ImagePath.Contains(".jpg")) && (!From2.ImagePath.Contains(".png"))))
            {
                View.Response = "Choose .jpg or .png file from the left first!";
                return;
            }
            try
            {

                View.PictureBox.Image = Image.FromFile(View.ImagePath);
                View.PictureBoxFilter.Image = Image.FromFile(View.ImagePath);



                View.Response = "Successfully opened the Image";

            }
            catch (UnauthorizedAccessException)
            {
                View.Response = "Access denied";
            }
            catch (Exception e)
            {
                if (e.Message.Contains("Ready"))
                    View.Response = "Invalid device";
            }
        }
        public void Save()
        {
            IView From2;

            From2 = View; // czy działa?

            if (From2.ImagePath == null || ((!From2.ImagePath.Contains(".jpg")) && (!From2.ImagePath.Contains(".png"))))
            {
                View.Response = "Choose .jpg or .png file from the left first!";
                return;
            }
            try
            {

                if (From2.ImagePath.Contains(".jpg"))
                View.PictureBoxFilter.Image.Save(View.ImagePath.Replace(".jpg", "NEW.jpg"));
                else 
                View.PictureBoxFilter.Image.Save(View.ImagePath.Replace(".png", "NEW.png"));


                View.Response = "Successfully saved the Image";

            }
            catch (UnauthorizedAccessException)
            {
                View.Response = "Access denied";
            }
            catch (Exception e)
            {
                if (e.Message.Contains("Ready"))
                    View.Response = "Invalid device";
            }
        }


        #region Filterki
        public void Filter1()           //NEGATYW
        {
            IView From3;
            From3 = View;
            if (From3.ImagePath == null || ((!From3.ImagePath.Contains(".jpg")) && (!From3.ImagePath.Contains(".png"))))
            {
                View.Response = "Error.";
            }
            else
            {
                try
                {
                    
                    Bitmap bitmap = new Bitmap(Model.Negative(View.PictureBoxFilter.Image)); 
                    View.PictureBoxFilter.Image = bitmap;
                    View.PictureBoxFilter.Refresh();
                }
                catch (BadImageFormatException)
                {
                    View.Response = "Error.";
                }
            }
        }
        public void Filter2()           //MIRROR
        {
            IView From4;
            From4 = View;
            if (From4.ImagePath == null || ((!From4.ImagePath.Contains(".jpg")) && (!From4.ImagePath.Contains(".png"))))
            {
                View.Response = "Error.";
            }
            else
            {
                try
                {
                    Bitmap bitmap = new Bitmap(Model.Mirror(View.PictureBoxFilter.Image));
                    View.PictureBoxFilter.Image = bitmap;
                    View.PictureBoxFilter.Refresh();
                }
                catch (BadImageFormatException)
                {
                    View.Response = "Error.";
                }
            }
        }
        public void Filter3()           //GREYSCALE
        {
            IView From5;
            From5 = View;
            if (From5.ImagePath == null || ((!From5.ImagePath.Contains(".jpg")) && (!From5.ImagePath.Contains(".png"))))
            {
                View.Response = "Error.";
            }
            else
            {
                try
                {
                    Bitmap bitmap = new Bitmap(Model.Greyscale(View.PictureBoxFilter.Image));
                    View.PictureBoxFilter.Image = bitmap;
                    View.PictureBoxFilter.Refresh();
                }
                catch (BadImageFormatException)
                {
                    View.Response = "Error.";
                }
            }
        }
        public void Filter4()               //SEPIA
        {
            IView From6;
            From6 = View;
            if (From6.ImagePath == null || ((!From6.ImagePath.Contains(".jpg")) && (!From6.ImagePath.Contains(".png"))))
            {
                View.Response = "Error.";
            }
            else
            {
                try
                {
                    Bitmap bitmap = new Bitmap(Model.Sepia(View.PictureBoxFilter.Image));
                    View.PictureBoxFilter.Image = bitmap;
                    View.PictureBoxFilter.Refresh();
                }
                catch (BadImageFormatException)
                {
                    View.Response = "Error.";
                }
            }
        }
        #endregion
    }
}