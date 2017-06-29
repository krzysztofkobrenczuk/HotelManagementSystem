using HotelManagementSystem.Data;
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
    /// Interaction logic for Clientroom.xaml
    /// </summary>
    public partial class Clientroom : Window
    {

        private readonly ConnectedData _repo = new ConnectedData();
        private List<Clientroom> _avaibleClientRooms;
        private ObjectDataProvider _clientRoomViewSource;
        private bool _isLoading;
        public Clientroom()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _isLoading = true;
            clientRoomDataGrid.ItemsSource = _repo.ClientRoomListInMemory();
            _clientRoomViewSource = (ObjectDataProvider)FindResource("clientRoomViewSource");
            _isLoading = false;
            clientRoomDataGrid.SelectedIndex = 0;

            
        }

        private void clientRoomDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
