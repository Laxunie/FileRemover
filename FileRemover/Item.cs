using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileRemover
{
    class Item
    {
        public string Path { get; set; }

        public Item(string path)
        {
            this.Path = path;
        }

        public void Delete()
        {
            File.Delete(this.Path);
        }
    }
}
