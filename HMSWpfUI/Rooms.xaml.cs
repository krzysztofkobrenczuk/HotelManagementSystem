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
using System.Windows.Shapes;

namespace HMSWpfUI
{
    /// <summary>
    /// Interaction logic for Rooms.xaml
    /// </summary>
    public partial class Rooms : Window
    {
        private readonly ConnectedData _repo = new ConnectedData();
        private List<Client> _avaibleClients;
        private ObjectDataProvider _roomsViewSource;
        private Room _currentRoom;
        private bool _isListChanging;
        private bool _isLoading;
        private Point _startPoint;


        public Rooms()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _isLoading = true;
            RoomListBox.ItemsSource = _repo.RoomsListInMemory();
            _roomsViewSource = (ObjectDataProvider)FindResource("roomViewSource");
            _isLoading = false;
            RoomListBox.SelectedIndex = 0;
        }

        private void RoomListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
