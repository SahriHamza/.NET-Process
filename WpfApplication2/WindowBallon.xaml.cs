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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for WindowBallon.xaml
    /// </summary>
    public partial class WindowBallon : Window
    {
        public WindowBallon()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult key = MessageBox.Show(
               "Etes-vous sûre de vouloir quitter",
               "Confirmez",
               MessageBoxButton.YesNo,
                MessageBoxImage.Question,
                MessageBoxResult.No);
            if (!(e.Cancel = (key == MessageBoxResult.No)))
            {
                e.Cancel = false;
            }
        }
    }
}
