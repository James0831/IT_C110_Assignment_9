using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment9_Notepad
{
    public class WriteFile
    {
        private StreamWriter writer;
        string filepathe = null;

        public WriteFile(string path)
        {
            try
            {
                filepathe = path;
                writer = new StreamWriter(path, true);//true allows you to add more files, false will overwrite the file
            }
           
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public void AddText(string line)
        {
            writer.Write(line);
        }

        public void CloseFile()
        { 
        writer.Close();
        }
    }
}
