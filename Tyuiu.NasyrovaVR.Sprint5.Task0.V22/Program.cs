using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NasyrovaVR.Sprint5.Task0.V22.Lib;

namespace Tyuiu.NasyrovaVR.Sprint5.Task0.V22
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            DataService ds = new DataService();


            Console.Title = "Спринт #5 | Выполнила: Насырова В. Р. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнила: Насырова Влада Ренатовна | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в  *");
            Console.WriteLine("* текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до   *");
            Console.WriteLine("* трёх знаков после запятой.                                              *");
            Console.WriteLine("*      (1-x)^2                                                            *");
            Console.WriteLine("* y(x)=--------                                                           *");
            Console.WriteLine("*        -3x                                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("x = " + x);
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
