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
    /// Логика взаимодействия для reg.xaml
    /// </summary>
    public partial class reg : Window
    {
        public reg()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            MainWindow log = new MainWindow();
            log.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var login = lg.Text;
            var pass = pl.Text;
            var context = new AppDbContext();

            var user_exists = context.Users.FirstOrDefault(x => x.Login == login);
            if(user_exists != null) 
            {
                MessageBox.Show("Такой пользователь уже существует");
                return;
            }
            var user = new User { Login = login, Password = pass };
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("Добро пожаловать!");    
        }

    }
}
