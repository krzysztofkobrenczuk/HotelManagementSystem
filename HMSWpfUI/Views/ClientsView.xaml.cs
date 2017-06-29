using HotelManagementSystem.Data;
using HotelManagementSystem.Domain;
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

namespace HMSWpfUI.Views
{
    /// <summary>
    /// Interaction logic for ClientsView.xaml
    /// </summary>
    public partial class ClientsView : UserControl
    {
        private readonly ConnectedData _repo = new ConnectedData();
        private Client _currentClient;
        private bool _isListChanging;
        private bool _isLoading;
        private ObjectDataProvider _clientViewSource;


        public ClientsView()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _isLoading = true;
            clientListBox.ItemsSource = _repo.ClientsListInMemory();
            _clientViewSource = (ObjectDataProvider)FindResource("clientViewSource");
            _isLoading = false;
            clientListBox.SelectedIndex = 0;

        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            _repo.SaveChanges(_currentClient.GetType());
        }

        private void firstNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!_isLoading && !_isListChanging)
            {
                _currentClient.IsDirty = true;
            }
        }
        private void firstNameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            clientListBox.Items.Refresh();

        }

        private void listBox_OnSelectionChangedListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!_isLoading)
            {
                _isListChanging = true;
                _currentClient = _repo.LoadClientGraph((int)clientListBox.SelectedValue);
                _clientViewSource.ObjectInstance = _currentClient;
                _isListChanging = false;
            }
        }

        private void newBtn_Click(object sender, RoutedEventArgs e)
        {
            _currentClient = _repo.CreateNewClient();
            _clientViewSource.ObjectInstance = _currentClient;
            clientListBox.SelectedItem = _currentClient;
        }
    }
}
