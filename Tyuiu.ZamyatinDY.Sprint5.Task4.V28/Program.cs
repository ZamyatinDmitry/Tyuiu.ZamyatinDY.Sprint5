using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZamyatinDY.Sprint5.Task4.V28.Lib;
using System.IO;
namespace Tyuiu.ZamyatinDY.Sprint5.Task4.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Замятин Д.Ю. | ИИПб-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                      *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #28                                                              *");
            Console.WriteLine("* Выполнил: Замятин Д.Ю. | ИИПб-23-3                                       *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Записать значение формулы в файл                                         *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            DataService ds = new DataService();
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask4V28.txt";
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
