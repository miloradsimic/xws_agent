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
using XwsAgent.DataLayer;
using XwsAgent.Domain;
using XwsAgent.UILayer.ViewModel;

namespace XwsAgent.UILayer
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            DataContext = new LoginCredentialsVM();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginCredentialsVM viewModel = (LoginCredentialsVM)DataContext;
            LoginPort client = Globals.LoginClient;
            GetLoginResponse1 response = client.GetLogin(new GetLoginRequest1(new GetLoginRequest()
            {
                email = viewModel.Email,
                password = passwordBox.Password
            }));
            Globals.LoggedAgent = response.GetLoginResponse.AgentDetails;
            DialogResult = true;
            Close();
        }
    }
}
