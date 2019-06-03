using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace winFormReader
{

    class Json
    {
        

        public Array result { get; set; }
        
        public void setJson(string str) {
            string fp = @"J:\winFormReader\winFormReader\info.json";
            StreamWriter sw = new StreamWriter(fp, false);
            sw.WriteLine(str);
            sw.Close();
        }
        public string getJson()
        {
            string fp = @"J:\winFormReader\winFormReader\info.json";
            StreamReader sr = new StreamReader(fp, false);
            string str = sr.ReadLine();
            sr.Close();
            return str;
        }
    }
    class Obj
    {
        public string fileName { get; set; }
        public long index { get; set; }
    }
}
