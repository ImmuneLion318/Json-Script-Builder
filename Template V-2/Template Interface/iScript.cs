using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class iScript
    {
        public List<iItem> Scripts;

        public class iItem
        {
            public string Title;
            public string Description;
            public string Script;
            public string Thumbnail;
        }
    }
}
