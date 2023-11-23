﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Xml;

namespace Tyuiu.NasyrovaVR.Sprint5.Task4.V18.Lib
{
    public class DataService : ISprint5Task4V18
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Cos(Convert.ToDouble(strX)) + ((Math.Pow(Convert.ToDouble(strX), 2.0)) / 2.0);
            res = Math.Round(res, 3);
            return res;
        }
    }
}
