using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using XwsAgent.UILayer.ViewModel;

namespace XwsAgent.UILayer
{
    /// <summary>
    /// Interaction logic for AccommodationsWindow.xaml
    /// </summary>
    public partial class AccommodationsWindow : Window
    {
        public AccommodationsWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GetAllAccommodationsResponse1 accommodationsResponse = Globals.AccommodationsClient.GetAllAccommodations(
                new GetAllAccommodationsRequest1(
                    new GetAllAccommodationsRequest()
                    {
                        auth_token = Globals.LoggedAgent.auth_token,
                        id = Globals.LoggedAgent.id
                    }));
            ObservableCollection<AccommodationVM> vmCollection = new ObservableCollection<AccommodationVM>(
                accommodationsResponse.GetAllAccommodationsResponse.Accommodations.Accommodation.Select(
                    xmlAccommodation => new AccommodationVM
                    {
                        Address = xmlAccommodation.address,
                        Category = xmlAccommodation.category.ToString(),
                        Type = xmlAccommodation.type,
                        ImageUri = xmlAccommodation.image_uri
                    }).ToList());
            DataContext = new AccommodationsWindowVM()
            {
                Accommodations = vmCollection
            };
            
        }
    }
}
