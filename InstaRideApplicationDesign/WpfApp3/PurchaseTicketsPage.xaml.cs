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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for PurchaseTicketsPage.xaml
    /// </summary>
    public partial class PurchaseTicketsPage : Page
    {
        public PurchaseTicketsPage()
        {
            InitializeComponent();
        }

        private void ActiveTicketDown(object sender, MouseButtonEventArgs e)
        {
            if (SP3.Height == 45)
            {
                SP3.Height += 440;
                TBPress.Visibility = Visibility.Hidden;
            }
            else
            {
                SP3.Height -= 440;
                TBPress.Visibility = Visibility.Visible;
            }
        }

        private void AdultTickets(object sender, MouseButtonEventArgs e)
        {
            if (SPA.Height == 50)
            {
                SPA.Height = 200;
            }
            else
            {
                SPA.Height = 50;
            }
        }

        private void YouthTickets(object sender, MouseButtonEventArgs e)
        {
            if (SPY.Height == 50)
            {
                SPY.Height = 200;
                SPA.Visibility = Visibility.Collapsed;
            }
            else
            {
                SPY.Height = 50;
                SPA.Visibility = Visibility.Visible;
            }
        }

        private void SeniorTickets(object sender, MouseButtonEventArgs e)
        {
            if (SPS.Height == 50)
            {
                SPS.Height = 200;
                SPA.Visibility = Visibility.Collapsed;
                SPY.Visibility = Visibility.Collapsed;
            }
            else
            {
                SPS.Height = 50;
                SPA.Visibility = Visibility.Visible;
                SPY.Visibility = Visibility.Visible;
            }
        }

        private void backBtn(object sender, MouseButtonEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new AddOptionsPage());
        }

        private void paymentBtn(object sender, RoutedEventArgs e)
        {
            var nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new PaymentOptionsPage());
        }
    }
}
