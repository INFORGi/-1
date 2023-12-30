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
using System.IO;
using System.Reflection;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        int q = File.ReadLines("Рекламодатель.txt").Count();

        List<string> dd = new List<string> { };
        List<string> dd2 = new List<string> { };
        Zayavka z = new Zayavka();
        public Window3()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader("Рекламодатель.txt");
            string[] s3 = new string[q];

            for (int i = 0; i < q; i++)
            {
                string s = sr.ReadLine();
                string[] s2 = s.Split(',');
                s3[i] = s2[0];
            }

            var result = s3.Distinct();

            foreach (string s in result)
            {
                cb1.Items.Add(s);
                dd.Add(s);
            }
            sr.Close();
        }
        private void cb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cb2.Items.Clear();
            dd2.Clear();
            StreamReader sr = new StreamReader("Рекламодатель.txt");
            int index = cb1.SelectedIndex;
            for (int i = 0; i < q; i++)
            {
                string w2 = sr.ReadLine();
                string[] w3 = w2.Split(',');
                if (dd[index] == w3[0])
                {
                    dd2.Add(w3[4]);

                }
            }
            var result = dd2.Distinct();
            foreach (string s in result)
            {
                cb2.Items.Add(s);
            }
        }

        private void cb2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lb3.Items.Clear();
            int index = cb1.SelectedIndex;
            object index2 = cb2.SelectedItem;

            

            StreamReader sr2 = new StreamReader("Рекламодатель.txt");
            for (int i = 0; i < q; i++)
            {
                string q = sr2.ReadLine();
                string[] q2 = q.Split(',');
                if (q2[4] == (string)index2)
                {
                    lb3.Items.Add(q2[7]);
                    lb4.Content = q2[5];
                    string[] u = new string[] { q2[7] };
                    z.Sdq(q2);
                }
            }
            sr2.Close();
        }

        private void dsd(object sender, RoutedEventArgs e)
        {
            string t4 = tx4.Text;
            string t5 = tx5.Text;
            string t6 = tx6.Text;
            string t7 = tx7.Text;

            z.Fs(t4, t5, t6, t7);
            z.Vvod();
        }

        private void dsdв(object sender, RoutedEventArgs e)
        {
            MainWindow n= new MainWindow();
            n.Show();
            this.Close();
        }
    }
}
