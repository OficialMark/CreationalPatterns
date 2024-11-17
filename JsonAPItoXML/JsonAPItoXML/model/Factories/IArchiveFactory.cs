using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAPItoXML.Model.Factories
{
    internal interface IArchiveFactory
    {
        public void CreateArchive<T>(List<T> list);
    }
}
