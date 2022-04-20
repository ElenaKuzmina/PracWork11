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
                LstInput.Items.Add(new ListViewItem { Content = $"arrayInput[{i}]={arrayInput[i]}" });
            }
        }

        private void BtnRezult_Click(object sender, RoutedEventArgs e)
        {
            Brush br = (Brush)(new BrushConverter()).ConvertFrom("#FFFFFFE1");
            br = Brushes.LightGreen;
            //var item = (from ListBoxItem i in LstInput.Items
                        
            //            where LstInput.Items[i] < 0
            //            select i).FirstOrDefault();
            //if (item != null)
            //    item.Foreground = Brushes.Red;
            for (int i=0; i<20; i++)
            {
                if(arrayInput[i] < 0)
                {
                    arrayRezult[i] = 0;
                    var Item = (ListBoxItem)LstInput.Items[i];
                    Item.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff4e33"));
                    Item.FontWeight = FontWeights.Bold;
                }
                else
                {
                    arrayRezult[i] = arrayInput[i];
                }
                LstRezult.Items.Add($"arrayRezult[{i}]={arrayRezult[i]}");
            }
        }

        private void BtnChange_Click(object sender, RoutedEventArgs e)
        {
            int number = 0;
            TxtMinim.Text = arrayInput.Min().ToString();
            for(int i=0; i<20;i++)
            {
                if (arrayInput[i] == arrayInput.Min())
                {
                   number = i;
                    break;
                }
                   
            }
            TxtMinim.Text += $"  {number}";

            int change = arrayInput[number];
            arrayInput[number] = arrayInput[19];
            arrayInput[19] = change;

            for (int i = 0; i < 20; i++)
            {
                
                LstInput.Items.Add($"arrayInput[{i}]={arrayInput[i]}");
            }
        }
    }
}
