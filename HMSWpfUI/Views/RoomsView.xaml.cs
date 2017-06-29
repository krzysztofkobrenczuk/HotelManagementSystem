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
    /// Interaction logic for RoomsView.xaml
    /// </summary>
    public partial class RoomsView : UserControl
    {
        private readonly ConnectedData _repo = new ConnectedData();
        private List<Client> _avaibleClients;
        private ObjectDataProvider _roomsViewSource;
        private Room _currentRoom;
        private bool _isListChanging;
        private bool _isLoading;
        private Point _startPoint;

        public RoomsView()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            _isLoading = true;
            RoomListBox.ItemsSource = _repo.RoomsListInMemory();
            _roomsViewSource = (ObjectDataProvider)FindResource("roomViewSource");
            _isLoading = false;
            RoomListBox.SelectedIndex = 0;

        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            _repo.SaveChanges(_currentRoom.GetType());
        }

        private void capacityTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!_isLoading && !_isListChanging)
            {
                _currentRoom.IsDirty = true;
            }
        }
        private void capacityTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            RoomListBox.Items.Refresh();
        }

        private void descriptionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void pricePerDayTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RoomListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!_isLoading)
            {
                _isListChanging = true;
                _currentRoom = _repo.LoadRoomGraph((int)RoomListBox.SelectedValue);
                _roomsViewSource.ObjectInstance = _currentRoom;
                _isListChanging = false;
            }
        }
    }
}
