using Maratus.Logic;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Maratus
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string filePath = @"~\Files\URI_List.txt";


        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
                        //FileHandler fh = new FileHandler()
        }

        private void NewSearchButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            openFileDialog.RestoreDirectory = true; //
            openFileDialog.Title = "Выберите текстовый файл со ссылками";
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "Text files |*.txt";
            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;
            openFileDialog.ShowDialog();
            if (ShowDialog()==true)
            {

            }
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
