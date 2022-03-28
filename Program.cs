using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR13Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //запись исходных данных в файл Input.txt
            string path = @"Input.txt";
            double p = 33.3e2;
            StreamWriter sw = new StreamWriter(path, false);
            sw.WriteLine(p);
            sw.Close();
            Console.WriteLine("Запись произведена");
            Console.ReadKey();
            //чтение из файла Input.txt
            StreamReader sr = new StreamReader(path);
            double p_read = Convert.ToDouble(sr.ReadLine());
            //вычисление результата по формуле
            double solve = Math.Log(p_read);//формула
            //запись результата в файл Result.txt
            string path1 = @"Result.txt";
            StreamWriter sw1 = new StreamWriter(path1, false);
            sw1.WriteLine(solve);
            sw1.Close();
            Console.WriteLine("Подсчет и Запись выполнены");
            Console.ReadKey();
        }
    }
}
