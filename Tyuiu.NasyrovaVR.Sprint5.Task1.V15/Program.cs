using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NasyrovaVR.Sprint5.Task1.V15.Lib;

namespace Tyuiu.NasyrovaVR.Sprint5.Task1.V15
{
    public class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;
            DataService ds = new DataService();


            Console.Title = "Спринт #5 | Выполнила: Насырова В. Р. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнила: Насырова Влада Ренатовна | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) произвести табулирование в диапазоне [-5; 5] с        *");
            Console.WriteLine("* шагом 1. Произвести проверку деления на 0. При делении на 0 вернуть     *");
            Console.WriteLine("*  значение 0. результат сохранить в текстовый файл OutPutFileTask0.txt и *");
            Console.WriteLine("* вывести на консоль. Округлить до двух знаков после запятой.             *");
            Console.WriteLine("*        cos(x)                                                           *");
            Console.WriteLine("* F(x)= --------  + sin(x)*8x + 2                                         *");
            Console.WriteLine("*        x - 0,4                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
