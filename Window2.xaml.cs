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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void dsd(object sender, RoutedEventArgs e)
        {
            try
            {
                string ts1 = tx1.Text;
                string ts2 = tx2.Text;
                int ts4 = int.Parse(tx3.Text);
                string ts5 = ts4.ToString();


                if (ts1 != "" & ts2 != "" & ts5 != "")
                {
                    Spravka sp = new Spravka(ts1, ts2, ts5);
                }
                else
                    throw new Exception("Заолните все поля");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ds(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
