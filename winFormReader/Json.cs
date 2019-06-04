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
            string fp = new DirectoryInfo("../../").FullName + "info.json";
            StreamWriter sw = new StreamWriter(fp, false);
            sw.WriteLine(str);
            sw.Close();
        }
        public string getJson()
        {
            string fp = new DirectoryInfo("../../").FullName + "info.json";
            StreamReader sr = new StreamReader(fp, false);
            string str = sr.ReadLine();
            sr.Close();
            return str;
        }
        public string readJson(string key)
        {
            try
            {
                string fp = new DirectoryInfo("../../").FullName + "info.json";
                StreamReader file = File.OpenText(fp);
                JsonTextReader reader = new JsonTextReader(file);
                JObject jsonObject = (JObject)JToken.ReadFrom(reader);
                file.Close();
                return (string)jsonObject[key];
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public void writeJson(string key,string value) {
            try
            {
                string fp = new DirectoryInfo("../../").FullName + "info.json";
                string json = File.ReadAllText(fp);
                dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                if(jsonObj[key] != null)
                {
                    jsonObj[key] = value;
                }else
                {
                    jsonObj.Add(new JProperty(key,value));
                }
                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(fp,output);
  

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
    class Obj
    {
        public string fileName { get; set; }
        public long index { get; set; }
    }
}
