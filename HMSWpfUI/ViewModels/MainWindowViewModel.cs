using HMSWpfUI.Views;
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

namespace HMSWpfUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {


        private readonly Action<UserControl> navigateToView;
        private RoomsView roomsView;
        private ClientsView clientsView;

        public MainWindowViewModel(Action<UserControl> navigateToView)
        {
            this.navigateToView = navigateToView;
            Initializate();
        }

        private void Initializate()
        {
            //roomsView = new RoomsView();
            //navigateToView(roomsView);
            clientsView = new ClientsView();
            navigateToView(clientsView);
        }
    }
}
