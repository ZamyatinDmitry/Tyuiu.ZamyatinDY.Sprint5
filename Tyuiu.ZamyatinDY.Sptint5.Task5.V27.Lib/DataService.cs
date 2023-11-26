﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ZamyatinDY.Sptint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("Файл не найден", path);
            }

            string[] lines = File.ReadAllLines(path);
            int[] numbers = lines
                .Where(line => int.TryParse(line, out int number))
                .Select(int.Parse)
                .Where(n => n % 5 == 0)
                .ToArray();
            if (numbers.Length == 0)
            {
                throw new InvalidOperationException("В файле нет чисел, которые делятся на 5");
            }

            return numbers.Average();
        }
    }
}
