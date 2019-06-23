using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Images
{
    interface IView
    {
        IFileSelector PanelLeft { get; set; }
        IFileSelector PanelRight { get; set; }
        IFileSelector ActivePanel { get; set; }
        PictureBox PictureBox { get; set; }
        PictureBox PictureBoxFilter { get; set; }


        //string Button { set; }
        string Response { set; }
        string ImagePath { set; get; }
        
        event Action Image;// event do ścieżki pliku
        event Action Open;//event do otwarcia
        event Action Save;//event do zapisu
        #region Eventy Filtrowe
        event Action Filter1;//event do filtrow
        event Action Filter2;//event do filtrow
        event Action Filter3;//event do filtrow
        event Action Filter4;//event do filtrow
        #endregion
        void ChangeActive(object sender, EventArgs e);
    }
}
