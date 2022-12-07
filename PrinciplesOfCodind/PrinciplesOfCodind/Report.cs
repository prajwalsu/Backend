using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinciplesOfCodind
{
    interface IReport
    {
        void AddEntryAt(int index);
        void RemoveEntryAt(int index);
    }

    interface IReportSaver
    {
        void SaveFile(string path, string fileName);
    }
}
