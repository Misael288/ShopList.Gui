using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Gui.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;


namespace ShopList.Gui.ViewModels
{
    public partial class ShopListViewModel : ObservableObject
    {
        public ObservableCollection<ShopListItem> Items { get; }

        public ShopListViewModel()
        {
            Items = new ObservableCollection<ShopListItem>();
            CargarDatos();
        }

        private void CargarDatos()
        {
            Items.Add(new ShopListItem
            {
                Id = 1,
                Nombre = "Leche",
                Cantidad = 2,
                Comprado = false,
            });
            Items.Add(new ShopListItem
            {
                Id = 2,
                Nombre = "Pan de caja",
                Cantidad = 1,
                Comprado = false,
            });
            Items.Add(new ShopListItem
            {
                Id = 3,
                Nombre = "Huevos",
                Cantidad = 12,
                Comprado = false,
            });
        }
        [RelayCommand]
    public async void  AddItem()
        {
           await Shell.Current.GoToAsync("itemdetails");
        }
    
    }



}
