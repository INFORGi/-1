using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace WpfApp1
{
    internal class Reclamodatel
    {
        string Name { get; set; }
        string Adress { get; set; }
        string Rukovoditel { get; set; }
        string Number { get; set; }
        string Zayavka { get; set; }
        string Oplata { get; set; }
        string Izdanie { get; set; }
        string Mesto { get; set; }

        public void Vvod(string tx1, string tx2, string tx3, string tx4, string tx5, string tx7)
        {
            Name = tx1;
            Adress = tx2;
            Rukovoditel = tx3;
            Number = tx4;
            Zayavka = tx5;
            Izdanie = tx7;

            StreamWriter sw = new StreamWriter("Рекламодатель.txt", true);
            sw.WriteLine(Name + "," + Adress + "," + Rukovoditel + "," + Number + "," + Zayavka + "," + Izdanie + "," + Oplata + "," + Mesto);
            sw.Close();
            MessageBox.Show("Данные внесены");
        }

        public void Vvod2(string w, string w2)
        {
            Oplata = w;
            Mesto = w2;
        }
    }
}
