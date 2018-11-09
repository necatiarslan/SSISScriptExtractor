using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSISTools
{
    public class PackageListItem
    {
        public string FileName { get; set; }

        public PackageListItem(string fileName)
        {
            this.FileName = fileName;
        }

        public override string ToString()
        {
            return System.IO.Path.GetFileName(this.FileName) + "   (" + this.FileName + ")";
        }
    }
}
