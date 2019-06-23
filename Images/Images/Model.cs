using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Images
{
    class Model
    {
        public string[] ListDrives()
        {
            return Directory.GetLogicalDrives();
        }
        public string[] ListDirectories(string Path)
        {
            return Directory.GetDirectories(Path);
        }
        public string[] ListFiles(string Path)
        {
            return Directory.GetFiles(Path);
        }

        public string[] ListContent(string Path)
        {
            string[] Dirs;
            string[] Files;
            try
            {
                Dirs = ListDirectories(Path);
                Files = ListFiles(Path);
                if (Dirs.Length + Files.Length == 0)
                {
                    if (Path.Length > 3)
                        return new string[2] { "...", "Ścieżka jest pusta" }; // Path isn't like C:\ 
                    else
                        return new string[1] { "Ścieżka jest pusta" }; // Path is like C:\
                }

                string[] temp;
                int i;

                if (Path.Length > 3) // Path isn't like C:\ 
                {
                    temp = new string[Dirs.Length + Files.Length + 1];
                    temp[0] = "...";
                    i = 1;
                }
                else // Path is like C:\
                {
                    temp = new string[Dirs.Length + Files.Length];
                    i = 0;
                }
                string ToReplace = Path.Length > 3 ? Path + "\\" : Path;
                foreach (var dir in Dirs)
                {
                    temp[i] = $"<D> {dir.Replace(ToReplace, "")}";
                    i++;
                }
                foreach (var file in Files)
                {
                    temp[i] = $"<F> {file.Replace(ToReplace, "")}";
                    i++;
                }
                return temp;
            }
            catch (IOException)
            {
                Console.WriteLine(Path.Length);
                if (Path.Length > 3)
                    return new string[2] { "...", "Urządzenie jest gotowe" };
                else
                    return new string[1] { "Urządzenie nie jest gotowe" };
            }
            catch (UnauthorizedAccessException)
            {
                if (Path.Length > 3)
                    return new string[2] { "...", "Odmowa dostepu" };
                else
                    return new string[1] { "Odmowa dostępu" };
            }
        }
        public string CreateNewPath(string Path, string SelectedItem)
        {
            if (SelectedItem.Contains("<D>"))
                return Path.Length > 3 ? Path + "\\" + SelectedItem.Replace("<D> ", "") : Path + SelectedItem.Replace("<D> ", "");
            if (SelectedItem.Equals("...")) // Backwards was selected
            {
                int deleteIndex = Path.Length;
                if (Path.Contains('\\'))
                {
                    Path = Path.Remove(Path.Length - 1);
                }
                for (int i = Path.Length - 1; i >= 0; i--)
                {
                    if (Path[i] == '/' || Path[i] == '\\')
                    {
                        deleteIndex = i > 2 ? i : i + 1;
                        break;
                    }
                }
                Path = Path.Remove(deleteIndex);
            }
            return Path;
        }

       



        public void OpenImage(string Name, string Path, string Destination)
        {   
            Name = Name.Contains("<D>") ? Name.Replace("<D> ", "") : Name.Replace("<F> ", "");
            Path = Path.Length > 3 ? Path + "\\" : Path;
            Destination = Destination.Length > 3 ? Destination + "\\" : Destination;
            if (File.Exists(Destination + "\\" + Name))
                throw new IOException("Plik już istnieje");
            //File.Copy(Path + Name, Destination + Name);
            File.Copy(Path + Name, Destination + Name);
        }

        #region Filtry;    
        public Image Negative(Image zdjontko)
        {
            Bitmap bmp = new Bitmap(zdjontko);
            
            
            //dimension
            int width = bmp.Width;
            int height = bmp.Height;

            //negative
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    int a = p.A;        //alfa
                    int r = p.R;        //red
                    int g = p.G;        //green
                    int b = p.B;        //blue

                    //negative value
                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;
                   

                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            zdjontko = (Image)bmp;
          
            return zdjontko;
            
        }
        public Image Mirror (Image zdjontko)
        {
            Bitmap bmp = new Bitmap(zdjontko);
            int width = bmp.Width;
            int height = bmp.Height;

            //load source image in picturebox1
            Bitmap mimg = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int lx = 0, rx = width - 1; lx < width; lx++, rx--)
                {
                    //get source pixel value
                    Color p = bmp.GetPixel(lx, y);

                    //set mirror pixel value
                    mimg.SetPixel(rx, y, p);
                }
            }

            zdjontko = (Image)mimg;
            
            return zdjontko;
        }
        public Image Greyscale (Image zdjontko)
        {
            //read image
            Bitmap bmp = new Bitmap(zdjontko);
            int width = bmp.Width;
            int height = bmp.Height;
            //grayscale
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //get pixel value
                    Color p = bmp.GetPixel(x, y);

                    //extract pixel component ARGB
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //find average
                    int avg = (r + g + b) / 3;

                    //set new pixel value
                    bmp.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
            }

            //load grayscale image in picturebox2
            //.Image = bmp;

            zdjontko = (Image)bmp;
         
            return zdjontko;
        }
        public Image Sepia (Image zdjontko)
        {
            //read image
            Bitmap bmp = new Bitmap(zdjontko);

            int width = bmp.Width;
            int height = bmp.Height;

            //color of pixel
            Color p;

            //sepia
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //get pixel value
                    p = bmp.GetPixel(x, y);

                    //extract pixel component ARGB
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //calculate temp value
                    int tr = (int)(0.393 * r + 0.769 * g + 0.189 * b);
                    int tg = (int)(0.349 * r + 0.686 * g + 0.168 * b);
                    int tb = (int)(0.272 * r + 0.534 * g + 0.131 * b);

                    //set new RGB value
                    if (tr > 255)
                    {
                        r = 255;
                    }
                    else
                    {
                        r = tr;
                    }

                    if (tg > 255)
                    {
                        g = 255;
                    }
                    else
                    {
                        g = tg;
                    }

                    if (tb > 255)
                    {
                        b = 255;
                    }
                    else
                    {
                        b = tb;
                    }

                    //set the new RGB value in image pixel
                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            zdjontko = (Image)bmp;
          
            return zdjontko;
        }
        #endregion
    }
}
