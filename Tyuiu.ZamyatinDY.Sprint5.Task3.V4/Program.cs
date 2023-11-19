using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZamyatinDY.Sprint5.Task3.V4.Lib;
namespace Tyuiu.ZamyatinDY.Sprint5.Task3.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Замятин Д. Ю. | ИИПб 23-3";
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                     *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                           *");
            Console.WriteLine("* Задание #3                                                                    *");
            Console.WriteLine("* Вариант #4                                                                    *");
            Console.WriteLine("* Выполнил: Замятин Дмитрий Юрьевич | ИИПб 23-3                                 *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                      *");
            Console.WriteLine("* Дано выражение вычислить его значение при x=3, результат сохранить в бинарный *");
            Console.WriteLine("* файл OutPutFileTask3.bin и вывести на консоль. Округлить до 3 знаков после ,. *");
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                              *");
            Console.WriteLine("*********************************************************************************");

            int x = 3;
            Console.WriteLine("x = " + x);

            Console.WriteLine("*********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                    *");
            Console.WriteLine("*********************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
