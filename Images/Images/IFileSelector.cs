using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Images
{
    public interface IFileSelector
    {

        string Path { get; set; }
        string[] Drives { get; set; }
        string CurrentDrive { get; set; }
        string[] Content { get; set; }
        string CurrentItem { get; }


        event Action SelectDrive;
        event Action LoadDrive;
        event Action SelectDirectory;
        event EventHandler ChangeActive;
    }
}
