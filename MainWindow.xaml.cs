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

namespace PracWork11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            int[] arrayInput = new int[20];
            int[] arrayRezult = new int[20];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnInput_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            
            for(int i=0; i< 20; i++)
            {
                arrayInput[i] = random.Next(-1000, 1000);
                LstInput.Items.Add($"arrayInput[{i}]={arrayInput[i]}");
            }
        }

        private void BtnRezult_Click(object sender, RoutedEventArgs e)
        {
            for(int i=0; i<20; i++)
            {
                if(arrayInput[i] < 0)
                {
                    arrayRezult[i] = 0;
                }
                else
                {
                    arrayRezult[i] = arrayInput[i];
                }
                LstRezult.Items.Add($"arrayRezult[{i}]={arrayRezult[i]}");
            }
        }
    }
}
