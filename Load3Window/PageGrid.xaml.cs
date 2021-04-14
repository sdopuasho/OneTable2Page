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
    /// Логика взаимодействия для PageGrid.xaml
    /// </summary>
    public partial class PageGrid : Page
    {
        public PageGrid()
        {
            InitializeComponent();
            DgridPageGrid.ItemsSource = OneTableMuchEntities.GetContext().MuchTable.ToList();
        }

        private void NewBtn_Click(object sender, RoutedEventArgs e)
        {
            ManagerOfFrame.MFrame.Navigate(new FirstPage());
        }
    }
}
