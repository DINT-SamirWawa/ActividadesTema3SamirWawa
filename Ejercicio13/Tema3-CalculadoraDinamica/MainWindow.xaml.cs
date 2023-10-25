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

namespace Tema3_CalculadoraDinamica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int c = 1;
            for(int i = 2; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {


                    Button miBoton = new Button();
                    miBoton.Content = c;
                    miBoton.Click += Click_Button;
                    nums.Children.Add(miBoton);
                    Grid.SetColumn(miBoton, j);
                    Grid.SetRow(miBoton, i);
                    c++;
                }
            }
        }
        private void Click_Button(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;
            caja.Text += boton.Content.ToString();
        }
    }
}
