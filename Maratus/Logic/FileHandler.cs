using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
                URI_array[counter] = sr.ReadLine();
                counter += 1;
            }
            sr.Close();
            Thread.Sleep(10000);
        }

        public static string GetFileNameUsingDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true; //разрешаем сохранять InitialDirectory директорию при новых открытиях OpenFileDialog
            openFileDialog.Title = "Выберите текстовый файл со ссылками (ссылки должны располагаться в строках, одна строка - одна ссылка)";
            openFileDialog.InitialDirectory = "c:\\"; //директория при первом открытии OpenFileDialog
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "Text files |*.txt"; //
            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;
            openFileDialog.ShowDialog();
            string fileName = null;
            if (openFileDialog.ShowDialog() == true)
            {
                return fileName = openFileDialog.FileName;
            }
            else if (openFileDialog.ShowDialog() == false)
            {
                return null;
            }
            return fileName;
        }
    }
}
