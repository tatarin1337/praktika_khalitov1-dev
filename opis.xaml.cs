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
using System.Windows.Shapes;

namespace praktika_khalitov1
{
    /// <summary>
    /// Логика взаимодействия для opis.xaml
    /// </summary>
    public partial class opis : Window
    {
        public opis()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            glav glav = new glav();
            glav.Show();
        }
    }
}
