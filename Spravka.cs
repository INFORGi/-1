using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;
using System.Windows;
using System.Runtime.Remoting.Messaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    internal class Spravka
    {
        string Name { get; set; }
        string Type { get; set; }
        string Reklama { get; set; }

        public Spravka(string tx1, string tx2, string tx3)
        {
            Name = tx1;
            Type = tx2;
            Reklama = tx3;
            Vvod2();
        }
        private void Vvod2()
        {
            StreamReader sr = new StreamReader("Печатные издания.txt");
            int d=File.ReadLines("Печатные издания.txt").Count();
            string[] line = new string[d];
            string[] line2 = new string[d];
            string[] ss = new string[] { };
            for (int i = 0; i < d; i++)
            {
                string s = sr.ReadLine();
                ss=s.Split(',');
                line[i]= ss[0];
                line2[i]= ss[1];
            }
            sr.Close();
            StreamWriter sw = new StreamWriter("Печатные издания.txt", true);
            bool index = line.Contains(Name);
            bool index2 = line2.Contains(Type);
            if (index != true & index2 != true || index != false & index2 != true)
            {
                sw.WriteLine(Name + "," + Type + "," + Reklama);
                MessageBox.Show("Данные внесены");
            }
            else
                MessageBox.Show("Такиe данные уже есть");
            sw.Close();
        }
    }
}
