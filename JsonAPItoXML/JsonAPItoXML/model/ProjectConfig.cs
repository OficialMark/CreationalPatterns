using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAPItoXML.Model
{
    public static class ProjectConfig
    {
        public static string DirectoryXML
            => Path.Combine((Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.Parent.FullName), "XML");
    }

}
