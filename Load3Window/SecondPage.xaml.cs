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
    /// Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        MuchTable CurrentTable = new MuchTable();
        public SecondPage(MuchTable SelectedMuchTable)
        {
            InitializeComponent();
            CurrentTable = SelectedMuchTable;
            DataContext = CurrentTable;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if ( CurrentTable.at9 == 0 || CurrentTable.at10 == 0 || CurrentTable.at11 == 0 || CurrentTable.at12 == 0 || CurrentTable.at13 == 0)
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (CurrentTable.id == 0)
                    OneTableMuchEntities.GetContext().MuchTable.Add(CurrentTable);
                try
                {
                    OneTableMuchEntities.GetContext().SaveChanges();
                    MessageBox.Show("Запись добавленна ", "Внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                    ManagerOfFrame.MFrame.Navigate(new PageGrid());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
    }
}
