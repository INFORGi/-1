using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Zayavka
    {
        string Name {  get; set; }
        string Num_z {  get; set; }
        string Reclama {  get; set; }
        string Obyem {  get; set; }
        string Izd {  get; set; }
        string Kol_vo_rek {  get; set; }
        string Dop_inf {  get; set; }
        string Date {  get; set; }

        public void Sdq(string[] q)
        {
            Name = q[0];
            Num_z = q[4];
            Reclama = q[7];
            Izd = q[5];
        }
        public void Fs(string t4, string t5,string t6, string t7)
        {
            Obyem = t4;
            Kol_vo_rek = t5;
            Dop_inf = t6;
            Date = t7;
        }

        public void Vvod()
        {
            StreamWriter sw = new StreamWriter("Заявка.txt", true);
            sw.WriteLine(Name+", "+Num_z+", "+Reclama+", "+Obyem+", "+Izd+", "+Kol_vo_rek+", "+Dop_inf+", "+Date);
            sw.Close();
        }
    }
}
