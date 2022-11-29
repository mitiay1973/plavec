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

namespace plavec
{
    /// <summary>
    /// Логика взаимодействия для preview.xaml
    /// </summary>
    public partial class preview : Page
    {
        public Frame frame1;
        public preview(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame1.Navigate(new glavnaya(frame1));
        }
    }
}
