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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

//          Диаграмма классов:
//          Бизнес-правила «РЕКЛАМНОЕ АГЕНТСТВО». 
//          Создаваемая информационная система должна вести учет деятельности рекламного агентства.
//          Рекламное агентство регистрирует заявки от рекламодателей и публикует рекламы в печатных изданиях.

//          О рекламодателе регистрируются следующие данные: Наименование, Адрес, Руководитель, Телефон, Заявка, Оплата, Издание, Место размещения рекламы.

//          Заявка включает: Вид рекламы, Объем, Желаемые издания, Количество выходов рекламы,
//          Дополнительная информация. Заявка от рекламодателя может содержать публикацию в несколько печатных изданиях и на различные даты выхода.

//          Справочник печатных изданий включает: Наименование, Виды реклам, Стоимость рекламы. 

//          Требуется вести списки печатных изданий с их расценками на рекламу, списки рекламодателей, заявок.

//          Система должна обеспечить оперативный просмотр списка заявок (печатные издания, рекламодатель, стоимость)
//          на любую вводимую дату, а также формирование отчета о заявленных и выполненных рекламах
        private void click2(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
            this.Close();
        }

        private void click3(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            w2.Show();
            this.Close();
        }

        private void click4(object sender, RoutedEventArgs e)
        {
            Window3 w3 = new Window3();
            w3.Show();
            this.Close();
        }

        private void click5(object sender, RoutedEventArgs e)
        {
            Window4 w4 = new Window4();
            w4.Show();
            this.Close();
        }
    }
}
