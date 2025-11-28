using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Gui.Models;


namespace ShopList.Gui.ViewModels
{
    public partial class ItemDetailsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _nombre = string.Empty;

        [ObservableProperty]
        private int _cantidad = 1;
        private readonly Action<ShopListItem> _returnDataCallBack;


        public ItemDetailsViewModel(
            Action<ShopListItem> returnDataCallBack)
        {
            _returnDataCallBack = returnDataCallBack;
        }

        [RelayCommand]
        public async Task Guardad()
        {
            if (!string.IsNullOrEmpty(this.Nombre)
                && this.Cantidad >= 1)
            {
                var item = new ShopListItem()
                {
                    Nombre = this.Nombre,
                    Cantidad = this.Cantidad,
                    Comprado = false,
                };
                _returnDataCallBack(item);
                //Shell.Current.GoToAsync("..");           
                await Shell.Current.Navigation.PopAsync();
            }
        }

        [RelayCommand]
        public async Task Cancelar()
        {
            //await Shell.Current.GoToAsync("..");
            await Shell.Current.Navigation.PopAsync();
        }
    }
}
