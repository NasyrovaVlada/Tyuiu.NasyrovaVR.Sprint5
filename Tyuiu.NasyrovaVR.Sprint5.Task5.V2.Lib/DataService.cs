using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NasyrovaVR.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            double count = 0;
           
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    double n = Convert.ToDouble(line);
                    if (n > 0)
                    {
                        res += n;
                        count++;
                    }
                }
            }
            res = res / count;
            res = Math.Round(res, 3);
            return res;
        }
    }
}
