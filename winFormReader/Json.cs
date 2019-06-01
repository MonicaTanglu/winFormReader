using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace winFormReader
{

    class Json
    {
        private string txtIndexs = Properties.Settings.Default.txtIndexs;
        public Array result { get; set; }
        
        private void getJsonArr() {
            Properties.Settings.Default.txtIndexs = "ffdfd";
        }
    }
}
