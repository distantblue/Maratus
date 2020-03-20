using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maratus.Logic
{
    public class FileHandler
    {
        public string URI { get; set; }
        public int NumberOfLines { get; set; }
        public string[] URI_array { get; set; }

        /// <summary>
        /// Конструктор обработчика файлов. Он реализует вычитывание содержимого файла.
        /// </summary>
        /// <param name="filePath">Путь к файлу</param>
        public FileHandler(string filePath)
        {
            NumberOfLines = File.ReadAllLines(filePath).Length; //вычитываем колличество строк в файле
            URI_array = new string[NumberOfLines]; //инициализация массива строк
            int counter = 0; 
            StreamReader sr = new StreamReader(filePath);
            while (sr.ReadLine() != null)
            {
                URI_array[counter]= sr.ReadLine();
                counter += 1;
            }
            sr.Close();
        }
    }
}
