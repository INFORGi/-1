using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader("Печатные издания.txt");
            int d = File.ReadLines("Печатные издания.txt").Count();
            string[] line = new string[d];
            string[] line2 = new string[d];
            string[] ss = new string[] { };
            for (int i = 0; i < d; i++)
            {
                string s = sr.ReadLine();
                ss = s.Split(',');
                line2[i] = ss[1];
                tx7.Items.Add($"{ss[0]}, {ss[1]}");
            }
            sr.Close();
        }
        Reclamodatel ru = new Reclamodatel();

        private void hfhd(object sender, RoutedEventArgs e)
        {
            try
            {
                string t1 = tx1.Text;
                string t2 = tx2.Text;
                string t3 = tx3.Text;
                string t4 = tx4.Text;
                string t5 =tx5.Text;
                string[] t7 = tx7.Text.Split(',');

                if (t1 != "" & t2 != "" & t3 != "" & t4 != "" & t5 != "" & t7[0] != "")
                {
                    ru.Vvod(t1,t2,t3,t4,t5,t7[0]);
                }
                else
                    throw new Exception("Заолните все поля");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tx7_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StreamReader sr = new StreamReader("Печатные издания.txt");
            int d = File.ReadLines("Печатные издания.txt").Count();
            string[] line2 = new string[d];
            string[] line = new string[d];
            string[] ss = new string[] { };
            for (int i = 0; i < d; i++)
            {
                string s = sr.ReadLine();
                ss = s.Split(',');
                line[i] = ss[2];
                line2[i] = ss[1];
            }
            sr.Close();
            int index = tx7.SelectedIndex;
            lll.Content = line[index];
            llll.Content = line2[index];
            ru.Vvod2(line[index], line2[index]);
        }

        private void hd(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void click(object sender, RoutedEventArgs e)
        {
            Window3 w3=new Window3();
            w3.Show();
            this.Close();
        }
    }
}
