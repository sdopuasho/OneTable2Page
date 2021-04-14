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

namespace Load3Window
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        MuchTable CurrentTable = new MuchTable();
        public FirstPage()
        {
            InitializeComponent();
            DataContext = CurrentTable;
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(CurrentTable.At1) ||string.IsNullOrEmpty(CurrentTable.At2) || CurrentTable.At3==0 || CurrentTable.At4 == 0 || CurrentTable.at5 == 0 || CurrentTable.at6 == 0 || CurrentTable.at7 == 0 || CurrentTable.at8 == 0)
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                ManagerOfFrame.MFrame.Navigate(new SecondPage(CurrentTable));
            }
        }
    }
}
