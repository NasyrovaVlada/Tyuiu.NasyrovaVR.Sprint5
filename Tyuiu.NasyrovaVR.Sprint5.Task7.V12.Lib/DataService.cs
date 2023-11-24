using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Runtime.Remoting.Messaging;


namespace Tyuiu.NasyrovaVR.Sprint5.Task7.V12.Lib
{
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V12.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists) 
            {
                File.Delete(pathSaveFile);
            }
            string strLine = "";
            using(StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        strLine += line.ToUpper()[i];

                    }
                }
                File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                strLine = "";
            }


            return pathSaveFile;
        }
    }
}
