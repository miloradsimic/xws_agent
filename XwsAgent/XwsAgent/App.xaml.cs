using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using XwsAgent.UILayer;
using XwsAgent.UILayer.ViewModel;

namespace XwsAgent
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            Globals.LoginClient = new LoginPortClient();
            Globals.AccommodationsClient = new AccommodationsPortClient();

            LoginWindow loginWindow = new LoginWindow();
            loginWindow.ShowDialog();

            MainWindow.Show();
            /*
            GetLoginResponse1 loginResponse = Globals.LoginClient.GetLogin(new GetLoginRequest1(new GetLoginRequest()
            {
                email = "ag1@a.a",
                password = "pass"
            }));
            Globals.LoggedAgent = loginResponse.GetLoginResponse.AgentDetails;

            GetAllAccommodationsResponse1 accResponse = Globals.AccommodationsClient.GetAllAccommodations(
                new GetAllAccommodationsRequest1(
                    new GetAllAccommodationsRequest()
                    {
                        auth_token = Globals.LoggedAgent.auth_token,
                        id = Globals.LoggedAgent.id
                    }));
            ObservableCollection<AccommodationVM> vmCollection = new ObservableCollection<AccommodationVM>(
                accResponse.GetAllAccommodationsResponse.Accommodations.Accommodation.Select(xmlAccommodation => new AccommodationVM
                {
                    Address = xmlAccommodation.address,
                    Category = xmlAccommodation.category.ToString(),
                    Type = xmlAccommodation.type,
                    ImageUri = xmlAccommodation.image_uri
                }).ToList());
            try
            {
                AccommodationsWindowVM vm = new AccommodationsWindowVM()
                {
                    Accommodations = vmCollection
                };
                AccommodationsWindow window = new AccommodationsWindow
                {
                    DataContext = vm
                };
                window.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }
    }
}
