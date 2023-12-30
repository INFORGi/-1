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
using System.Text.RegularExpressions;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>();
        int count = File.ReadLines("Заявка.txt").Count();
        private void dsd(object sender, RoutedEventArgs e)
        {
            try
            {
                l1.Items.Clear();
                StreamReader sr = new StreamReader("Заявка.txt");
                string dat = tx1.Text;
                Regex r = new Regex(@"\d{2}.\d{2}.\d{4}");
                if (r.IsMatch(dat))
                {
                    for (int i = 0; i < count; i++)
                    {
                        string line = sr.ReadLine();
                        if (line != null)
                        {
                            string[] split = line.Split(',');

                            int a = split[7].IndexOf(dat);
                            if (a > -1)
                            {
                                l1.Items.Add(line);
                                dsad.Visibility = Visibility.Visible;
                            }
                        }
                    }
                    sr.Close();
                }
                else
                    throw new Exception("Введите дату");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dsad_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("Заявка.txt");
            int index = l1.SelectedIndex;
            string line = l1.Items[index].ToString();

            string[] file = new string[count];
            for (int i = 0; i < count; i++)
            {
                string d = sr.ReadLine();
                if (line == d)
                {
                    StreamWriter sr2 = new StreamWriter("Выполнены.txt", true);
                    sr2.WriteLine(line);
                    sr2.Close();

                    l1.Items[index] = null;
                }
                else
                    file[i] = d;
            }
            sr.Close();
            StreamWriter sw = new StreamWriter("Заявка.txt", false);
            for (int i = 0; i < file.Length; i++)
            {
                sw.WriteLineAsync(file[i]);
            }
            sw.Close();
        }

        private void ds_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("Выполнены.txt");
            l1.Items.Clear();
            l1.Items.Add(sr.ReadToEnd());
            sr.Close();
        }

        private void dsdad_Click(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader("Заявка.txt");
            l1.Items.Clear();
            l1.Items.Add(sr.ReadToEnd());
            sr.Close();
        }
    }
}
